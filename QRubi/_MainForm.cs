using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRubi
{
    public partial class _MainForm : Form
    {
        private ConfigClass cConfigClass = new ConfigClass();

        public _MainForm()
        {
            InitializeComponent();

            //初期値セット
            txtLoadTargetFile.Text = cConfigClass.LoadFilePath;
            txtLoadTargetFolder.Text = cConfigClass.LoadFolderPath;
            txtSaveTargetFolder.Text = cConfigClass.SaveFolderPath;
            chkChange1.Checked = cConfigClass.IsChk1;
            chkChange2.Checked = cConfigClass.IsChk2;
        }

        /// <summary>
        /// メイン処理開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //パス確認・取得
            var InName = new List<string>();
            if (rdoFile.Checked)
                InName.Add(GetLoadFile());
            else
                InName.AddRange(GetLoadFiles());
            if (InName.Count() == 0) return;

            var OutName = GetSaveFile();
            if (OutName == "") return;

            //作業中ダイアログ
            var cfrm = new frmDialog();
            cfrm.Show();

            //メイン処理
            var cExChangeCls = new ExChangeCls(InName, OutName, cfrm);
        }

        //ファイル１つだけ
        private string GetLoadFile()
        {
            try
            {
                //OpenFileDialogクラスのインスタンスを作成
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.FileName = "default.html";
                ofd.InitialDirectory = @txtLoadTargetFile.Text;
                ofd.Filter = "*.txt";
                ofd.FilterIndex = 1;
                ofd.Title = "開くファイルを選択してください";
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;

                //ダイアログを表示する
                if (ofd.ShowDialog() == DialogResult.OK)
                    return ofd.FileName;

                return null;
            }
            catch (Exception ex)
            {
                lbLog.Text += "\r\n" + ex.Message;
                return null;
            }
        }

        //TODO フォルダごと取る時
        private IEnumerable<string> GetLoadFiles()
        {
            yield return "";
        }

        private string GetSaveFile()
        {
            return System.IO.Directory.Exists(@txtSaveTargetFolder.Text) ? @txtSaveTargetFolder.Text : "";
        }


        #region その他処理
        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            //変換項目がないと開始押せない
            if (this.Controls.OfType<CheckBox>().Select(p => p.Checked).Count() == 0)
                btnStart.Enabled = true;
        }
        #endregion

    }
}
