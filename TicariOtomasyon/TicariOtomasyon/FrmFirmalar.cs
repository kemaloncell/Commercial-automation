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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        
        void FirmaListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_FIRMALAR",bgl.baglanti());// adapter ile verileri okuduk listeledik baglati() ile ilişkilendirdik
            DataTable dt = new DataTable();// hafızada veri tabanı ile kodlar arasında bir table yarattık
            da.Fill(dt);//da 'dan gelen bilgileri dt ile fulledik
            gridControl1.DataSource = dt; // girdcontrlün soursuna dt den gelen değeri atadık 

        }
        void cariKodAciklamalar()
        {

            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR", bgl.baglanti());

            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                rchKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
        void temizle()
        {
            txtID.Text = "";
            txtAd.Text = "";
            txtGorev.Text = "";
            txtyetkili.Text = "";
            mskYetkiliTC.Text = "";
            txtSektor.Text = "";
            mskTlfn1.Text = "";
            mskTlf3.Text = "";
            mskTlf3.Text = "";
            mskFax.Text = "";
            txtMail.Text = "";
            cmbIl.Text = "";
            cmbIlce.Text = "";
            txtVergi.Text = "";
            richAdres.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
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
        private void rchKod2_TextChanged(object sender, EventArgs e)
        {

        }
        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            FirmaListesi();
            SehirListesi();
            cariKodAciklamalar();
            temizle();
      
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //fare ile imlecin seçitiği satırı dr adlı komuta atadaık 

            if (dr != null) // eğer dr değerim null dan farklı ise
            {
                txtID.Text = dr["ID"].ToString(); // seçile olan datanın bilgilerini textboxa yazması için
                txtAd.Text = dr["AD"].ToString(); 
                txtGorev.Text = dr["YETKILIGOREV"].ToString(); 
                txtyetkili.Text = dr["YETKILIADSOYAD"].ToString(); 
                mskYetkiliTC.Text = dr["YETKILITC"].ToString(); 
                txtSektor.Text = dr["SEKTOR"].ToString(); 
                mskTlfn1.Text = dr["TELEFON1"].ToString(); 
                mskTlf2.Text = dr["TELEFON2"].ToString(); 
                mskTlf3.Text = dr["TELEFON3"].ToString(); 
                mskFax.Text = dr["FAX"].ToString(); 
                txtMail.Text = dr["MAIL"].ToString(); 
                cmbIl.Text = dr["IL"].ToString(); 
                cmbIlce.Text = dr["ILCE"].ToString(); 
                txtVergi.Text = dr["VERGIDAIRE"].ToString(); 
                richAdres.Text = dr["ADRES"].ToString(); 
                txtKod1.Text = dr["OZELKOD1"].ToString(); 
                txtKod2.Text = dr["OZELKOD2"].ToString(); 
                txtKod3.Text = dr["OZELKOD3"].ToString();       

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

           // Bilgileri Kayıt etmek için

            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR (AD,YETKILIGOREV,YETKILIADSOYAD,YETKILITC," +
                "SEKTOR,TELEFON1,TELEFON2,TELEFON3,FAX,MAIL,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values(@P1,@P2,@P3," +
                "@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)",bgl.baglanti());

            komut.Parameters.AddWithValue("@P1",txtAd.Text);
            komut.Parameters.AddWithValue("@P2",txtGorev.Text);
            komut.Parameters.AddWithValue("@P3",txtyetkili.Text);
            komut.Parameters.AddWithValue("@P4",mskYetkiliTC.Text);
            komut.Parameters.AddWithValue("@P5",txtSektor.Text);
            komut.Parameters.AddWithValue("@P6",mskTlfn1.Text);
            komut.Parameters.AddWithValue("@P7",mskTlf2.Text);
            komut.Parameters.AddWithValue("@P8",mskTlf3.Text);
            komut.Parameters.AddWithValue("@P9",mskFax.Text);
            komut.Parameters.AddWithValue("@P10",txtMail.Text);
            komut.Parameters.AddWithValue("@P11",cmbIl.Text);
            komut.Parameters.AddWithValue("@P12",cmbIlce.Text);
            komut.Parameters.AddWithValue("@P13",txtVergi.Text);
            komut.Parameters.AddWithValue("@P14",richAdres.Text);
            komut.Parameters.AddWithValue("@P15",txtKod1.Text);
            komut.Parameters.AddWithValue("@P16",txtKod2.Text);
            komut.Parameters.AddWithValue("@P17",txtKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma sisteme kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            FirmaListesi();
            temizle();
            
        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void cmbIl_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FIRMALAR where ID=@P1",bgl.baglanti());
            komut.Parameters.AddWithValue("@P1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            FirmaListesi();
            MessageBox.Show("Firma Listen Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FIRMALAR set AD=@P1,YETKILIGOREV=@P2,YETKILIADSOYAD=@P3,YETKILITC=@P4," +
                "SEKTOR=@P5,TELEFON1=@P6,TELEFON2=@P7,TELEFON3=@P8,FAX=@P9,MAIL=@P10,IL=@P11,ILCE=@P12,VERGIDAIRE=@P13," +
                "ADRES=@P14,OZELKOD1=@P15,OZELKOD2=@P16,OZELKOD3=@P17  where ID=@P18",bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", txtAd.Text);
            komut.Parameters.AddWithValue("@P2", txtGorev.Text);
            komut.Parameters.AddWithValue("@P3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@P4", mskYetkiliTC.Text);
            komut.Parameters.AddWithValue("@P5", txtSektor.Text);
            komut.Parameters.AddWithValue("@P6", mskTlfn1.Text);
            komut.Parameters.AddWithValue("@P7", mskTlf2.Text);
            komut.Parameters.AddWithValue("@P8", mskTlf3.Text);
            komut.Parameters.AddWithValue("@P9", mskFax.Text);
            komut.Parameters.AddWithValue("@P10", txtMail.Text);
            komut.Parameters.AddWithValue("@P11", cmbIl.Text);
            komut.Parameters.AddWithValue("@P12", cmbIlce.Text);
            komut.Parameters.AddWithValue("@P13", txtVergi.Text);
            komut.Parameters.AddWithValue("@P14", richAdres.Text);
            komut.Parameters.AddWithValue("@P15", txtKod1.Text);
            komut.Parameters.AddWithValue("@P16", txtKod2.Text);
            komut.Parameters.AddWithValue("@P17", txtKod3.Text);
            komut.Parameters.AddWithValue("@P18", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma sisteme Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            FirmaListesi();
            temizle();

        }
    }
}
