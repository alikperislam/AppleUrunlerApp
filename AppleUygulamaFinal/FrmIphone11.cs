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
    public partial class FrmIphone11 : Form
    {
        public FrmIphone11()
        {
            InitializeComponent();
        }
        private int tık = 0;

        private void btnIphone_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources._11_siyah;
                labelyazı.Text = "Iphone 11 Siyah";
                labelyazı.ForeColor = Color.Black;
                labelfiyat.ForeColor = Color.Black;



            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources.iphone_11_sarı;
                labelyazı.Text = "Iphone 11 Sarı";
                labelyazı.ForeColor = Color.Yellow;
                labelfiyat.ForeColor = Color.Yellow;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources._11_siyah;
                labelyazı.Text = "Iphone 11 Siyah";
                labelyazı.ForeColor = Color.Black;
                labelfiyat.ForeColor = Color.Black;



            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources.iphone_11_sarı;
                labelyazı.Text = "Iphone 11 Sarı";
                labelyazı.ForeColor = Color.Yellow;
                labelfiyat.ForeColor = Color.Yellow;

            }
        }

        private void FrmIphone11_Load(object sender, EventArgs e)
        {

        }
    }
}
