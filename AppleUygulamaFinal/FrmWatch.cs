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
    public partial class FrmWatch : Form
    {
        public FrmWatch()
        {
            InitializeComponent();
        }
        private int tık = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnIphone_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık%2==1)
            {
                pictureBoxWatch.Image = Properties.Resources.beyaz;
                labelyazı.Text = "Apple Watch White";
                labelyazı.ForeColor = Color.White;

            }
            else
            {
                pictureBoxWatch.Image = Properties.Resources.siyah;
                labelyazı.Text = "Apple Watch Black";
                labelyazı.ForeColor = Color.Black;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxWatch.Image = Properties.Resources.beyaz;
                labelyazı.Text = "Apple Watch White";
                labelyazı.ForeColor = Color.White;
            }
            else
            {
                pictureBoxWatch.Image = Properties.Resources.siyah;
                labelyazı.Text = "Apple Watch Black";
                labelyazı.ForeColor = Color.Black;
            }
        }

        private void FrmWatch_Load(object sender, EventArgs e)
        {

        }
    }
}
