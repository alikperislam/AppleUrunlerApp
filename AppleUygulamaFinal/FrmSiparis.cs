using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AppleUygulamaFinal
{
    

    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }

        
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunGetir_Click(object sender, EventArgs e)
        {
            if (comboModel.Text=="Iphone 12 Mini" && comboRenk.Text=="Siyah")
            {
                
                pictureUrun.Image = Properties.Resources._12_mini_siyah;
                lblFiyat.Text = "9.999,00 ₺";
            }
            else if (comboModel.Text == "Iphone 12 Mini" && comboRenk.Text == "Koyu Mavi")
            {
                pictureUrun.Image = Properties.Resources._12_mini_koyu_mavi;
                lblFiyat.Text = "9.999,00 ₺";
            }
            else if (comboModel.Text == "Iphone 12 Pro Max" && comboRenk.Text == "Gümüş")
            {
                pictureUrun.Image = Properties.Resources._12_pro_max_gümüş;
                lblFiyat.Text = "16.999,00 ₺";
            }
            else if (comboModel.Text == "Iphone 12 Pro Max" && comboRenk.Text == "Gold")
            {
                pictureUrun.Image = Properties.Resources._12_pro_max_gold;
                lblFiyat.Text = "16.999,00 ₺";
            }
            else if (comboModel.Text == "Iphone Xs" && comboRenk.Text == "Uzay Grisi")
            {
                pictureUrun.Image = Properties.Resources.uzay_grisi;
                lblFiyat.Text = "7.510,00 ₺";
            }
            else if (comboModel.Text == "Iphone Xs" && comboRenk.Text == "Altın Sarısı")
            {
                pictureUrun.Image = Properties.Resources.altın_sarısı;
                lblFiyat.Text = "7.510,00 ₺";
            }
            else if (comboModel.Text == "Iphone 11" && comboRenk.Text == "Sarı")
            {
                pictureUrun.Image = Properties.Resources.iphone_11_sarı;
                lblFiyat.Text = "7.493,00 ₺";
            }
            else if (comboModel.Text == "Iphone 11" && comboRenk.Text == "Siyah")
            {
                pictureUrun.Image = Properties.Resources._11_siyah;
                lblFiyat.Text = "7.493,00 ₺";
            }
            else if (comboModel.Text == "Macbook Pro Mree2tu" && comboRenk.Text == "Gümüş")
            {
               pictureUrun.Image = Properties.Resources.ön;
                lblFiyat.Text = "24.999,00 ₺";
            }
            else if (comboModel.Text == "Macbook Air Mree2tu/a" && comboRenk.Text == "Gümüş")
            {
                pictureUrun.Image = Properties.Resources.diger;
                lblFiyat.Text = "16.999,00 ₺";
            }
            else if (comboModel.Text == "Apple Watch 3 Series" && comboRenk.Text == "Siyah")
            {
                pictureUrun.Image = Properties.Resources.siyah;
                lblFiyat.Text = "1.799,00 ₺";
            }
            else if (comboModel.Text == "Apple Watch 3 Series" && comboRenk.Text == "Beyaz")
            {
                pictureUrun.Image = Properties.Resources.beyaz;
                lblFiyat.Text = "1.799,00 ₺";
            }

            else if (comboModel.Text == "Ipad 7 Series" && comboRenk.Text == "Gümüş")
            {
                pictureUrun.Image = Properties.Resources.ipad7;
                lblFiyat.Text = "2.299,00 ₺";
            }
            else if (comboModel.Text == "Ipad 12 Pro" && comboRenk.Text == "Gümüş")
            {
                pictureUrun.Image = Properties.Resources.ipad_pro12;
                lblFiyat.Text = "14.249,00 ₺";
            }
            else if (comboModel.Text == "Ipad Mini Select Cell" && comboRenk.Text == "Gümüş")
            {
                pictureUrun.Image = Properties.Resources.ipad_mini_select_cell;
                lblFiyat.Text = "3.799,00 ₺";
            }

        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboModel.Text== "Macbook Pro Mree2tu")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Gümüş");
            }

            else if (comboModel.Text == "Macbook Air Mree2tu/a")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Gümüş");
            }

            else if (comboModel.Text == "Iphone 11")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Sarı");
                comboRenk.Items.Add("Siyah");
            }

            else if (comboModel.Text == "Iphone 12 Pro Max")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Gümüş");
                comboRenk.Items.Add("Gold");
            }

            else if (comboModel.Text == "Iphone 12 Mini")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Siyah");
                comboRenk.Items.Add("Koyu Mavi");
            }

            else if (comboModel.Text == "Iphone Xs")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Uzay Grisi");
                comboRenk.Items.Add("Altın Sarısı");
            }

            else if (comboModel.Text == "Apple Watch 3 Series")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Siyah");
                comboRenk.Items.Add("Beyaz");
            }

            else if (comboModel.Text == "Ipad 12 Pro")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Gümüş");
            }

            else if (comboModel.Text == "Ipad Mini Select Cell")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Gümüş");

            }

            else if (comboModel.Text == "Ipad 7 Series")
            {
                comboRenk.Items.Clear();
                comboRenk.Items.Add("Gümüş");
            }
        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            
        }

        private void comboUrun_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboUrun.Text == "Macbook")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Macbook Pro Mree2tu");
                comboModel.Items.Add("Macbook Air Mree2tu/a");

            }
            else if (comboUrun.Text == "Iphone")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Iphone 11");
                comboModel.Items.Add("Iphone 12 Pro Max");
                comboModel.Items.Add("Iphone 12 Mini");
                comboModel.Items.Add("Iphone Xs");

            }
            else if (comboUrun.Text == "Apple Watch")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Apple Watch 3 Series");

            }
            else if (comboUrun.Text == "Ipad")
            {
                comboModel.Items.Clear();
                comboModel.Items.Add("Ipad 12 Pro");
                comboModel.Items.Add("Ipad Mini Select Cell");
                comboModel.Items.Add("Ipad 7 Series");

            }
        }
        public string gg;
        private void btnKaydet_Click(object sender, EventArgs e)
        {



            Properties.Settings.Default.Ayar = txtİsim.Text;
            Properties.Settings.Default.Ayar1= comboİl.Text;
            Properties.Settings.Default.Ayar2 = txtİlçe.Text;
            Properties.Settings.Default.Ayar3 = txtAdres.Text;
            Properties.Settings.Default.Ayar4 = txtTelefon.Text;
            Properties.Settings.Default.Ayar5 = txtMail.Text;
            Properties.Settings.Default.Ayar6 = lblFiyat.Text;
            Properties.Settings.Default.Ayar7 = comboModel.Text;



        }
    }
}
