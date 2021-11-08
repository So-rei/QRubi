using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QRubi
{
    /// <summary>
    /// ファイルパス関係
    /// </summary>
    public class ExChangeCls
    {
        private static IEnumerable<int> ChangeMode { get; set; }
        private static IEnumerable<string> InName { get; set; }
        private static string OutName { get; set; }
        private static string DicName { get; set; }

        private static IOrderedEnumerable<KeyValuePair<string, string>> Libs;

        private static frmDialog cFrm { get; set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ChangeMode">変換モード</param>
        /// <param name="InName">変換するファイル</param>
        /// <param name="OutName">変換先フォルダパス</param>
        /// <param name="cfrm">プログレスバーfrm option</param>
        public ExChangeCls(IEnumerable<int> _ChangeMode, IEnumerable<string> _InName, string _OutName, IEnumerable<string> _DicName, frmDialog _cfrm = null)
        {
            ChangeMode = _ChangeMode;
            InName = _InName;
            OutName = _OutName;
            cFrm = _cfrm;

            SetDic(_DicName);

            MainLoop();
        }

        //辞書リストセット
        private void SetDic(IEnumerable<string> _DicName)
        {
            var tDic = new Dictionary<string, string>();
            //ファイル別並列処理
            Parallel.ForEach(_DicName, sIn =>
            {
                using (var sr = new System.IO.StreamReader(@sIn, System.Text.Encoding.GetEncoding("utf-8")))
                {
                    while (sr.Peek() > -1)
                    {
                        var s = sr.ReadLine().Split('\t');
                        if (!tDic.ContainsKey(s[0])) //重複不可
                            tDic.Add(s[0], s[1]);
                    }
                }
            });

            Libs = tDic.OrderByDescending(p => p.Key.Length); //長い順にマッチ確認するため
        }

        //メインループ
        private void MainLoop()
        {
            //ファイル数でざっくり分割
            //bool bBar = cFrm != null;
            //if (bBar)
            //    cFrm.progressBar1.Value = 0;
            //var perBar = bBar ? cFrm.progressBar1.Maximum / InName.Count() / ChangeMode.Count() : 0;

            //モード別並列処理
            Parallel.ForEach(ChangeMode, cm =>
            {
                //ファイル別並列処理
                Parallel.ForEach(InName, sIn =>
                {
                    //行単位で処理
                    string outputfileName = @OutName + "【ルビ済】" + sIn.Split('\\').Last();
                    var sb = new System.Text.StringBuilder();

                    using (var sr = new System.IO.StreamReader(@sIn, System.Text.Encoding.GetEncoding("utf-8")))
                    using (var sw = new System.IO.StreamWriter(@outputfileName, false, System.Text.Encoding.GetEncoding("utf-8")))
                    {
                        while (sr.Peek() > -1)
                        {
                            var s0 = ChangeFormat(cm, sr.ReadLine());
                            sw.WriteLine(s0);
                        }
                    }

                    //if (bBar) cFrm.progressBar1.Value += perBar;
                });
            });
        }

        //ルビ振りメイン処理
        public static string ChangeFormat(int cm, string srow)
        {
            string sx = srow.Replace("《", "｜《").Replace("》", "｜》"); //元からある二重括弧はエスケープ

            //各記法によって辞書セットしていく...
            //カクヨムもなろうも同じ？
            switch (cm)
            {
                case 1:
                case 2:
                    foreach (var c in Libs)
                    {
                        sx = sx.Replace(c.Key, '｜' + c.Key + "《" + c.Value + "》"); //カナに対してさらにカナがつかないようにする処理は入れていない。
                    }
                    break;
            }
            return sx;
        }
    }
}
