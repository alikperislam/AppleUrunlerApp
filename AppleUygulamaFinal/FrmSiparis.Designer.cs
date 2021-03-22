namespace AppleUygulamaFinal
{
    partial class FrmSiparis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparis));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboUrun = new System.Windows.Forms.ComboBox();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.comboRenk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureUrun = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnUrunGetir = new System.Windows.Forms.Button();
            this.txtİlçe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboİl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ürün :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(90, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Renk :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(79, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Model :";
            // 
            // comboUrun
            // 
            this.comboUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.comboUrun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboUrun.ForeColor = System.Drawing.Color.White;
            this.comboUrun.FormattingEnabled = true;
            this.comboUrun.Items.AddRange(new object[] {
            "Macbook",
            "Iphone",
            "Ipad",
            "Apple Watch"});
            this.comboUrun.Location = new System.Drawing.Point(178, 36);
            this.comboUrun.Name = "comboUrun";
            this.comboUrun.Size = new System.Drawing.Size(195, 31);
            this.comboUrun.TabIndex = 45;
            this.comboUrun.SelectedIndexChanged += new System.EventHandler(this.comboUrun_SelectedIndexChanged);
            // 
            // comboModel
            // 
            this.comboModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.comboModel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboModel.ForeColor = System.Drawing.Color.White;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(178, 89);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(195, 31);
            this.comboModel.TabIndex = 46;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // comboRenk
            // 
            this.comboRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.comboRenk.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboRenk.ForeColor = System.Drawing.Color.White;
            this.comboRenk.FormattingEnabled = true;
            this.comboRenk.Location = new System.Drawing.Point(178, 143);
            this.comboRenk.Name = "comboRenk";
            this.comboRenk.Size = new System.Drawing.Size(195, 31);
            this.comboRenk.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(501, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Adres ve Fatura Bilgileri";
            // 
            // pictureUrun
            // 
            this.pictureUrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.pictureUrun.Image = ((System.Drawing.Image)(resources.GetObject("pictureUrun.Image")));
            this.pictureUrun.Location = new System.Drawing.Point(91, 294);
            this.pictureUrun.Name = "pictureUrun";
            this.pictureUrun.Size = new System.Drawing.Size(282, 214);
            this.pictureUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUrun.TabIndex = 52;
            this.pictureUrun.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(93, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "Fiyat : ";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.lblFiyat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.ForeColor = System.Drawing.Color.Purple;
            this.lblFiyat.Location = new System.Drawing.Point(174, 194);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(65, 23);
            this.lblFiyat.TabIndex = 54;
            this.lblFiyat.Text = "0.00 ₺";
            // 
            // btnUrunGetir
            // 
            this.btnUrunGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnUrunGetir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnUrunGetir.FlatAppearance.BorderSize = 2;
            this.btnUrunGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunGetir.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunGetir.ForeColor = System.Drawing.Color.Black;
            this.btnUrunGetir.Location = new System.Drawing.Point(165, 231);
            this.btnUrunGetir.Name = "btnUrunGetir";
            this.btnUrunGetir.Size = new System.Drawing.Size(137, 47);
            this.btnUrunGetir.TabIndex = 55;
            this.btnUrunGetir.Text = "Ürün Getir";
            this.btnUrunGetir.UseVisualStyleBackColor = false;
            this.btnUrunGetir.Click += new System.EventHandler(this.btnUrunGetir_Click);
            // 
            // txtİlçe
            // 
            this.txtİlçe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtİlçe.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİlçe.Location = new System.Drawing.Point(531, 122);
            this.txtİlçe.MaxLength = 18;
            this.txtİlçe.Multiline = true;
            this.txtİlçe.Name = "txtİlçe";
            this.txtİlçe.Size = new System.Drawing.Size(257, 28);
            this.txtİlçe.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(510, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 23);
            this.label5.TabIndex = 57;
            this.label5.Text = "İl :";
            // 
            // comboİl
            // 
            this.comboİl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.comboİl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboİl.ForeColor = System.Drawing.Color.White;
            this.comboİl.FormattingEnabled = true;
            this.comboİl.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "K.maraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.comboİl.Location = new System.Drawing.Point(587, 53);
            this.comboİl.Name = "comboİl";
            this.comboİl.Size = new System.Drawing.Size(198, 27);
            this.comboİl.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(517, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 59;
            this.label7.Text = "İlçe :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(498, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Adres :";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtAdres.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(531, 184);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(254, 77);
            this.txtAdres.TabIndex = 62;
            this.txtAdres.Text = "";
            // 
            // txtİsim
            // 
            this.txtİsim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtİsim.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtİsim.Location = new System.Drawing.Point(531, 299);
            this.txtİsim.MaxLength = 18;
            this.txtİsim.Multiline = true;
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(257, 28);
            this.txtİsim.TabIndex = 63;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(531, 362);
            this.txtMail.Mask = "AAAAAAAAAAAAAAAAAAAA@AAAAAAA";
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(257, 28);
            this.txtMail.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(450, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 23);
            this.label9.TabIndex = 66;
            this.label9.Text = "İsim Soyisim :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(493, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 67;
            this.label10.Text = "e - mail :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(498, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 23);
            this.label11.TabIndex = 68;
            this.label11.Text = "Telefon :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKaydet.FlatAppearance.BorderSize = 2;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(585, 471);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(137, 42);
            this.btnKaydet.TabIndex = 69;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtTelefon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefon.Location = new System.Drawing.Point(531, 428);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(257, 28);
            this.txtTelefon.TabIndex = 65;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 574);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboİl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtİlçe);
            this.Controls.Add(this.btnUrunGetir);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureUrun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRenk);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.comboUrun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboUrun;
        private System.Windows.Forms.ComboBox comboRenk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUrunGetir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.MaskedTextBox txtTelefon;
        public System.Windows.Forms.ComboBox comboModel;
        public System.Windows.Forms.Label lblFiyat;
        public System.Windows.Forms.TextBox txtİlçe;
        public System.Windows.Forms.ComboBox comboİl;
        public System.Windows.Forms.RichTextBox txtAdres;
        public System.Windows.Forms.TextBox txtİsim;
        public System.Windows.Forms.MaskedTextBox txtMail;
    }
}