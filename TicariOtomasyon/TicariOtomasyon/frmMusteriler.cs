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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_MUSTERILER",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void SehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from TBL_İLLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); //verileri okutacaz sonra komut ile ilişkilendirdik
             while (dr.Read())//okuma işlemi sürdüğü sürece
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void frmMusteriler_Load(object sender, EventArgs e)
        {

            listele();
            SehirListesi();
            temizle();
        }
        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTlfn1.Text = "";
            mskTlf2.Text = "";
            mskTC.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            richAdres.Text = "";
            txtVergi.Text = "";

        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // şimdi il comboboxsında herhangi bir değişikilk olduğunda ne olsun onu yapcaz
            //yani seçilen ile göre ilçe combosu otomatik o ile ait  ilçeleri getirmesi için

            cmbIlce.Properties.Items.Clear(); //seçildikten sonra comboyu temizle
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_İLCELER where SEHİR=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex+1);//parametre  il combosundan seçilen index değeri diyoruz /+1 0 dan başladığı için biz 1 den başlamasını istiyoruz
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) // dr nesnesi okmayı yaptığı mütdetçe ilçeyi doldurcak
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
             
        
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTlfn1.Text);
            komut.Parameters.AddWithValue("@p4", mskTlf2.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbIl.Text);
            komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", richAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //fare ile imlecin seçitiği satırı dr adlı komuta atadaık 

            if(dr != null) // eğer dr değerim null dan farklı ise
            {
                txtID.Text = dr["ID"].ToString(); // seçile olan datanın bilgilerini textboxa yazması için
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();
                mskTlfn1.Text = dr["TELEFON"].ToString();
                mskTlf2.Text = dr["TELEFON2"].ToString();
                mskTC.Text = dr["TC"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                cmbIl.Text = dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();
                richAdres.Text = dr["ADRES"].ToString();
                txtVergi.Text = dr["VERGIDAIRE"].ToString();
 
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_MUSTERILER where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtID.Text); // parametreye değer atıcaz parametreye gelen değerdi txtid.text den gelcek
            komut.ExecuteNonQuery();//executenonQuery tablo üzerinden değişiklik olduğu zaman çalışıyor ekle sil güncellede bu komutu kullanıyoruz
                                    // "executeReader()" ise sadece select sorgusunda çalışıyordu   
            bgl.baglanti().Close();

            MessageBox.Show("Müşteri Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            listele();




        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERILER set AD=@p1,SOYAD=@p2,TELEFON=@p3," +
                "TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@p10 where ID=@p11",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTlfn1.Text);
            komut.Parameters.AddWithValue("@p4", mskTlf2.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", cmbIl.Text);
            komut.Parameters.AddWithValue("@p8", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p9", richAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut.Parameters.AddWithValue("@p11", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
