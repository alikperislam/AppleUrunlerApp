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
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMail_Load(object sender, EventArgs e)
        {
            label2.Text = "Tebrikler " + Properties.Settings.Default.Ayar7 + " model ürününüzü başarıyla sipariş ettiniz.\n"+"Faturanızı mail adresinize göndermemizi ister misiniz ?";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string fromİsim, fromİl, fromİlce,fromAdres,fromTelefon,fromMail,fromFiyat,fromModel ;

        private void button2_Click(object sender, EventArgs e)
        {
            fromİsim = Properties.Settings.Default.Ayar;
            fromİl = Properties.Settings.Default.Ayar1;
            fromİlce = Properties.Settings.Default.Ayar2;
            fromAdres = Properties.Settings.Default.Ayar3;
            fromTelefon = Properties.Settings.Default.Ayar4;
            fromMail = Properties.Settings.Default.Ayar5;
            fromFiyat = Properties.Settings.Default.Ayar6;
            fromModel = Properties.Settings.Default.Ayar7;


            // faturayı mail yoluyla gönderim.
           
            MailMessage mesaj = new MailMessage(); // göndereceğimiz mesaj için bir nesne ürettik.
                                                   //smtp : mail göndermek için kullanılan sunucu ile iletişime geçen bir protokoldur.
            SmtpClient istemci = new SmtpClient(); // istemci nesnesi ürettik.
                                                   // istemci üzerinde kullanıcı mail adresi ve şifremi girmem için networkcredential sınıfı için mail adresimi ve parolamı yazıyorum.
            istemci.Credentials = new System.Net.NetworkCredential(fromMail + ".com", "ornekhesap1234");
            istemci.Port = 587; // türkiyede port numarası genellikle 587 olarak kullanılır.
            istemci.Host = "smtp.live.com"; //outlook'un sunucu adresi.
            istemci.EnableSsl = true; // mail doğru adrese ulaşana kadar şifreleme yapması için yani websitelerdeki https işlevi görüyor.
                                      // göndereceğimiz mesaj ile ilgili içerikleri artık ekleyebiliriz.
            mesaj.To.Add(fromMail + ".com"); //mesajın hangi mail adresine gönderileceğini belirtiyoruz.
            mesaj.From = new MailAddress(fromMail + ".com"); // hangi mail adresinden yani kimden gönderileceği ile ilgili.
            mesaj.Subject = "Apple üzerinden Alınan " +fromModel+ " hakkında Faturalandırma Maili"; // konu ile ilgili bilgi girilecek.
                                                       
            

            string gonder = "Sayın,"+fromİsim+"\n" +
                "Mağazamızdan yapmış olduğunuz "+fromModel+" model ürünün fiyatı : "+fromFiyat+"'dir.\n"+
                fromTelefon+" numaralı telefonunuza bilgilendirme mesajı gönderilmiştir.\n"+"Adresiniz "+
                fromİlce+" / "+fromİl+" "+ fromAdres +" olarak görünmekte ve kargonuz 3 gün içerisinde yola çıkacaktır.\n" +
                "iyi günler dileriz.";



            mesaj.Body = gonder; // gönderilecek mesaj içeiriği burda.
            istemci.Send(mesaj); // istemci verileri mesaj sınıfından alacak ve outlook'a gönderecek.
            


        }
    }
}
