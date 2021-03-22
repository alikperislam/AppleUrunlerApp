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
    public partial class FrmIpadcs : Form
    {
        public FrmIpadcs()
        {
            InitializeComponent();
        }

        private void FrmIpadcs_Load(object sender, EventArgs e)
        {

        }

        
        private void urunfonksiyon()
        {
            ArrayList urunler = new ArrayList();
            urunler.Add(1);
            urunler.Add(2);
            urunler.Add(3);
        }
        
        private int deger = 0;
        private void btnIphone_Click(object sender, EventArgs e)
        {
            
            if (deger == 0)
            {

                pictureBoxIpadmini.Image = Properties.Resources.ipad_mini_select_cell;
                labelyazı.Text = "Ipad Mini Select Cell";
                pictureBoxIpadmini.Height = 350;
                pictureBoxIpadmini.Width = 290;
                labelbilgi.Text = "Ekran Boyutu: 7.9 İnç\n" +
                    "Bellek(RAM): 3 GB.\n" +
                    "Dahili Depolama: 64 GB.\n" +
                    "Hafıza Kartı Desteği: Var\n" +
                    "İşletim Sistemi Versiyonu: iOS 12.\n" +
                    "Arka Kamera Çözünürlüğü: 8.0 MP.\n";
                string s = "3.799,00 ₺";
                labelfiyat.Text = s;


                if (deger==0)
                {
                    deger = 3;
                }
            }

            else if (deger == 1)
            {

                pictureBoxIpadmini.Image = Properties.Resources.ipad7;
                labelyazı.Text = "Ipad 7 Series";
                pictureBoxIpadmini.Height = 350;
                pictureBoxIpadmini.Width = 290;
                labelbilgi.Text = "EKRAN TEKNOLOJİSİ IPS 10.2 inç\n" +
                    "LED arkadan aydınlatmalı Multi-Touch.\n" +
                    "İnç başına 264 piksel (ppi)\n" +
                    "yoğunlukta 2160 x 1620 çözünürlük.\n" +
                    "İŞLEMCİ 64 bit mimariye sahip\n" +
                    "A10 Fusion çip.\n" +
                    "RAM. 3 GB RAM.\n" +
                    "KAMERA. 8 megapiksel arka kamera.\n" +
                    "483 Gram ağırlık.\n";
                string ss = "2.299,00 ₺";
                labelfiyat.Text = ss;


            }

            else if (deger == 2)
            {

                pictureBoxIpadmini.Image = Properties.Resources.ipad_pro12;
                labelyazı.Text = "Ipad 12 Pro";
                pictureBoxIpadmini.Height = 293;
                pictureBoxIpadmini.Width = 266;
                labelbilgi.Text = "Ekran Boyutu: 12.9 İnç \n" +
                    "Bellek (RAM): 6 GB. \n" +
                    "Dahili Depolama: 128 GB. \n" +
                    "İşletim Sistemi Versiyonu: iPadOS 14. \n" +
                    "Arka Kamera Çözünürlüğü: 12.0 MP. \n";
                    
                string xx = "14.249,00 ₺";
                labelfiyat.Text = xx;



            }
            deger--;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (deger == 0)
            {

                pictureBoxIpadmini.Image = Properties.Resources.ipad_mini_select_cell;
                labelyazı.Text = "Ipad Mini Select Cell";
                pictureBoxIpadmini.Height = 350;
                pictureBoxIpadmini.Width = 290;
                labelbilgi.Text = "Ekran Boyutu: 7.9 İnç\n" +
                    "Bellek(RAM): 3 GB.\n" +
                    "Dahili Depolama: 64 GB.\n" +
                    "Hafıza Kartı Desteği: Var\n" +
                    "İşletim Sistemi Versiyonu: iOS 12.\n" +
                    "Arka Kamera Çözünürlüğü: 8.0 MP.\n";
                string s = "3.799,00 ₺";
                labelfiyat.Text = s;


            }

            else if (deger == 1)
            {

                pictureBoxIpadmini.Image = Properties.Resources.ipad7;
                labelyazı.Text = "Ipad 7 Series";
                pictureBoxIpadmini.Height = 350;
                pictureBoxIpadmini.Width = 290;
                labelbilgi.Text = "EKRAN TEKNOLOJİSİ IPS 10.2 inç\n" +
                    "LED arkadan aydınlatmalı Multi-Touch.\n" +
                    "İnç başına 264 piksel (ppi)\n" +
                    "yoğunlukta 2160 x 1620 çözünürlük.\n" +
                    "İŞLEMCİ 64 bit mimariye sahip\n" +
                    "A10 Fusion çip.\n" +
                    "RAM. 3 GB RAM.\n" +
                    "KAMERA. 8 megapiksel arka kamera.\n" +
                    "483 Gram ağırlık.\n";
                string ss = "2.299,00 ₺";
                labelfiyat.Text =ss;


            }

            else if (deger == 2)
            {

                pictureBoxIpadmini.Image = Properties.Resources.ipad_pro12;
                labelyazı.Text = "Ipad 12 Pro";
                pictureBoxIpadmini.Height = 293;
                pictureBoxIpadmini.Width = 266;
                labelbilgi.Text = "Ekran Boyutu: 12.9 İnç \n" +
                    "Bellek (RAM): 6 GB. \n" +
                    "Dahili Depolama: 128 GB. \n" +
                    "İşletim Sistemi Versiyonu: iPadOS 14. \n" +
                    "Arka Kamera Çözünürlüğü: 12.0 MP. \n";

                string xx = "14.249,00 ₺";
                labelfiyat.Text = xx;



                if (deger == 2)
                {
                    deger = -1;
                }
            }
            deger++;
        }
    }
}
