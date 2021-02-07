using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TicariOtomasyon
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Cyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackColor = Color.Gray;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBL_ADMIN where KullaniciAd=@p1 and Sifre=@p2 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkulAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 anamodul = new Form1();
                anamodul.kullanici = txtkulAd.Text;
                anamodul.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı yada Şifre ", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            bgl.baglanti().Close();
            
        }
    }
}
