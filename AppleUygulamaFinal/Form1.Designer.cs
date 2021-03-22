namespace AppleUygulamaFinal
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtregisterparola2 = new System.Windows.Forms.TextBox();
            this.txtregisterparola = new System.Windows.Forms.TextBox();
            this.txtregisterkullanıcı = new System.Windows.Forms.TextBox();
            this.txtloginkullanıcı = new System.Windows.Forms.TextBox();
            this.txtloginparola = new System.Windows.Forms.TextBox();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.btngiris = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.MaskedTextBox();
            this.labelsifre = new System.Windows.Forms.Label();
            this.btnsifregonder = new System.Windows.Forms.Button();
            this.labelgmail = new System.Windows.Forms.Label();
            this.labelwhatsapp = new System.Windows.Forms.Label();
            this.labelinsta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtregisterparola2
            // 
            this.txtregisterparola2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtregisterparola2.Location = new System.Drawing.Point(344, 367);
            this.txtregisterparola2.MaxLength = 18;
            this.txtregisterparola2.Multiline = true;
            this.txtregisterparola2.Name = "txtregisterparola2";
            this.txtregisterparola2.PasswordChar = '*';
            this.txtregisterparola2.Size = new System.Drawing.Size(195, 30);
            this.txtregisterparola2.TabIndex = 15;
            // 
            // txtregisterparola
            // 
            this.txtregisterparola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtregisterparola.Location = new System.Drawing.Point(344, 296);
            this.txtregisterparola.MaxLength = 18;
            this.txtregisterparola.Multiline = true;
            this.txtregisterparola.Name = "txtregisterparola";
            this.txtregisterparola.PasswordChar = '*';
            this.txtregisterparola.Size = new System.Drawing.Size(195, 30);
            this.txtregisterparola.TabIndex = 14;
            // 
            // txtregisterkullanıcı
            // 
            this.txtregisterkullanıcı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtregisterkullanıcı.Location = new System.Drawing.Point(344, 160);
            this.txtregisterkullanıcı.MaxLength = 18;
            this.txtregisterkullanıcı.Multiline = true;
            this.txtregisterkullanıcı.Name = "txtregisterkullanıcı";
            this.txtregisterkullanıcı.Size = new System.Drawing.Size(195, 30);
            this.txtregisterkullanıcı.TabIndex = 12;
            // 
            // txtloginkullanıcı
            // 
            this.txtloginkullanıcı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtloginkullanıcı.Location = new System.Drawing.Point(28, 160);
            this.txtloginkullanıcı.MaxLength = 18;
            this.txtloginkullanıcı.Multiline = true;
            this.txtloginkullanıcı.Name = "txtloginkullanıcı";
            this.txtloginkullanıcı.Size = new System.Drawing.Size(195, 30);
            this.txtloginkullanıcı.TabIndex = 11;
            // 
            // txtloginparola
            // 
            this.txtloginparola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtloginparola.Location = new System.Drawing.Point(28, 225);
            this.txtloginparola.MaxLength = 18;
            this.txtloginparola.Multiline = true;
            this.txtloginparola.Name = "txtloginparola";
            this.txtloginparola.PasswordChar = '*';
            this.txtloginparola.Size = new System.Drawing.Size(195, 30);
            this.txtloginparola.TabIndex = 10;
            // 
            // btnkayıt
            // 
            this.btnkayıt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnkayıt.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnkayıt.FlatAppearance.BorderSize = 2;
            this.btnkayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayıt.ForeColor = System.Drawing.Color.White;
            this.btnkayıt.Location = new System.Drawing.Point(390, 406);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(114, 38);
            this.btnkayıt.TabIndex = 9;
            this.btnkayıt.Text = "KAYIT";
            this.btnkayıt.UseVisualStyleBackColor = false;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click);
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btngiris.Enabled = false;
            this.btngiris.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btngiris.FlatAppearance.BorderSize = 2;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiris.ForeColor = System.Drawing.Color.White;
            this.btngiris.Location = new System.Drawing.Point(74, 307);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(114, 38);
            this.btngiris.TabIndex = 8;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(84, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(167, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(125, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 25);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.MouseLeave += new System.EventHandler(this.button5_MouseLeave);
            this.button5.MouseHover += new System.EventHandler(this.button5_MouseHover);
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.txtemail.Location = new System.Drawing.Point(344, 225);
            this.txtemail.Mask = "AAAAAAAAAAAAAAAAAAAA@AAAAAAA";
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(195, 32);
            this.txtemail.TabIndex = 19;
            // 
            // labelsifre
            // 
            this.labelsifre.AutoSize = true;
            this.labelsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelsifre.ForeColor = System.Drawing.Color.White;
            this.labelsifre.Location = new System.Drawing.Point(3, 267);
            this.labelsifre.Name = "labelsifre";
            this.labelsifre.Size = new System.Drawing.Size(189, 23);
            this.labelsifre.TabIndex = 20;
            this.labelsifre.Text = "Şifreni mi unuttun ?";
            this.labelsifre.Visible = false;
            // 
            // btnsifregonder
            // 
            this.btnsifregonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.btnsifregonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsifregonder.BackgroundImage")));
            this.btnsifregonder.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnsifregonder.FlatAppearance.BorderSize = 0;
            this.btnsifregonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsifregonder.ForeColor = System.Drawing.Color.White;
            this.btnsifregonder.Location = new System.Drawing.Point(184, 257);
            this.btnsifregonder.Name = "btnsifregonder";
            this.btnsifregonder.Size = new System.Drawing.Size(43, 38);
            this.btnsifregonder.TabIndex = 21;
            this.btnsifregonder.UseVisualStyleBackColor = false;
            this.btnsifregonder.Visible = false;
            this.btnsifregonder.Click += new System.EventHandler(this.button6_Click);
            // 
            // labelgmail
            // 
            this.labelgmail.AutoSize = true;
            this.labelgmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelgmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelgmail.Location = new System.Drawing.Point(48, 424);
            this.labelgmail.Name = "labelgmail";
            this.labelgmail.Size = new System.Drawing.Size(236, 23);
            this.labelgmail.TabIndex = 22;
            this.labelgmail.Text = "alikperrrr16@gmail.com";
            this.labelgmail.Visible = false;
            // 
            // labelwhatsapp
            // 
            this.labelwhatsapp.AutoSize = true;
            this.labelwhatsapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelwhatsapp.ForeColor = System.Drawing.Color.Green;
            this.labelwhatsapp.Location = new System.Drawing.Point(65, 424);
            this.labelwhatsapp.Name = "labelwhatsapp";
            this.labelwhatsapp.Size = new System.Drawing.Size(175, 23);
            this.labelwhatsapp.TabIndex = 23;
            this.labelwhatsapp.Text = "+90(xxx) xxx xx xx";
            this.labelwhatsapp.Visible = false;
            // 
            // labelinsta
            // 
            this.labelinsta.AutoSize = true;
            this.labelinsta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelinsta.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelinsta.Location = new System.Drawing.Point(87, 424);
            this.labelinsta.Name = "labelinsta";
            this.labelinsta.Size = new System.Drawing.Size(133, 23);
            this.labelinsta.TabIndex = 24;
            this.labelinsta.Text = "/alikperislam";
            this.labelinsta.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(576, 456);
            this.Controls.Add(this.labelinsta);
            this.Controls.Add(this.labelwhatsapp);
            this.Controls.Add(this.labelgmail);
            this.Controls.Add(this.btnsifregonder);
            this.Controls.Add(this.labelsifre);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtregisterparola2);
            this.Controls.Add(this.txtregisterparola);
            this.Controls.Add(this.txtregisterkullanıcı);
            this.Controls.Add(this.txtloginkullanıcı);
            this.Controls.Add(this.txtloginparola);
            this.Controls.Add(this.btnkayıt);
            this.Controls.Add(this.btngiris);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtregisterparola2;
        private System.Windows.Forms.TextBox txtregisterparola;
        private System.Windows.Forms.TextBox txtregisterkullanıcı;
        private System.Windows.Forms.TextBox txtloginkullanıcı;
        private System.Windows.Forms.TextBox txtloginparola;
        private System.Windows.Forms.Button btnkayıt;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox txtemail;
        private System.Windows.Forms.Label labelsifre;
        private System.Windows.Forms.Button btnsifregonder;
        private System.Windows.Forms.Label labelgmail;
        private System.Windows.Forms.Label labelwhatsapp;
        private System.Windows.Forms.Label labelinsta;
    }
}

