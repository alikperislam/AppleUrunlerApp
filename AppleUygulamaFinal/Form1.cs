using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; // mail gönderebilmemiz için .net.mail kütüphanesini import etmemiz gerek. sunucu tarafını kontrol edebilmemiz için.


namespace AppleUygulamaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private string gonderen;
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mail adresinize random bir şifre gönderildi lütfen o şifre ile giriş yapınız.");
            MailMessage mesaj = new MailMessage(); // göndereceğimiz mesaj için bir nesne ürettik.
                                                   //smtp : mail göndermek için kullanılan sunucu ile iletişime geçen bir protokoldur.
            SmtpClient istemci = new SmtpClient(); // istemci nesnesi ürettik.
                                                   // istemci üzerinde kullanıcı mail adresi ve şifremi girmem için networkcredential sınıfı için mail adresimi ve parolamı yazıyorum.
            istemci.Credentials = new System.Net.NetworkCredential(txtemail.Text+".com", "ornekhesap1234");
            istemci.Port = 587; // türkiyede port numarası genellikle 587 olarak kullanılır.
            istemci.Host = "smtp.live.com"; //outlook'un sunucu adresi.
            istemci.EnableSsl = true; // mail doğru adrese ulaşana kadar şifreleme yapması için yani websitelerdeki https işlevi görüyor.
                                      // göndereceğimiz mesaj ile ilgili içerikleri artık ekleyebiliriz.
            mesaj.To.Add(txtemail.Text+".com"); //mesajın hangi mail adresine gönderileceğini belirtiyoruz.
            mesaj.From = new MailAddress(txtemail.Text+".com"); // hangi mail adresinden yani kimden gönderileceği ile ilgili.
            mesaj.Subject = "random şifre ile ilgili"; // konu ile ilgili bilgi girilecek.
                                                       //random şifre işlemini yaptıracağız :
            Random rastgele = new Random();
            int pr = rastgele.Next(1000000, 9999999);
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            string uret = "";
            for (int i = 0; i < 5; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }

            string gonder = pr.ToString() + uret;

            

            mesaj.Body = gonder; // gönderilecek mesaj içeiriği burda.
            istemci.Send(mesaj); // istemci verileri mesaj sınıfından alacak ve outlook'a gönderecek.
            gonderen = gonder;// parola artık mail adresimize gönderilen parolaya eşit olacak.
            
        }
        private int tıklanmasayısı=0;
        public string mailim;
        private string kullanıcı, parola;
        private void btnkayıt_Click(object sender, EventArgs e)
        {
            // kayıt butonuna tıklanmadan giriş butonu aktif olmasın diye böyle bir blok oluşturdum.
            int tıklanma = 1;
            tıklanmasayısı = tıklanma;
            if (tıklanmasayısı == 1)
            {
                btngiris.Enabled = true;
            }

            if (txtregisterparola.Text==txtregisterparola2.Text)
            {
                mailim = txtemail.Text + ".com";
                kullanıcı = txtregisterkullanıcı.Text;
                parola = txtregisterparola.Text;
           
            }
            else
            {
                MessageBox.Show("Parolalarınız aynı değil lüfen tekrar deneyiniz.");
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            labelgmail.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            labelgmail.Visible = false;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            labelinsta.Visible = true;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            labelinsta.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            labelwhatsapp.Visible = true;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            labelwhatsapp.Visible = false;
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            
            
            
            if (txtloginparola.Text==parola && txtregisterkullanıcı.Text==kullanıcı)
            {
                // direkt olarak anasayfaya yönlendiredceğiz.
                anaform a = new anaform(); 
                a.Show();//anaform getirilecek.
                this.Hide();
            }
            if (kullanıcı == txtloginkullanıcı.Text && gonderen == txtloginparola.Text)
            {
                // direkt olarak anasayfaya yönlendiredceğiz.
                anaform ab = new anaform();
                ab.Show();//anaform getirilecek.
                this.Hide();

            }
            else
            {
                labelsifre.Visible = true;
                btnsifregonder.Visible = true;
                // mail adresine random şifre gönderilecek.

            }
        }
    }
}
