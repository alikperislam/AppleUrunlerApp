using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleUygulamaFinal
{
    public partial class FrmIphoneXs : Form
    {
        public FrmIphoneXs()
        {
            InitializeComponent();
        }

        private void FrmIphoneXs_Load(object sender, EventArgs e)
        {

        }
        private int tık = 0;

        private void btnIphone_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources.altın_sarısı;
                labelyazı.Text = "Iphone Xs Altın Sarısı";
                labelyazı.ForeColor = Color.FromArgb(255, 229, 232);
                labelfiyat.ForeColor = Color.FromArgb(255, 229, 232);



            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources.uzay_grisi;
                labelyazı.Text = "Iphone Xs Uzay Grisi";
                labelyazı.ForeColor = Color.FromArgb(66, 66, 57);
                labelfiyat.ForeColor = Color.FromArgb(66, 66, 57);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources.altın_sarısı;
                labelyazı.Text = "Iphone Xs Altın Sarısı";
                labelyazı.ForeColor = Color.FromArgb(255, 229, 232);
                labelfiyat.ForeColor = Color.FromArgb(255, 229, 232);



            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources.uzay_grisi;
                labelyazı.Text = "Iphone Xs Uzay Grisi";
                labelyazı.ForeColor = Color.FromArgb(66, 66, 57);
                labelfiyat.ForeColor = Color.FromArgb(66, 66, 57);

            }
        }
    }
}
