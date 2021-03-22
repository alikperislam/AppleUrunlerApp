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
    public partial class FrmIphone12Mini : Form
    {
        public FrmIphone12Mini()
        {
            InitializeComponent();
        }
        private int tık = 0;
        private void btnIphone_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources._12_mini_koyu_mavi;
                labelyazı.Text = "Iphone 12 Mini Koyu Mavi";
                labelyazı.ForeColor = Color.FromArgb(3,51,86);
                label2.ForeColor = Color.FromArgb(3, 51, 86);



            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources._12_mini_siyah;
                labelyazı.Text = "Iphone 12 Mini Siyah";
                labelyazı.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources._12_mini_koyu_mavi;
                labelyazı.Text = "Iphone 12 Mini Koyu Mavi";
                labelyazı.ForeColor = Color.FromArgb(3, 51, 86);
                label2.ForeColor = Color.FromArgb(3, 51, 86);




            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources._12_mini_siyah;
                labelyazı.Text = "Iphone 12 Mini Siyah";
                labelyazı.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;

            }
        }

        private void FrmIphone12Mini_Load(object sender, EventArgs e)
        {

        }
    }
}
