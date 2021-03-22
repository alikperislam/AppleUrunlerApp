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
    public partial class frmgecis : Form
    {
        public frmgecis()
        {
            InitializeComponent();
        }

        private void frmgecis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSepetim sepet = new frmSepetim();
            sepet.labelilçe.Text = label1.Text;
            sepet.labelil.Text = label2.Text;
            sepet.labelisim.Text = label3.Text;
            sepet.labeltelefon.Text = label4.Text;
            sepet.labelfiyat.Text = label5.Text;
            sepet.labelmodel.Text = label6.Text;
            sepet.labelemail.Text = label7.Text;
            sepet.labeladres.Text = label8.Text;

        }
    }
}
