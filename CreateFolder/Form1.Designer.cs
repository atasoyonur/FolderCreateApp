namespace CreateFolder
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnFS = new System.Windows.Forms.Button();
            this.btnTFS = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.txtTFS = new System.Windows.Forms.TextBox();
            this.txtFS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderName = new System.Windows.Forms.TextBox();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.FBDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGet = new System.Windows.Forms.Button();
            this.lstClear = new System.Windows.Forms.Button();
            this.lnkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnFS
            // 
            this.btnFS.Location = new System.Drawing.Point(12, 58);
            this.btnFS.Name = "btnFS";
            this.btnFS.Size = new System.Drawing.Size(147, 40);
            this.btnFS.TabIndex = 0;
            this.btnFS.Text = "Klasör Dizin Seçimi";
            this.btnFS.UseVisualStyleBackColor = true;
            this.btnFS.Click += new System.EventHandler(this.btnFS_Click);
            // 
            // btnTFS
            // 
            this.btnTFS.Location = new System.Drawing.Point(12, 104);
            this.btnTFS.Name = "btnTFS";
            this.btnTFS.Size = new System.Drawing.Size(147, 40);
            this.btnTFS.TabIndex = 1;
            this.btnTFS.Text = "Hedeflenen Dizin Seçimi";
            this.btnTFS.UseVisualStyleBackColor = true;
            this.btnTFS.Click += new System.EventHandler(this.btnTFS_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(432, 12);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(268, 459);
            this.lstBox.TabIndex = 10;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // txtTFS
            // 
            this.txtTFS.Location = new System.Drawing.Point(178, 104);
            this.txtTFS.Multiline = true;
            this.txtTFS.Name = "txtTFS";
            this.txtTFS.ReadOnly = true;
            this.txtTFS.Size = new System.Drawing.Size(248, 40);
            this.txtTFS.TabIndex = 2;
            // 
            // txtFS
            // 
            this.txtFS.Location = new System.Drawing.Point(178, 58);
            this.txtFS.Multiline = true;
            this.txtFS.Name = "txtFS";
            this.txtFS.ReadOnly = true;
            this.txtFS.Size = new System.Drawing.Size(248, 40);
            this.txtFS.TabIndex = 2;
            this.txtFS.TextChanged += new System.EventHandler(this.txtFS_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klasör Adı İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seçilen Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Eklenecek Ad:";
            // 
            // selectName
            // 
            this.selectName.Location = new System.Drawing.Point(123, 247);
            this.selectName.Multiline = true;
            this.selectName.Name = "selectName";
            this.selectName.Size = new System.Drawing.Size(222, 56);
            this.selectName.TabIndex = 3;
            this.selectName.TextChanged += new System.EventHandler(this.selectName_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(351, 247);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(351, 280);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(123, 334);
            this.inputName.Multiline = true;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(222, 56);
            this.inputName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Klasör Seçimi ve Otomatik Oluşturma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Oluşturulacak Klasörün Adı:";
            // 
            // folderName
            // 
            this.folderName.Location = new System.Drawing.Point(171, 416);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(248, 20);
            this.folderName.TabIndex = 8;
            this.folderName.TextChanged += new System.EventHandler(this.folderName_TextChanged);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Enabled = false;
            this.btnCreateFolder.Location = new System.Drawing.Point(171, 442);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(248, 34);
            this.btnCreateFolder.TabIndex = 9;
            this.btnCreateFolder.Text = "Klasörleri Oluştur";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnGet
            // 
            this.btnGet.Enabled = false;
            this.btnGet.Location = new System.Drawing.Point(178, 150);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(248, 34);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Klasörleri Adlarını Getir";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lstClear
            // 
            this.lstClear.Location = new System.Drawing.Point(16, 151);
            this.lstClear.Name = "lstClear";
            this.lstClear.Size = new System.Drawing.Size(143, 33);
            this.lstClear.TabIndex = 12;
            this.lstClear.Text = "Listeyi Temizle";
            this.lstClear.UseVisualStyleBackColor = true;
            this.lstClear.Click += new System.EventHandler(this.lstClear_Click);
            // 
            // lnkLabel
            // 
            this.lnkLabel.ActiveLinkColor = System.Drawing.Color.Silver;
            this.lnkLabel.AutoSize = true;
            this.lnkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLabel.LinkColor = System.Drawing.Color.Gray;
            this.lnkLabel.Location = new System.Drawing.Point(9, 466);
            this.lnkLabel.Name = "lnkLabel";
            this.lnkLabel.Size = new System.Drawing.Size(63, 13);
            this.lnkLabel.TabIndex = 13;
            this.lnkLabel.TabStop = true;
            this.lnkLabel.Text = "Version: 0.1";
            this.lnkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lnkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLabel_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 488);
            this.Controls.Add(this.lnkLabel);
            this.Controls.Add(this.lstClear);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.selectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFS);
            this.Controls.Add(this.txtTFS);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnTFS);
            this.Controls.Add(this.btnFS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klasör Adı Klonlama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFS;
        private System.Windows.Forms.Button btnTFS;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.TextBox txtTFS;
        private System.Windows.Forms.TextBox txtFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox selectName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.FolderBrowserDialog FBDialog;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button lstClear;
        private System.Windows.Forms.LinkLabel lnkLabel;
    }
}

