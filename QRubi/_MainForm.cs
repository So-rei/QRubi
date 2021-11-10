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

            //制御状態初期値
            ModeChange(true);
            chkOption_CheckedChanged(null, null);
        }

        /// <summary>
        /// メイン処理開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            lbLog.Text += "\r\n" + DateTime.Now.ToLongTimeString() + " 処理開始...";

            //パス確認・取得
            var InName = new List<string>();

            //ロード元：ファイル単位 or フォルダ内まるごと
            if (rdoFile.Checked)
                InName.Add(txtLoadTargetFile.Text);
            else
                InName.AddRange(System.IO.Directory.GetFiles(@txtLoadTargetFolder.Text, "*", System.IO.SearchOption.AllDirectories));
            if (InName.Count() == 0) return;

            //セーブ先：
            var OutName = System.IO.Directory.Exists(@txtSaveTargetFolder.Text) ? @txtSaveTargetFolder.Text : "";
            if (OutName == "") return;

            var slbDic = new List<string>();
            foreach (var c in lbDic.Items)
            {
                slbDic.Add(@c.ToString());
            }

            var CheckedChangeMode = new List<int>();
            if (chkChange1.Checked) CheckedChangeMode.Add(1);
            if (chkChange2.Checked) CheckedChangeMode.Add(2);

            lbLog.Text += "\r\n" + DateTime.Now.ToLongTimeString() + String.Format("{0}個のファイルを変換しています...", InName.Count().ToString());

            //作業中ダイアログ
            var cfrm = new frmDialog();
            cfrm.Show();

            //メイン処理
            var cExChangeCls = new ExChangeCls(CheckedChangeMode, InName, OutName, slbDic, cfrm);

            cfrm.Close();
            lbLog.Text += "\r\n" + DateTime.Now.ToLongTimeString() + " 処理完了";
        }


        #region その他処理
        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            //変換項目がないと開始押せない
            if (this.Controls.OfType<CheckBox>().Select(p => p.Checked).Count() == 0)
                btnStart.Enabled = true;
        }
        #endregion


        //ロードファイル選択
        private void btnLoadTargetFile_Click(object sender, EventArgs e)
        {
            txtLoadTargetFile.Text = GetOpenFileName();
        }
        //ロードフォルダ選択
        private void btnLoadTargetFolder_Click(object sender, EventArgs e)
        {
            txtLoadTargetFolder.Text = GetFolderName();
        }
        //セーブフォルダ選択
        private void btnSaveTargetFolder_Click(object sender, EventArgs e)
        {
            txtSaveTargetFolder.Text = GetFolderName();
        }

        //辞書追加・削除
        private void btnAddDic_Click(object sender, EventArgs e)
        {
            lbDic.Items.Add(GetOpenFileName());
        }
        private void btnRemDic_Click(object sender, EventArgs e)
        {
            int index = lbDic.SelectedIndex;
            if (index >= 0)
                lbDic.Items.RemoveAt(index);
        }


        private string GetOpenFileName()
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
                    return ofd.FileName;

                return "";
            }
            catch (Exception ex)
            {
                lbLog.Text += "\r\n" + ex.Message;
                return "";
            }
        }
        private string GetFolderName()
        {
            try
            {
                //FolderBrowserDialogクラスのインスタンスを作成
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                //上部に表示する説明テキストを指定する
                fbd.Description = "フォルダを指定してください。";
                //ルートフォルダを指定する
                //デフォルトでDesktop
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                //最初に選択するフォルダを指定する
                //RootFolder以下にあるフォルダである必要がある
                fbd.SelectedPath = @"C:\Windows";
                //ユーザーが新しいフォルダを作成できるようにする
                //デフォルトでTrue
                fbd.ShowNewFolderButton = true;

                //ダイアログを表示する
                if (fbd.ShowDialog(this) == DialogResult.OK)
                    return fbd.SelectedPath;

                return "";
            }
            catch (Exception ex)
            {
                lbLog.Text += "\r\n" + ex.Message;
                return "";
            }
        }

        //入力切替
        private void rdoFile_CheckedChanged(object sender, EventArgs e)
        {
            ModeChange(true);
        }
        private void rdoFolder_CheckedChanged(object sender, EventArgs e)
        {
            ModeChange(false);
        }

        private void ModeChange(bool b)
        {
            txtLoadTargetFile.Enabled = b;
            btnLoadTargetFile.Enabled = b;
            txtLoadTargetFolder.Enabled = !b;
            btnLoadTargetFolder.Enabled = !b;
        }
    }
}
