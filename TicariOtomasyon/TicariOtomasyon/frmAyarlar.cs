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
    public partial class frmAyarlar : Form
    {
        public frmAyarlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_ADMIN",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            listele();
            txtID.Text = "";
            txtkulAd.Text = "";
            txtSifre.Text = "";
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtkulAd.Text = dr["KullaniciAd"].ToString();
                txtSifre.Text = dr["Sifre"].ToString();
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_ADMIN values(@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkulAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni admin sistemi kayıt  edildi ", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_ADMIN set KullaniciAd=@p1 , Sifre=@p2 where ID=@p3 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1 ", txtkulAd.Text);
            komut.Parameters.AddWithValue("@p2 ", txtSifre.Text);
            komut.Parameters.AddWithValue("@p3 ", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Admin Bilgileri Güncellendi ", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_ADMIN where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Admin Sistemden Silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            listele();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtkulAd.Text = "";
            txtSifre.Text = "";
        }
    }
}
