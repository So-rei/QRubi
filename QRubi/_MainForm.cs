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

        public _MainForm()
        {
            InitializeComponent();

            //初期値セット
            txtLoadTargetFile.Text = ConfigClass.LoadFilePath;
            txtLoadTargetFolder.Text = ConfigClass.LoadFolderPath;
            txtSaveTargetFolder.Text = ConfigClass.SaveFolderPath;
            chkChange1.Checked = ConfigClass.IsChk1;
            chkChange2.Checked = ConfigClass.IsChk2;

            foreach (var c in ConfigClass.DicPath())
            {
                lbDic.Items.Add(c);
            }

            chkOption_CheckedChanged(null, null);
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
                InName.Add(txtLoadTargetFile.Text);
            else
                InName.AddRange(GetLoadFiles());
            if (InName.Count() == 0) return;

            var OutName = GetSaveFile();
            if (OutName == "") return;

            var slbDic = new List<string>();
            foreach (var c in lbDic.Items)
            {
                slbDic.Add(@c.ToString());
            }

            var CheckedChangeMode = new List<int>();
            if (chkChange1.Checked) CheckedChangeMode.Add(1);
            if (chkChange2.Checked) CheckedChangeMode.Add(2);

            //作業中ダイアログ
            var cfrm = new frmDialog();
            cfrm.Show();

            //メイン処理
            var cExChangeCls = new ExChangeCls(CheckedChangeMode, InName, OutName, slbDic, cfrm);

            cfrm.Close();
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

        private void btnLoadTargetFile_Click(object sender, EventArgs e)
        {
            try
            {
                //OpenFileDialogクラスのインスタンスを作成
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.FileName = "default.html";
                ofd.InitialDirectory = @txtLoadTargetFile.Text;
                ofd.Filter = "TXTファイル|*.txt";
                ofd.FilterIndex = 1;
                ofd.Title = "開くファイルを選択してください";
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;

                //ダイアログを表示する
                if (ofd.ShowDialog() == DialogResult.OK)
                    txtLoadTargetFile.Text = ofd.FileName;

                return;
            }
            catch (Exception ex)
            {
                lbLog.Text += "\r\n" + ex.Message;
                return;
            }
        }
    }
}
