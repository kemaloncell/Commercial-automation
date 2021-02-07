using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail; // mail göndermek için net kütüphanesini mail kütüphanesi import ettik

namespace TicariOtomasyon
{
    public partial class frmMail : Form
    {
        public frmMail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frmMail_Load(object sender, EventArgs e)
        {
            txtmail.Text = mail; // mail textboxsunu otomatik tıklayınca kişinin maili dolsun diye atadım 
        }

        private void gonder_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci = new SmtpClient(); //istiyoruz kapyı tıklatıyoruz gibi düşün
            istemci.Credentials = new System.Net.NetworkCredential("mail","şifre");
            //itemci.credentials = yani isteminin kimliği =  // NetworkCredential= ağ kimliği olarak düşünebilirisin 
            istemci.Port = 587;
            istemci.Host = "smtp.gmail.com"; //itemcinin sunucusu;
            istemci.EnableSsl = true; // yol boyunca şifrelesinmi evet dedim 
            mesaj.To.Add(txtmail.Text);// şimdi mesajımın içine ekle richmesajdan gelen mesajı 
            mesaj.From= new MailAddress("üstekinin ayınısı mail");// mesajın kimden gideceği
            mesaj.Subject = txtkonu.Text; // mesajın konusu
            mesaj.Body = richMesaj.Text; // mesajın içeriği 
            istemci.Send(mesaj); // istemciye benim mesajım nesnesini göndermesini emrettim :D
            MessageBox.Show("Mailiniz Gönderildi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
