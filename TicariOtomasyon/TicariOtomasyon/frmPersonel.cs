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
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void personelListe()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER",bgl.baglanti());
            da.Fill(dt); // dt yi doldur adapeterdan gelen bilgiler ile
            gridControl1.DataSource = dt; // grid kontrole dt den gelen değer gelsin 
        }

        void SehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from TBL_İLLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader(); //verileri okutacaz sonra komut ile ilişkilendirdik
            while (dr.Read())//okuma işlemi sürdüğü sürece
            {
                cmbIl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTlfn1.Text = "";
            mskTC.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            richAdres.Text = "";
            txtGorev.Text = "";

        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
            personelListe(); // formun loadında açılınca form personelleri listele 
            SehirListesi(); // fromda şehir listesini göstermek için 
            temizle(); // formu açılışında temizle boş göster


        }

     

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) " +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text); // parametreyi değer olarak ekle
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTlfn1.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbIl.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", richAdres.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel bilgileri kayıt edildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            personelListe();
        }   

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // şimdi il comboboxsında herhangi bir değişikilk olduğunda ne olsun onu yapcaz
            //yani seçilen ile göre ilçe combosu otomatik o ile ait  ilçeleri getirmesi için

            cmbIlce.Properties.Items.Clear(); //seçildikten sonra comboyu temizle
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_İLCELER where SEHİR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbIl.SelectedIndex + 1);//parametre  il combosundan seçilen index değeri diyoruz /+1 0 dan başladığı için biz 1 den başlamasını istiyoruz
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) // dr nesnesi okmayı yaptığı mütdetçe ilçeyi doldurcak
            {
                cmbIlce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();





        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // yani benim fare ile tıklamış olduğum alanın verisini aldır

            if (dr != null) // dr null bir değer değil ise
            {
                txtID.Text = dr["ID"].ToString(); // dr den gelen id yi yazdırdım
                txtAd.Text = dr["AD"].ToString();
                txtSoyad.Text = dr["SOYAD"].ToString();
                mskTlfn1.Text = dr["TELEFON"].ToString();
                mskTC.Text = dr["TC"].ToString();
                txtMail.Text = dr["MAIL"].ToString();
                cmbIl.Text = dr["IL"].ToString();
                cmbIlce.Text = dr["ILCE"].ToString();
                txtGorev.Text = dr["GOREV"].ToString();
                richAdres.Text = dr["ADRES"].ToString();
                // tıkladğımızda verileri formlara dolsun işte 
             
               
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_PERSONELLER where ID=@p1", bgl.baglanti());
            // idye göre seçilen kişiyi siler 
            komut.Parameters.AddWithValue("@p1",txtID.Text);//  idye değerimizi atadık textenID den gelen değer 
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Listeden Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            personelListe();
            temizle();
            
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
               SqlCommand komut = new SqlCommand("Update TBL_PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6," +
                   "ILCE=@p7,ADRES=@p8,GOREV=@p9 WHERE ID=@p10",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text); // parametreyi değer olarak ekle
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTlfn1.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtMail.Text);
            komut.Parameters.AddWithValue("@p6", cmbIl.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", richAdres.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.Parameters.AddWithValue("@p10", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel bilgileri Güncellendi .", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelListe();
        }
    }
}
