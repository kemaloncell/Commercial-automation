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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURABILGI",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            bgl.baglanti().Close();
        }

        void temizle()
        {
            txtID.Text = "";
            txtSeri.Text = "";
            txtSira.Text = "";
            mskTarih.Text = "";
            mskSaat.Text = "";
            txtVergiD.Text = "";
            txtAlici.Text = "";
            txtTeden.Text = "";
            txtTalan.Text = "";

        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
       
            // Müşteri Carisi
            if (txtFaturaID.Text != "" && comboBox1.Text == "Müşteri")
            {
                double fiyat, miktar, tutar;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURAID)" +
                    "VALUES(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

                komut2.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtFaturaID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //hareket tablosuna veri girişi

                SqlCommand komut3 = new SqlCommand("insert into TBL_MUSTERIHAREKET (URUNID, ADET, PERSONEL, MUSTERI, FIYAT,TOPLAM,FATURAID,TARIH)" +
                    "VALUES(@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txtUrunID.Text);
                komut3.Parameters.AddWithValue("@h2", txtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtFaturaID.Text);
                komut3.Parameters.AddWithValue("@h8", mskTarih.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                // stok sayısını azaltma 

                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER set ADET=ADET-@s1 where ID=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", txtUrunID.Text);
                komut4.ExecuteNonQuery();

                MessageBox.Show("Faturaya ait ürün eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }

          
            if (txtFaturaID.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI (SERI,SIRANO,TARIH,SAAT, VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN)" +
                    " values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSira.Text);
                komut.Parameters.AddWithValue("@p3", mskTarih.Text);
                komut.Parameters.AddWithValue("@p4", mskSaat.Text);
                komut.Parameters.AddWithValue("@p5", txtVergiD.Text);
                komut.Parameters.AddWithValue("@p6", txtAlici.Text);
                komut.Parameters.AddWithValue("@p7", txtTeden.Text);
                komut.Parameters.AddWithValue("@p8", txtTalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();  
                MessageBox.Show("Faturaya ait Bilgi sisteme eklendi ","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                listele();
               
            }

            // Firma Carisi
            if (txtFaturaID.Text != "" && comboBox1.Text == "Firma")
            {
                double fiyat, miktar, tutar;
                fiyat = Convert.ToDouble(txtFiyat.Text);
                miktar = Convert.ToDouble(txtMiktar.Text);
                tutar = miktar * fiyat;
                txtTutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURAID)"+
                    "VALUES(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());

                komut2.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", txtMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txtFiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
                komut2.Parameters.AddWithValue("@p5", txtFaturaID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                //hareket tablosuna veri girişi

                SqlCommand komut3 = new SqlCommand("insert into TBL_FIRMAHAREKETLER (URUNID, ADET, PERSONEL, FIRMA, FIYAT,TOPLAM,FATURAID,TARIH)" +
                    "VALUES(@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", txtUrunID.Text);
                komut3.Parameters.AddWithValue("@h2", txtMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", txtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", txtFirma.Text);
                komut3.Parameters.AddWithValue("@h5", decimal.Parse(txtFiyat.Text));
                komut3.Parameters.AddWithValue("@h6", decimal.Parse(txtTutar.Text));
                komut3.Parameters.AddWithValue("@h7", txtFaturaID.Text);
                komut3.Parameters.AddWithValue("@h8", mskTarih.Text); 
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();

                // stok sayısını azaltma 

                SqlCommand komut4 = new SqlCommand("update TBL_URUNLER set ADET=ADET-@s1 where ID=@s2", bgl.baglanti());
                komut4.Parameters.AddWithValue("@s1", txtMiktar.Text);
                komut4.Parameters.AddWithValue("@s2", txtUrunID.Text);
                komut4.ExecuteNonQuery();

                MessageBox.Show("Faturaya ait ürün eklendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!= null)
            {
                // dr değeri boşa eşit değilse tıklandığında bilgileri inputa gir
                txtID.Text = dr["FATURABILGIID"].ToString();
                txtSeri.Text = dr["SERI"].ToString();
                txtSira.Text = dr["SIRANO"].ToString();
                mskTarih.Text = dr["TARIH"].ToString();
                mskSaat.Text = dr["SAAT"].ToString();
                txtVergiD.Text = dr["VERGIDAIRE"].ToString();
                txtAlici.Text = dr["ALICI"].ToString();
                txtTeden.Text = dr["TESLIMEDEN"].ToString();
                txtTalan.Text = dr["TESLIMALAN"].ToString();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          
                SqlCommand sil = new SqlCommand("delete from TBL_FATURABILGI where FATURABILGIID=@p1",bgl.baglanti());
                sil.Parameters.AddWithValue("@p1", txtID.Text);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                listele();        
                
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4, VERGIDAIRE=@p5," +
                "ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSira.Text);
                komut.Parameters.AddWithValue("@p3", mskTarih.Text);
                komut.Parameters.AddWithValue("@p4", mskSaat.Text);
                komut.Parameters.AddWithValue("@p5", txtVergiD.Text);
                komut.Parameters.AddWithValue("@p6", txtAlici.Text);
                komut.Parameters.AddWithValue("@p7", txtTeden.Text);
                komut.Parameters.AddWithValue("@p8", txtTalan.Text);
                komut.Parameters.AddWithValue("@p9", txtID.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya Bilgisi Güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmFaturaUrunleri fr = new frmFaturaUrunleri();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //gridviwde imlecin olduğu seçilen satırın verisini al
            if(dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString(); //  fr formunun içindeki id değişkenine dr den gelen faturaid yi eşitledik
            }
            fr.Show();
        }

        private void btnbul_Click(object sender, EventArgs e)
        {
            // urun bula basınca otomatik fiyatını ve adını doldurcak ürünün 
            SqlCommand komut = new SqlCommand("select URUNAD, SATISFIYAT from TBL_URUNLER where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtUrunID.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtUrunAd.Text = dr[0].ToString();
                txtFiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
