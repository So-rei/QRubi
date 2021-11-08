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
        private IEnumerable<int> ChangeMode { get; set; }
        private IEnumerable<string> InName { get; set; }
        private string OutName { get; set; }
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ChangeMode">変換モード</param>
        /// <param name="InName">変換するファイル</param>
        /// <param name="OutName">変換先フォルダパス</param>
        /// <param name="cfrm">プログレスバーfrm option</param>
        public ExChangeCls(IEnumerable<int> _ChangeMode, IEnumerable<string> _InName, string _OutName, frmDialog cfrm = null)
        {
            ChangeMode = _ChangeMode;
            InName = _InName;
            OutName = _OutName;

            if (cfrm != null)
                MainLoop(cfrm);
            //else
            //    MainLoop();

        }

        //メインループ
        private void MainLoop(frmDialog cfrm)
        {
            //ファイル数でざっくり分割
            cfrm.progressBar1.Value = 0;
            var perBar = cfrm == null ? 0 : cfrm.progressBar1.Maximum / InName.Count();

            //並列処理
            Parallel.ForEach(InName, sIn =>
            {
                string outputfileName = @OutName + sIn.Split('\\').Last();
                var sb = new System.Text.StringBuilder();

                using (var sr = new System.IO.StreamReader(@sIn, System.Text.Encoding.GetEncoding("shift_jis")))
                using (var sw = new System.IO.StreamWriter(outputfileName, true, System.Text.Encoding.GetEncoding("shift_jis")))
                {
                    var s0 = ChangeFormat(sr.ReadLine());
                    sw.WriteLine(s0);
                }

                cfrm.progressBar1.Value += perBar;
            });
        }

        //TODO
        //private void MainLoop()
        //{
        //}

        //ルビ振りメイン処理
        public static string ChangeFormat(string s)
        {
            return s;
        }
    }
}
