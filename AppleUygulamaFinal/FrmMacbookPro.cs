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
    public partial class FrmMacbookPro : Form
    {
        public FrmMacbookPro()
        {
            InitializeComponent();
        }
        private int tık = 0;
        private void btnIphone_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources.üst;
                


            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources.ön;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             tık++;
            if (tık % 2 == 1)
            {
                pictureBoxmacpro.Image = Properties.Resources.üst;
                


            }
            else
            {
                pictureBoxmacpro.Image = Properties.Resources.ön;
                
            }
        }

        private void FrmMacbookPro_Load(object sender, EventArgs e)
        {

        }
    }
}
