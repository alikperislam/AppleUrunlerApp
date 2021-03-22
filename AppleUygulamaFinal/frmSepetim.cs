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
    
    public partial class frmSepetim : Form
    {
        public frmSepetim()
        {
            InitializeComponent();
        }


        
        

        public  string gelenİl, gelenİlçe, gelenAdres, gelenİsim, gelenEmail, gelenTelefon, gelenFiyat, gelenModel;

        private void txtKartNumara_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void comboKartAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAy.Text = comboKartAy.Text;
        }

        private void comboKartYıl_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblYil.Text = comboKartYıl.Text;
        }

        private void txtKartNumara_MouseLeave(object sender, EventArgs e)
        {
            lblNumara.Text = txtKartNumara.Text;
        }

        private void txtKartCvc_MouseClick(object sender, MouseEventArgs e)
        {
            lblCvc.Text = txtKartCvc.Text;
        }

        private void txtKartCvc_MouseLeave(object sender, EventArgs e)
        {
            lblCvc.Text = txtKartCvc.Text;
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int ındırım(int say)
            {
                int ındır = (say * 10) / 100;
                int sonfiyat = say - ındır;
                int adet = 0;
                adet += Convert.ToInt32(numericadet.Value);

                return sonfiyat * adet;
            }
            if (radioButton1.Checked)
            {
                if (Properties.Settings.Default.Ayar6 == "1.799,00 ₺")
                {
                    int sayı1 = 1799;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;


                }

                else if (Properties.Settings.Default.Ayar6 == "16.699,00 ₺")
                {
                    int sayı1 = 16699;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }

                else if (Properties.Settings.Default.Ayar6 == "24.999,00 ₺")
                {
                    int sayı1 = 24999;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }

                else if (Properties.Settings.Default.Ayar6 == "14.249,00 ₺")
                {
                    int sayı1 = 14249;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }

                else if (Properties.Settings.Default.Ayar6 == "3.799,00 ₺")
                {
                    int sayı1 = 3799;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;

                }

                else if (Properties.Settings.Default.Ayar6 == "2.299,00 ₺")
                {
                    int sayı1 = 2299;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }

                else if (Properties.Settings.Default.Ayar6 == "9.999,00 ₺")
                {
                    int sayı1 = 9999;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }

                else if (Properties.Settings.Default.Ayar6 == "16.999,00 ₺")
                {
                    int sayı1 = 16999;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }

                else if (Properties.Settings.Default.Ayar6 == "7.510,00 ₺")
                {
                    int sayı1 = 7510;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }

                else if (Properties.Settings.Default.Ayar6 == "7.493,00 ₺")
                {
                    int sayı1 = 7493;
                    labelodemefiyat.Text = ındırım(sayı1).ToString();
                    label6.Text = "İndirimli :";
                    labelodemefiyat.Text += ",00 ₺";
                    labelfiyat.Text = labelodemefiyat.Text;
                    Properties.Settings.Default.Ayar6 = labelodemefiyat.Text;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMail m = new frmMail();
            m.Show();
        }

        private void numericadet_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtKartNumara_MouseClick(object sender, MouseEventArgs e)
        {
            lblNumara.Text = txtKartNumara.Text;
        }

        private void txtKartİsim_TextChanged(object sender, EventArgs e)
        {
            txtKartİsim.Text.ToUpper();
        }

        private void txtKartİsim_MouseLeave(object sender, EventArgs e)
        {
            
            lblİsim.Text = txtKartİsim.Text;
            
        }

        private void txtKartİsim_MouseClick(object sender, MouseEventArgs e)
        {
            
            lblİsim.Text = txtKartİsim.Text;
            
        }

        private void txtregisterparola2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void frmSepetim_Load(object sender, EventArgs e)
        {
            lblİsim.Text.ToUpper();

            labelisim.Text = Properties.Settings.Default.Ayar;
            labelil.Text = Properties.Settings.Default.Ayar1;
            labelilçe.Text = Properties.Settings.Default.Ayar2;
            labeladres.Text = Properties.Settings.Default.Ayar3;
            labeltelefon.Text = Properties.Settings.Default.Ayar4;
            labelemail.Text = Properties.Settings.Default.Ayar5;
            labelfiyat.Text = Properties.Settings.Default.Ayar6;
            labelmodel.Text = Properties.Settings.Default.Ayar7;

            labelodemefiyat.Text = Properties.Settings.Default.Ayar6;
            
        }
    }
}
