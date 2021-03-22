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
    public partial class Frm12ProMax : Form
    {
        public Frm12ProMax()
        {
            InitializeComponent();
        }
        private int tık = 0;
        private void btnIphone_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources._12_pro_max_gold;
                labelyazı.Text = "Iphone 12 Pro Max Gold";
                labelyazı.ForeColor = Color.FromArgb(255, 229, 232);
                labelfiyat.ForeColor = Color.FromArgb(255, 229, 232);



            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources._12_pro_max_gümüş;
                labelyazı.Text = "Iphone 12 Pro Max Gümüş";
                labelyazı.ForeColor = Color.FromArgb(66, 66, 57);
                labelfiyat.ForeColor = Color.FromArgb(66, 66, 57);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources._12_pro_max_gold;
                labelyazı.Text = "Iphone 12 Pro Max Gold";
                labelyazı.ForeColor = Color.FromArgb(255,229,232);
                labelfiyat.ForeColor = Color.FromArgb(255, 229, 232);



            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources._12_pro_max_gümüş;
                labelyazı.Text = "Iphone 12 Pro Max Gümüş";
                labelyazı.ForeColor = Color.FromArgb(66,66,57);
                labelfiyat.ForeColor = Color.FromArgb(66, 66, 57);

            }
        }

        private void Frm12ProMax_Load(object sender, EventArgs e)
        {

        }
    }
}
