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
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit(); // uygulamayı kapat.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // uygulama ekranını alta al.
        }

        private void button8_Click(object sender, EventArgs e)
        {
            

        }

        void formGetir(Form frm) //isMdi ile diğer formlaro ana panelimizin içerisine çekeceğiz bir fonksiyon ile tanımlayıp hangi butona tıklanırsa o form gelecek.
        {
            panelMain.Controls.Clear(); // panelin içeriğini boş bırakıyoruz önce.
            frm.MdiParent = this; // mdiparentlerini atadık.
            panelMain.Controls.Add(frm); //ana panelimize formu ekledik
            frm.Show(); // formu ana panelde göster.
        }
        private void btnSipariş_Click(object sender, EventArgs e)
        {
            pictureSiparis.BackColor = Color.FromArgb(249,118,176);
            FrmSiparis fr = new FrmSiparis();
            formGetir(fr); // sipariş ekranı gelecek.
        }

        private void btnSepetim_Click(object sender, EventArgs e)
        {
            pictureSepetim.BackColor = Color.FromArgb(172,126,241);
            frmSepetim fr0 = new frmSepetim();
            formGetir(fr0); // sipariş ekranı gelecek.
        }
        private int ıphonetıklanma = 0;
        private void btnIphone_Click(object sender, EventArgs e)
        {
            pictureIphone.BackColor = Color.FromArgb(9,237,237);

            if (ıphonetıklanma==0)
            {
                // ıphone 12 mini formunu getirelim :
                FrmIphone12Mini mini = new FrmIphone12Mini();
                formGetir(mini);
            }

            else if (ıphonetıklanma == 1)
            {
                // ıphone 12 pro max formunu getirelim :
                Frm12ProMax promax = new Frm12ProMax();
                formGetir(promax);

            }

            else if (ıphonetıklanma == 2)
            {
                // ıphone xs formunu getirelim :
                FrmIphoneXs xs0 = new FrmIphoneXs();
                formGetir(xs0);
            }

            else if (ıphonetıklanma == 3)
            {
                // ıphone 11 formunu getirelim :
                FrmIphone11 ıp11 = new FrmIphone11();
                formGetir(ıp11);

                if (ıphonetıklanma == 3)
                {
                    ıphonetıklanma = -1;
                }
            }

            ıphonetıklanma++;
            
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            pictureWatch.BackColor = Color.FromArgb(253,138,114);
            FrmWatch fr1 = new FrmWatch();
            formGetir(fr1); // apple watch ekranı gelecek.
        }
        private int artır = 0;
        private void btnMacbook_Click(object sender, EventArgs e)
        {
            artır++;
            pictureMacbook.BackColor = Color.FromArgb(95,77,221);
            if (artır%2==0)
            {
                FrmMacbookPro macp = new FrmMacbookPro(); // macbook pro formu gelecek.
                formGetir(macp);

            }
            else
            {
                FrmMacbookAir maca = new FrmMacbookAir(); // macbook air formu gelecek.
                formGetir(maca);

            }
        }

        private void btnIpad_Click(object sender, EventArgs e)
        {
            pictureIpad.BackColor = Color.FromArgb(249,88,155);
            FrmIpadcs fr2 = new FrmIpadcs();
            formGetir(fr2); // apple watch ekranı gelecek.
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
