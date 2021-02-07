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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_NOTLAR",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        
        void temizle()
        {
            txtID.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtBaslik.Text = "";
            txtOlusturan.Text = "";
            txtHitap.Text = "";
            richDetay.Text = "";
        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (TARIH,SAAT,BASLIK,OLUSTURAN,HITAP,DETAY)" +
                " values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTarih.Text);
            komut.Parameters.AddWithValue("@p2", mskSaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtOlusturan.Text);
            komut.Parameters.AddWithValue("@p5", txtHitap.Text);
            komut.Parameters.AddWithValue("@p6", richDetay.Text);
            komut.ExecuteNonQuery(); 
            bgl.baglanti().Close();
            MessageBox.Show("Notunuz sisteme eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //fare ile imlecin seçitiği satırı dr adlı komuta atadaık 
   
            if (dr != null) // eğer dr değerim null dan farklı ise
            {
                txtID.Text = dr["ID"].ToString(); // seçile olan datanın bilgilerini textboxa yazması için
                mskTarih.Text = dr["TARIH"].ToString();
                mskSaat.Text = dr["SAAT"].ToString();
                txtBaslik.Text = dr["BASLIK"].ToString();
                txtOlusturan.Text = dr["OLUSTURAN"].ToString();
                txtHitap.Text = dr["HITAP"].ToString();
                richDetay.Text = dr["DETAY"].ToString(); 
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_NOTLAR where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not sistemden silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            listele();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set TARIH=@p1,SAAT=@p2,BASLIK=@p3,OLUSTURAN=@p4,HITAP=@p5,DETAY=@p6 " +
                "WHERE ID=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTarih.Text);
            komut.Parameters.AddWithValue("@p2", mskSaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtOlusturan.Text);
            komut.Parameters.AddWithValue("@p5", txtHitap.Text);
            komut.Parameters.AddWithValue("@p6", richDetay.Text);
            komut.Parameters.AddWithValue("@p7", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Notunuz güncellendi! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmNotDetay fr = new frmNotDetay();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                fr.metin = dr["DETAY"].ToString();
            }
            fr.Show();
        }
    }
}
