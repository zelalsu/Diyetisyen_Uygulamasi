
namespace DiyetisyenUygulamasi.Forms
{
    partial class HastalarFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastalarFrm));
            this.txtBoxTcAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rchTxtBoxDiyetAciklamasi = new System.Windows.Forms.RichTextBox();
            this.lblHastalikAdi = new System.Windows.Forms.Label();
            this.txtBoxHastalikAdi = new System.Windows.Forms.TextBox();
            this.lblDiyetAciklamasi = new System.Windows.Forms.Label();
            this.lblDiyetAdi = new System.Windows.Forms.Label();
            this.txtBoxDiyetAdi = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnRaporCikar = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtGrdViewHastalar = new System.Windows.Forms.DataGridView();
            this.clmnHastaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHastalıkAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDiyetAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDiyetAciklamasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDiyetisyenAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBoxDiyetYontemi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBoxHastalik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxHastaMail = new System.Windows.Forms.TextBox();
            this.txtBxHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtBxHastaAd = new System.Windows.Forms.TextBox();
            this.txtBxHastaTel = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTcAra
            // 
            this.txtBoxTcAra.Location = new System.Drawing.Point(145, 174);
            this.txtBoxTcAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTcAra.Name = "txtBoxTcAra";
            this.txtBoxTcAra.Size = new System.Drawing.Size(116, 25);
            this.txtBoxTcAra.TabIndex = 14;
            this.txtBoxTcAra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxKeyPress);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.Location = new System.Drawing.Point(266, 174);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(43, 26);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 14);
            this.label7.TabIndex = 80;
            this.label7.Text = "Hasta Tc No Ara:";
            // 
            // rchTxtBoxDiyetAciklamasi
            // 
            this.rchTxtBoxDiyetAciklamasi.Location = new System.Drawing.Point(713, 58);
            this.rchTxtBoxDiyetAciklamasi.Margin = new System.Windows.Forms.Padding(2);
            this.rchTxtBoxDiyetAciklamasi.Name = "rchTxtBoxDiyetAciklamasi";
            this.rchTxtBoxDiyetAciklamasi.Size = new System.Drawing.Size(182, 112);
            this.rchTxtBoxDiyetAciklamasi.TabIndex = 9;
            this.rchTxtBoxDiyetAciklamasi.Text = "";
            // 
            // lblHastalikAdi
            // 
            this.lblHastalikAdi.AutoSize = true;
            this.lblHastalikAdi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblHastalikAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHastalikAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHastalikAdi.ForeColor = System.Drawing.Color.White;
            this.lblHastalikAdi.Location = new System.Drawing.Point(261, 127);
            this.lblHastalikAdi.Name = "lblHastalikAdi";
            this.lblHastalikAdi.Size = new System.Drawing.Size(67, 30);
            this.lblHastalikAdi.TabIndex = 77;
            this.lblHastalikAdi.Text = "HASTALIK\r\n ADI:";
            this.lblHastalikAdi.Visible = false;
            // 
            // txtBoxHastalikAdi
            // 
            this.txtBoxHastalikAdi.Location = new System.Drawing.Point(334, 129);
            this.txtBoxHastalikAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxHastalikAdi.Name = "txtBoxHastalikAdi";
            this.txtBoxHastalikAdi.Size = new System.Drawing.Size(116, 25);
            this.txtBoxHastalikAdi.TabIndex = 7;
            this.txtBoxHastalikAdi.Visible = false;
            // 
            // lblDiyetAciklamasi
            // 
            this.lblDiyetAciklamasi.AutoSize = true;
            this.lblDiyetAciklamasi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDiyetAciklamasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiyetAciklamasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiyetAciklamasi.ForeColor = System.Drawing.Color.White;
            this.lblDiyetAciklamasi.Location = new System.Drawing.Point(627, 68);
            this.lblDiyetAciklamasi.Name = "lblDiyetAciklamasi";
            this.lblDiyetAciklamasi.Size = new System.Drawing.Size(84, 30);
            this.lblDiyetAciklamasi.TabIndex = 75;
            this.lblDiyetAciklamasi.Text = "DİYET \r\nAÇIKLAMASI:";
            // 
            // lblDiyetAdi
            // 
            this.lblDiyetAdi.AutoSize = true;
            this.lblDiyetAdi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblDiyetAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiyetAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDiyetAdi.ForeColor = System.Drawing.Color.White;
            this.lblDiyetAdi.Location = new System.Drawing.Point(639, 29);
            this.lblDiyetAdi.Name = "lblDiyetAdi";
            this.lblDiyetAdi.Size = new System.Drawing.Size(69, 16);
            this.lblDiyetAdi.TabIndex = 74;
            this.lblDiyetAdi.Text = "DİYET ADI:";
            // 
            // txtBoxDiyetAdi
            // 
            this.txtBoxDiyetAdi.Location = new System.Drawing.Point(713, 26);
            this.txtBoxDiyetAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxDiyetAdi.Name = "txtBoxDiyetAdi";
            this.txtBoxDiyetAdi.Size = new System.Drawing.Size(182, 25);
            this.txtBoxDiyetAdi.TabIndex = 8;
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnYenile.Location = new System.Drawing.Point(456, 148);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(166, 28);
            this.btnYenile.TabIndex = 13;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnRaporCikar
            // 
            this.btnRaporCikar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRaporCikar.Location = new System.Drawing.Point(456, 106);
            this.btnRaporCikar.Name = "btnRaporCikar";
            this.btnRaporCikar.Size = new System.Drawing.Size(166, 28);
            this.btnRaporCikar.TabIndex = 12;
            this.btnRaporCikar.Text = "Rapor Çıkar";
            this.btnRaporCikar.UseVisualStyleBackColor = false;
            this.btnRaporCikar.Click += new System.EventHandler(this.btnRaporCikar_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(456, 64);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(166, 28);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dtGrdViewHastalar
            // 
            this.dtGrdViewHastalar.AllowUserToAddRows = false;
            this.dtGrdViewHastalar.AllowUserToDeleteRows = false;
            this.dtGrdViewHastalar.AllowUserToResizeRows = false;
            this.dtGrdViewHastalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGrdViewHastalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdViewHastalar.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dtGrdViewHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdViewHastalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnHastaId,
            this.clmnAd,
            this.clmnSoyad,
            this.clmnTc,
            this.clmnTelefon,
            this.clmnEmail,
            this.clmnHastalıkAdi,
            this.clmnDiyetAdi,
            this.clmnDiyetAciklamasi,
            this.clmnDiyetisyenAdSoyad});
            this.dtGrdViewHastalar.Location = new System.Drawing.Point(12, 206);
            this.dtGrdViewHastalar.MultiSelect = false;
            this.dtGrdViewHastalar.Name = "dtGrdViewHastalar";
            this.dtGrdViewHastalar.ReadOnly = true;
            this.dtGrdViewHastalar.RowHeadersVisible = false;
            this.dtGrdViewHastalar.RowHeadersWidth = 51;
            this.dtGrdViewHastalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrdViewHastalar.Size = new System.Drawing.Size(883, 231);
            this.dtGrdViewHastalar.TabIndex = 68;
