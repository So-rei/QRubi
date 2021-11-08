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
        }

        /// <summary>
        /// メイン処理開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {




            //作業中ダイアログ
            var cfrm = new frmDialog();
            cfrm.Show();
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
