
namespace QRubi
{
    partial class _MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkChange1 = new System.Windows.Forms.CheckBox();
            this.chkChange2 = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSaveTargetFolder = new System.Windows.Forms.TextBox();
            this.btnSaveTargetFolder = new System.Windows.Forms.Button();
            this.btnLoadTargetFile = new System.Windows.Forms.Button();
            this.txtLoadTargetFile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoFile = new System.Windows.Forms.RadioButton();
            this.rdoFolder = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLoadTargetFolder = new System.Windows.Forms.TextBox();
            this.btnLoadTargetFolder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbDic = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemDic = new System.Windows.Forms.Button();
            this.btnAddDic = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStart.Location = new System.Drawing.Point(299, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 43);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "変換開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbLog
            // 
            this.lbLog.Enabled = false;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 12;
            this.lbLog.Location = new System.Drawing.Point(695, 385);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(20, 16);
            this.lbLog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(611, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "処理ログ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkChange1
            // 
            this.chkChange1.AutoSize = true;
            this.chkChange1.Enabled = false;
            this.chkChange1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkChange1.Location = new System.Drawing.Point(26, 21);
            this.chkChange1.Name = "chkChange1";
            this.chkChange1.Size = new System.Drawing.Size(72, 20);
            this.chkChange1.TabIndex = 3;
            this.chkChange1.Text = "カクヨム";
            this.chkChange1.UseVisualStyleBackColor = true;
            this.chkChange1.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // chkChange2
            // 
            this.chkChange2.AutoSize = true;
            this.chkChange2.Checked = true;
            this.chkChange2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChange2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkChange2.Location = new System.Drawing.Point(120, 21);
            this.chkChange2.Name = "chkChange2";
            this.chkChange2.Size = new System.Drawing.Size(124, 20);
            this.chkChange2.TabIndex = 4;
            this.chkChange2.Text = "小説家になろう";
            this.chkChange2.UseVisualStyleBackColor = true;
            this.chkChange2.CheckedChanged += new System.EventHandler(this.chkOption_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkChange1);
            this.groupBox1.Controls.Add(this.chkChange2);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(428, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 51);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "変換オプション";
            // 
            // txtSaveTargetFolder
            // 
            this.txtSaveTargetFolder.Location = new System.Drawing.Point(16, 39);
            this.txtSaveTargetFolder.Name = "txtSaveTargetFolder";
            this.txtSaveTargetFolder.Size = new System.Drawing.Size(255, 22);
            this.txtSaveTargetFolder.TabIndex = 9;
            // 
            // btnSaveTargetFolder
            // 
            this.btnSaveTargetFolder.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSaveTargetFolder.Location = new System.Drawing.Point(277, 38);
            this.btnSaveTargetFolder.Name = "btnSaveTargetFolder";
            this.btnSaveTargetFolder.Size = new System.Drawing.Size(25, 26);
            this.btnSaveTargetFolder.TabIndex = 10;
            this.btnSaveTargetFolder.Text = "...";
            this.btnSaveTargetFolder.UseVisualStyleBackColor = true;
            this.btnSaveTargetFolder.Click += new System.EventHandler(this.btnSaveTargetFolder_Click);
            // 
            // btnLoadTargetFile
            // 
            this.btnLoadTargetFile.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadTargetFile.Location = new System.Drawing.Point(287, 50);
            this.btnLoadTargetFile.Name = "btnLoadTargetFile";
            this.btnLoadTargetFile.Size = new System.Drawing.Size(25, 26);
            this.btnLoadTargetFile.TabIndex = 12;
            this.btnLoadTargetFile.Text = "...";
            this.btnLoadTargetFile.UseVisualStyleBackColor = true;
            this.btnLoadTargetFile.Click += new System.EventHandler(this.btnLoadTargetFile_Click);
            // 
            // txtLoadTargetFile
            // 
            this.txtLoadTargetFile.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtLoadTargetFile.Location = new System.Drawing.Point(26, 53);
            this.txtLoadTargetFile.Name = "txtLoadTargetFile";
            this.txtLoadTargetFile.Size = new System.Drawing.Size(255, 20);
            this.txtLoadTargetFile.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox2.Location = new System.Drawing.Point(428, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 77);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "その他オプション";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(357, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "→";
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Checked = true;
            this.rdoFile.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoFile.Location = new System.Drawing.Point(8, 27);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(98, 17);
            this.rdoFile.TabIndex = 16;
            this.rdoFile.TabStop = true;
            this.rdoFile.Text = "ファイルを変換";
            this.rdoFile.UseVisualStyleBackColor = true;
            this.rdoFile.CheckedChanged += new System.EventHandler(this.rdoFile_CheckedChanged);
            // 
            // rdoFolder
            // 
            this.rdoFolder.AutoSize = true;
            this.rdoFolder.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoFolder.Location = new System.Drawing.Point(8, 89);
            this.rdoFolder.Name = "rdoFolder";
            this.rdoFolder.Size = new System.Drawing.Size(125, 17);
            this.rdoFolder.TabIndex = 17;
            this.rdoFolder.Text = "フォルダ全体を変換";
            this.rdoFolder.UseVisualStyleBackColor = true;
            this.rdoFolder.CheckedChanged += new System.EventHandler(this.rdoFolder_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLoadTargetFolder);
            this.groupBox3.Controls.Add(this.btnLoadTargetFolder);
            this.groupBox3.Controls.Add(this.rdoFolder);
            this.groupBox3.Controls.Add(this.rdoFile);
            this.groupBox3.Controls.Add(this.txtLoadTargetFile);
            this.groupBox3.Controls.Add(this.btnLoadTargetFile);
            this.groupBox3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox3.Location = new System.Drawing.Point(12, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 148);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "変換前ファイル";
            // 
            // txtLoadTargetFolder
            // 
            this.txtLoadTargetFolder.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtLoadTargetFolder.Location = new System.Drawing.Point(26, 111);
            this.txtLoadTargetFolder.Name = "txtLoadTargetFolder";
            this.txtLoadTargetFolder.Size = new System.Drawing.Size(255, 20);
            this.txtLoadTargetFolder.TabIndex = 18;
            // 
            // btnLoadTargetFolder
            // 
            this.btnLoadTargetFolder.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoadTargetFolder.Location = new System.Drawing.Point(287, 108);
            this.btnLoadTargetFolder.Name = "btnLoadTargetFolder";
            this.btnLoadTargetFolder.Size = new System.Drawing.Size(25, 26);
            this.btnLoadTargetFolder.TabIndex = 19;
            this.btnLoadTargetFolder.Text = "...";
            this.btnLoadTargetFolder.UseVisualStyleBackColor = true;
            this.btnLoadTargetFolder.Click += new System.EventHandler(this.btnLoadTargetFolder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSaveTargetFolder);
            this.groupBox4.Controls.Add(this.btnSaveTargetFolder);
            this.groupBox4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox4.Location = new System.Drawing.Point(418, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 87);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "変換後ファイル　保存先";
            // 
            // lbDic
            // 
            this.lbDic.FormattingEnabled = true;
            this.lbDic.ItemHeight = 15;
            this.lbDic.Location = new System.Drawing.Point(14, 30);
            this.lbDic.Name = "lbDic";
            this.lbDic.Size = new System.Drawing.Size(378, 79);
            this.lbDic.TabIndex = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRemDic);
            this.groupBox5.Controls.Add(this.lbDic);
            this.groupBox5.Controls.Add(this.btnAddDic);
            this.groupBox5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox5.Location = new System.Drawing.Point(12, 172);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 147);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "使用中の変換辞書";
            // 
            // btnRemDic
            // 
            this.btnRemDic.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRemDic.Location = new System.Drawing.Point(71, 115);
            this.btnRemDic.Name = "btnRemDic";
            this.btnRemDic.Size = new System.Drawing.Size(51, 26);
            this.btnRemDic.TabIndex = 11;
            this.btnRemDic.Text = "削除";
            this.btnRemDic.UseVisualStyleBackColor = true;
            this.btnRemDic.Click += new System.EventHandler(this.btnRemDic_Click);
            // 
            // btnAddDic
            // 
            this.btnAddDic.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAddDic.Location = new System.Drawing.Point(14, 115);
            this.btnAddDic.Name = "btnAddDic";
            this.btnAddDic.Size = new System.Drawing.Size(51, 26);
            this.btnAddDic.TabIndex = 10;
            this.btnAddDic.Text = "追加";
            this.btnAddDic.UseVisualStyleBackColor = true;
            this.btnAddDic.Click += new System.EventHandler(this.btnAddDic_Click);
            // 
            // _MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 411);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnStart);
            this.Name = "_MainForm";
            this.Text = "自動ルビ振り Ver0.1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkChange1;
        private System.Windows.Forms.CheckBox chkChange2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSaveTargetFolder;
        private System.Windows.Forms.Button btnSaveTargetFolder;
        private System.Windows.Forms.Button btnLoadTargetFile;
        private System.Windows.Forms.TextBox txtLoadTargetFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoFile;
        private System.Windows.Forms.RadioButton rdoFolder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLoadTargetFolder;
        private System.Windows.Forms.Button btnLoadTargetFolder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbDic;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRemDic;
        private System.Windows.Forms.Button btnAddDic;
    }
}