//            this.dtGrdViewHastalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrdViewHastalar_CellContentClick);
            this.dtGrdViewHastalar.DoubleClick += new System.EventHandler(this.dtGrdViewHastalar_DoubleClick);
            // 
            // clmnHastaId
            // 
            this.clmnHastaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmnHastaId.HeaderText = "Hasta ID";
            this.clmnHastaId.MinimumWidth = 6;
            this.clmnHastaId.Name = "clmnHastaId";
            this.clmnHastaId.ReadOnly = true;
            this.clmnHastaId.Width = 72;
            // 
            // clmnAd
            // 
            this.clmnAd.FillWeight = 52.33956F;
            this.clmnAd.HeaderText = "Ad";
            this.clmnAd.MinimumWidth = 6;
            this.clmnAd.Name = "clmnAd";
            this.clmnAd.ReadOnly = true;
            // 
            // clmnSoyad
            // 
            this.clmnSoyad.FillWeight = 52.33956F;
            this.clmnSoyad.HeaderText = "Soyad";
            this.clmnSoyad.MinimumWidth = 6;
            this.clmnSoyad.Name = "clmnSoyad";
            this.clmnSoyad.ReadOnly = true;
            // 
            // clmnTc
            // 
            this.clmnTc.FillWeight = 52.33956F;
            this.clmnTc.HeaderText = "TC";
            this.clmnTc.MinimumWidth = 6;
            this.clmnTc.Name = "clmnTc";
            this.clmnTc.ReadOnly = true;
            // 
            // clmnTelefon
            // 
            this.clmnTelefon.FillWeight = 52.33956F;
            this.clmnTelefon.HeaderText = "Telefon";
            this.clmnTelefon.MinimumWidth = 6;
            this.clmnTelefon.Name = "clmnTelefon";
            this.clmnTelefon.ReadOnly = true;
            // 
            // clmnEmail
            // 
            this.clmnEmail.FillWeight = 52.33956F;
            this.clmnEmail.HeaderText = "E-Mail";
            this.clmnEmail.MinimumWidth = 6;
            this.clmnEmail.Name = "clmnEmail";
            this.clmnEmail.ReadOnly = true;
            // 
            // clmnHastalıkAdi
            // 
            this.clmnHastalıkAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnHastalıkAdi.FillWeight = 52.33956F;
            this.clmnHastalıkAdi.HeaderText = "Hastalık Adı";
            this.clmnHastalıkAdi.MinimumWidth = 6;
            this.clmnHastalıkAdi.Name = "clmnHastalıkAdi";
            this.clmnHastalıkAdi.ReadOnly = true;
            // 
            // clmnDiyetAdi
            // 
            this.clmnDiyetAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDiyetAdi.FillWeight = 52.33956F;
            this.clmnDiyetAdi.HeaderText = "Diyet Adı";
            this.clmnDiyetAdi.MinimumWidth = 6;
            this.clmnDiyetAdi.Name = "clmnDiyetAdi";
            this.clmnDiyetAdi.ReadOnly = true;
            // 
            // clmnDiyetAciklamasi
            // 
            this.clmnDiyetAciklamasi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnDiyetAciklamasi.FillWeight = 52.33956F;
            this.clmnDiyetAciklamasi.HeaderText = "Diyet Açıklaması";
            this.clmnDiyetAciklamasi.MinimumWidth = 6;
            this.clmnDiyetAciklamasi.Name = "clmnDiyetAciklamasi";
            this.clmnDiyetAciklamasi.ReadOnly = true;
            // 
            // clmnDiyetisyenAdSoyad
            // 
            this.clmnDiyetisyenAdSoyad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmnDiyetisyenAdSoyad.HeaderText = "Diyetisyen Adı Soyadı";
            this.clmnDiyetisyenAdSoyad.MinimumWidth = 6;
            this.clmnDiyetisyenAdSoyad.Name = "clmnDiyetisyenAdSoyad";
            this.clmnDiyetisyenAdSoyad.ReadOnly = true;
            this.clmnDiyetisyenAdSoyad.Width = 102;
            // 
            // cmbBoxDiyetYontemi
            // 
            this.cmbBoxDiyetYontemi.FormattingEnabled = true;
            this.cmbBoxDiyetYontemi.Items.AddRange(new object[] {
            "Akdeniz",
            "Gluten Free",
            "Deniz Ürünleri",
            "Yeşillikler Dünyası",
            "Diğer"});
            this.cmbBoxDiyetYontemi.Location = new System.Drawing.Point(114, 129);
            this.cmbBoxDiyetYontemi.Name = "cmbBoxDiyetYontemi";
            this.cmbBoxDiyetYontemi.Size = new System.Drawing.Size(116, 22);
            this.cmbBoxDiyetYontemi.TabIndex = 3;
            this.cmbBoxDiyetYontemi.SelectedIndexChanged += new System.EventHandler(this.txtBxHastaDiyetYntm_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 66;
            this.label5.Text = "DİYET \r\nYÖNTEMİ:";
            // 
            // cmbBoxHastalik
            // 
            this.cmbBoxHastalik.FormattingEnabled = true;
            this.cmbBoxHastalik.Items.AddRange(new object[] {
            "Obez",
            "Çölyak",
            "Şeker",
            "Diğer"});
            this.cmbBoxHastalik.Location = new System.Drawing.Point(334, 95);
            this.cmbBoxHastalik.Name = "cmbBoxHastalik";
            this.cmbBoxHastalik.Size = new System.Drawing.Size(116, 22);
            this.cmbBoxHastalik.TabIndex = 6;
            this.cmbBoxHastalik.SelectedIndexChanged += new System.EventHandler(this.txtBxHastaHastalik_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "HASTALIĞI:";
//            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHastaEkle.Location = new System.Drawing.Point(456, 22);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(166, 28);
            this.btnHastaEkle.TabIndex = 10;
            this.btnHastaEkle.Text = "Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "AD:";
            // 
            // txtBxHastaMail
            // 
            this.txtBxHastaMail.Location = new System.Drawing.Point(334, 56);
            this.txtBxHastaMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxHastaMail.Name = "txtBxHastaMail";
            this.txtBxHastaMail.Size = new System.Drawing.Size(116, 25);
            this.txtBxHastaMail.TabIndex = 5;
            // 
            // txtBxHastaSoyad
            // 
            this.txtBxHastaSoyad.Location = new System.Drawing.Point(114, 53);
            this.txtBxHastaSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxHastaSoyad.Name = "txtBxHastaSoyad";
            this.txtBxHastaSoyad.Size = new System.Drawing.Size(116, 25);
            this.txtBxHastaSoyad.TabIndex = 1;
            // 
            // txtBxHastaAd
            // 
            this.txtBxHastaAd.Location = new System.Drawing.Point(114, 22);
            this.txtBxHastaAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxHastaAd.Name = "txtBxHastaAd";
            this.txtBxHastaAd.Size = new System.Drawing.Size(116, 25);
            this.txtBxHastaAd.TabIndex = 0;
            // 
            // txtBxHastaTel
            // 
            this.txtBxHastaTel.Location = new System.Drawing.Point(334, 22);
            this.txtBxHastaTel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxHastaTel.Mask = "(999) 000-0000";
            this.txtBxHastaTel.Name = "txtBxHastaTel";
            this.txtBxHastaTel.Size = new System.Drawing.Size(116, 25);
            this.txtBxHastaTel.TabIndex = 4;
            this.txtBxHastaTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(264, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "TELEFON:";
            // 
            // txtBxHastaTc
            // 
            this.txtBxHastaTc.Location = new System.Drawing.Point(114, 86);
            this.txtBxHastaTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBxHastaTc.Mask = "00000000000";
            this.txtBxHastaTc.Name = "txtBxHastaTc";
            this.txtBxHastaTc.Size = new System.Drawing.Size(116, 25);
            this.txtBxHastaTc.TabIndex = 2;
            this.txtBxHastaTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "TC KİMLİK:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(40, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "SOYAD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(275, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "E-MAİL:";
            // 
            // HastalarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 449);
            this.Controls.Add(this.txtBoxTcAra);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rchTxtBoxDiyetAciklamasi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHastalikAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxHastalikAdi);
            this.Controls.Add(this.txtBxHastaTc);
            this.Controls.Add(this.lblDiyetAciklamasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDiyetAdi);
            this.Controls.Add(this.txtBxHastaTel);
            this.Controls.Add(this.txtBoxDiyetAdi);
            this.Controls.Add(this.txtBxHastaAd);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.txtBxHastaSoyad);
            this.Controls.Add(this.btnRaporCikar);
            this.Controls.Add(this.txtBxHastaMail);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnHastaEkle);
            this.Controls.Add(this.dtGrdViewHastalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBoxDiyetYontemi);
            this.Controls.Add(this.cmbBoxHastalik);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.Name = "HastalarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hastalar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HastalarFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdViewHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrdViewHastalar;
        private System.Windows.Forms.ComboBox cmbBoxDiyetYontemi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBoxHastalik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxHastaMail;
        private System.Windows.Forms.TextBox txtBxHastaSoyad;
        private System.Windows.Forms.TextBox txtBxHastaAd;
        private System.Windows.Forms.MaskedTextBox txtBxHastaTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtBxHastaTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnRaporCikar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtBoxDiyetAdi;
        private System.Windows.Forms.Label lblDiyetAciklamasi;
        private System.Windows.Forms.Label lblDiyetAdi;
        private System.Windows.Forms.Label lblHastalikAdi;
        private System.Windows.Forms.TextBox txtBoxHastalikAdi;
        private System.Windows.Forms.RichTextBox rchTxtBoxDiyetAciklamasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtBoxTcAra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHastaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHastalıkAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDiyetAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDiyetAciklamasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDiyetisyenAdSoyad;
    }
}