
namespace DiyetisyenUygulamasi.Forms
{
    partial class AdminFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFrm));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGrdViewDiyetisyenler = new System.Windows.Forms.DataGridView();
            this.clmnDiyetisyenId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnKullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxDiyetisyenSoyadi = new System.Windows.Forms.TextBox();
            this.txtBoxDiyetisyenAdi = new System.Windows.Forms.TextBox();
            this.btnDiyetisyenEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxTelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewDiyetisyenler)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtGrdViewDiyetisyenler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Diyetisyenler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtGrdViewDiyetisyenler
            // 
            this.dtGrdViewDiyetisyenler.AllowUserToAddRows = false;
            this.dtGrdViewDiyetisyenler.AllowUserToDeleteRows = false;
            this.dtGrdViewDiyetisyenler.AllowUserToResizeRows = false;
            this.dtGrdViewDiyetisyenler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewDiyetisyenler.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dtGrdViewDiyetisyenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewDiyetisyenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnDiyetisyenId,
            this.clmnAd,
            this.clmnSoyad,
            this.clmnKullaniciAdi,
            this.clmnSifre,
            this.clmnTc,
            this.clmnTelefon,
            this.clmnEmail});
            this.dtGrdViewDiyetisyenler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdViewDiyetisyenler.Location = new System.Drawing.Point(3, 3);
            this.dtGrdViewDiyetisyenler.MultiSelect = false;
            this.dtGrdViewDiyetisyenler.Name = "dtGrdViewDiyetisyenler";
            this.dtGrdViewDiyetisyenler.ReadOnly = true;
            this.dtGrdViewDiyetisyenler.RowHeadersVisible = false;
            this.dtGrdViewDiyetisyenler.RowHeadersWidth = 51;
            this.dtGrdViewDiyetisyenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewDiyetisyenler.Size = new System.Drawing.Size(535, 397);
            this.dtGrdViewDiyetisyenler.TabIndex = 0;
            // 
            // clmnDiyetisyenId
            // 
            this.clmnDiyetisyenId.HeaderText = "Diyetisyen ID";
            this.clmnDiyetisyenId.MinimumWidth = 6;
            this.clmnDiyetisyenId.Name = "clmnDiyetisyenId";
            this.clmnDiyetisyenId.ReadOnly = true;
            // 
            // clmnAd
            // 
            this.clmnAd.HeaderText = "Ad";
            this.clmnAd.MinimumWidth = 6;
            this.clmnAd.Name = "clmnAd";
            this.clmnAd.ReadOnly = true;
            // 
            // clmnSoyad
            // 
            this.clmnSoyad.HeaderText = "Soyad";
            this.clmnSoyad.MinimumWidth = 6;
            this.clmnSoyad.Name = "clmnSoyad";
            this.clmnSoyad.ReadOnly = true;
            // 
            // clmnKullaniciAdi
            // 
            this.clmnKullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.clmnKullaniciAdi.MinimumWidth = 6;
            this.clmnKullaniciAdi.Name = "clmnKullaniciAdi";
            this.clmnKullaniciAdi.ReadOnly = true;
            // 
            // clmnSifre
            // 
            this.clmnSifre.HeaderText = "Şifre";
            this.clmnSifre.MinimumWidth = 6;
            this.clmnSifre.Name = "clmnSifre";
            this.clmnSifre.ReadOnly = true;
            // 
            // clmnTc
            // 
            this.clmnTc.HeaderText = "TC";
            this.clmnTc.MinimumWidth = 6;
            this.clmnTc.Name = "clmnTc";
            this.clmnTc.ReadOnly = true;
            // 
            // clmnTelefon
            // 
            this.clmnTelefon.HeaderText = "Telefon No";
            this.clmnTelefon.MinimumWidth = 6;
            this.clmnTelefon.Name = "clmnTelefon";
            this.clmnTelefon.ReadOnly = true;
            // 
            // clmnEmail
            // 
            this.clmnEmail.HeaderText = "E-Mail";
            this.clmnEmail.MinimumWidth = 6;
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblSifre);
            this.tabPage1.Controls.Add(this.txtBoxSifre);
            this.tabPage1.Controls.Add(this.txtBoxKullaniciAdi);
            this.tabPage1.Controls.Add(this.txtBoxEmail);
            this.tabPage1.Controls.Add(this.txtBoxDiyetisyenSoyadi);
            this.tabPage1.Controls.Add(this.txtBoxDiyetisyenAdi);
            this.tabPage1.Controls.Add(this.btnDiyetisyenEkle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtBoxTelefonNo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBoxTcNo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Diyetisyen Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(143, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(121, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 94;
            this.label2.Text = "KULLANICI ADI:\r\n";
            // 
            // lblSifre
            // 
            this.lblSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.MistyRose;
            this.lblSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSifre.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSifre.Location = new System.Drawing.Point(175, 292);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(45, 16);
            this.lblSifre.TabIndex = 95;
            this.lblSifre.Text = "ŞİFRE:";
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxSifre.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxSifre.Location = new System.Drawing.Point(233, 289);
            this.txtBoxSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(100, 25);
            this.txtBoxSifre.TabIndex = 6;
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxKullaniciAdi.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(233, 253);
            this.txtBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(100, 25);
            this.txtBoxKullaniciAdi.TabIndex = 5;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxEmail.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxEmail.Location = new System.Drawing.Point(235, 214);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(100, 25);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // txtBoxDiyetisyenSoyadi
            // 
            this.txtBoxDiyetisyenSoyadi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDiyetisyenSoyadi.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDiyetisyenSoyadi.Location = new System.Drawing.Point(235, 112);
            this.txtBoxDiyetisyenSoyadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxDiyetisyenSoyadi.Name = "txtBoxDiyetisyenSoyadi";
            this.txtBoxDiyetisyenSoyadi.Size = new System.Drawing.Size(100, 25);
            this.txtBoxDiyetisyenSoyadi.TabIndex = 1;
            // 
            // txtBoxDiyetisyenAdi
            // 
            this.txtBoxDiyetisyenAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDiyetisyenAdi.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxDiyetisyenAdi.Location = new System.Drawing.Point(235, 79);
            this.txtBoxDiyetisyenAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxDiyetisyenAdi.Name = "txtBoxDiyetisyenAdi";
            this.txtBoxDiyetisyenAdi.Size = new System.Drawing.Size(100, 25);
            this.txtBoxDiyetisyenAdi.TabIndex = 0;
            // 
            // btnDiyetisyenEkle
            // 
            this.btnDiyetisyenEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiyetisyenEkle.BackColor = System.Drawing.Color.Thistle;
            this.btnDiyetisyenEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiyetisyenEkle.Location = new System.Drawing.Point(168, 321);
            this.btnDiyetisyenEkle.Name = "btnDiyetisyenEkle";
            this.btnDiyetisyenEkle.Size = new System.Drawing.Size(207, 29);
            this.btnDiyetisyenEkle.TabIndex = 7;
            this.btnDiyetisyenEkle.Text = "Diyetisyen Ekle";
            this.btnDiyetisyenEkle.UseVisualStyleBackColor = false;
            this.btnDiyetisyenEkle.Click += new System.EventHandler(this.btnDiyetisyenEkle_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(194, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "AD:";
            // 
            // txtBoxTelefonNo
            // 
            this.txtBoxTelefonNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxTelefonNo.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTelefonNo.Location = new System.Drawing.Point(235, 179);
            this.txtBoxTelefonNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTelefonNo.Mask = "(999) 000-0000";
            this.txtBoxTelefonNo.Name = "txtBoxTelefonNo";
            this.txtBoxTelefonNo.Size = new System.Drawing.Size(100, 25);
            this.txtBoxTelefonNo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MistyRose;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(154, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "TELEFON:";
            // 
            // txtBoxTcNo
            // 
            this.txtBoxTcNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxTcNo.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxTcNo.Location = new System.Drawing.Point(235, 145);
            this.txtBoxTcNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTcNo.Mask = "00000000000";
            this.txtBoxTcNo.Name = "txtBoxTcNo";
            this.txtBoxTcNo.Size = new System.Drawing.Size(100, 25);
            this.txtBoxTcNo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MistyRose;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(147, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 85;
            this.label4.Text = "TC KİMLİK:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MistyRose;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(170, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 86;
            this.label6.Text = "SOYAD:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.MistyRose;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(168, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 87;
            this.label9.Text = "E-MAİL:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 432);
            this.tabControl1.TabIndex = 83;
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(549, 432);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AdminFrm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewDiyetisyenler)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGrdViewDiyetisyenler;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxDiyetisyenSoyadi;
        private System.Windows.Forms.TextBox txtBoxDiyetisyenAdi;
        private System.Windows.Forms.Button btnDiyetisyenEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefonNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtBoxTcNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDiyetisyenId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnKullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}