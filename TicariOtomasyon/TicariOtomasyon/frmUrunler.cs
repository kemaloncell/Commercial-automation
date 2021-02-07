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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            mskYil.Text = "";
            nudAdet.Value = 0;
            txtAlisFiyat.Text = "";
            txtSatisFiyat.Text = "";
            richDetay.Text = "";

        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER",bgl.baglanti());
            da.Fill(dt); // dataadapterin içine datatablı doldur
            gridControl1.DataSource = dt; // gridcontrolün datasourcesi dt den gelen değer olsun yani gride verileri bastık 
            temizle();

        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            listele(); // fonksiyonu çağırıp direkt kullandık 
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Verileri Kaydetme 

            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER (URUNAD, URUNMARKASI, MODEL, YIL, ADET, ALISFIYAT, SATISFIYAT,DETAY) " +
                "values(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text); // değer olarak ekletmek için örn p@1 değeri txt.ad için
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));// numericupdowndan gelen string değeri döndür decimale 
            komut.Parameters.AddWithValue("@p6", decimal.Parse((txtAlisFiyat.Text).ToString()));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((txtSatisFiyat.Text).ToString()));// aynı şekilde texte girilen string değeri biz decimale çevirip veri tabanına öyle yazıdırıyoruz
            komut.Parameters.AddWithValue("@p8", richDetay.Text);
            komut.ExecuteNonQuery();// soruguyu çalıştırıyor
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();// verileri listeleme metodu

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1",bgl.baglanti());//idsine göre silecez
            komutsil.Parameters.AddWithValue("@p1",txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // AMAÇ GRİD VİEWE BASINCA BİLGİLERİ SAĞDAKİ  TEXTBOXLARA OTOMATİK DOLSUN
            //grid viewin focusedrowchanged özelliğine çift tık yani imlecin satı odağı değiştiğinde ne olsun
            // datarow bizim veri satırımız dr isminde bir nesne türettik şimdi dr komutuma görev atıcaz gridview içine satırının verisini al diedik
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // şimdi getDataRow fonksiyon parametre istyor neyi alalım diyor bizde gridviewdeki seçilen satır diyoruz
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();//txt.Ad textini dr den gelen seçilen ad ile doldur 
            txtMarka.Text = dr["URUNMARKASI"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYil.Text = dr["YIL"].ToString();
            nudAdet.Value = decimal.Parse(dr["ADET"].ToString());
            txtAlisFiyat.Text=dr["ALISFIYAT"].ToString();
            txtSatisFiyat.Text = dr["SATISFIYAT"].ToString();
            richDetay.Text = dr["DETAY"].ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //GÜNCELLEME  BUTONUNA TIKLAYINCA

            SqlCommand komut = new SqlCommand("update TBL_URUNLER set " +
            "URUNAD=@p1,URUNMARKASI=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text); // değer olarak ekletmek için örn p@1 değeri txt.ad için
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nudAdet.Value).ToString()));// numericupdowndan gelen string değeri döndür decimale 
            komut.Parameters.AddWithValue("@p6", decimal.Parse((txtAlisFiyat.Text).ToString()));
            komut.Parameters.AddWithValue("@p7", decimal.Parse((txtSatisFiyat.Text).ToString()));// aynı şekilde texte girilen string değeri biz decimale çevirip veri tabanına öyle yazıdırıyoruz
            komut.Parameters.AddWithValue("@p8", richDetay.Text);
            komut.Parameters.AddWithValue("@p9", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Bilgileri Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();// son hali bize listelesin
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
