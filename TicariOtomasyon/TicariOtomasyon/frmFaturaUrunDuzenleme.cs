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
    public partial class frmFaturaUrunDuzenleme : Form
    {
        public frmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtUrunID.Text = urunid;
            SqlCommand komut = new SqlCommand("select * from TBL_FATURADETAY where FATURAURUNID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[1].ToString();
                txtMiktar.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();
                txtTutar.Text = dr[4].ToString();
                bgl.baglanti().Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY set URUNAD=@p1, MIKTAR=@p2, FIYAT=@p3, TUTAR=@p4 where FATURAURUNID=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p2",txtMiktar.Text);
            komut.Parameters.AddWithValue("@p3",decimal.Parse(txtFiyat.Text));
            komut.Parameters.AddWithValue("@p4",decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p5",txtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler kayıt edildi ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FATURADETAY where FATURAURUNID=@p1 ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Silme işlemi başarı ile gerçekleştir ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
