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
    public partial class FrmMacbookAir : Form
    {
        public FrmMacbookAir()
        {
            InitializeComponent();
        }
        private int tık = 0;
        private void btnIphone_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacair.Image = Properties.Resources.arka;



            }
            else
            {
                pictureBoxmacair.Image = Properties.Resources.diger;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacair.Image = Properties.Resources.arka;

            }
            else
            {
                pictureBoxmacair.Image = Properties.Resources.diger;

            }
        }

        private void pictureBoxmacair_Click(object sender, EventArgs e)
        {

        }

        private void FrmMacbookAir_Load(object sender, EventArgs e)
        {

        }
    }
}
