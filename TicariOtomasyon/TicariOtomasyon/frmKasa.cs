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
using DevExpress.Charts;

namespace TicariOtomasyon  
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void MusteriHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute MusteriHareketler",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        
        void FirmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        void listele()
        {    
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt); // dt yi doldur adapeterdan gelen bilgiler ile
            gridControl2.DataSource = dt; // grid kontrole dt den gelen değer gelsin 
        }

        public string ad;
        private void frmKasa_Load(object sender, EventArgs e)
        {
            MusteriHareket();
            FirmaHareket();
            listele();
            lblAktifKullanici.Text = ad;
            // Toplam Tutarı Hesaplama

            SqlCommand komut1 = new SqlCommand("select sum(TUTAR) from TBL_FATURADETAY",bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblKasaToplamNEkadarVar.Text = dr1[0].ToString()+" TL";
            }
            bgl.baglanti().Close();


            //Son Ayın faturaları 

            SqlCommand komut2 = new SqlCommand("select (ELEKTIRIK+SU+DOGALGAZ+INTERNET+EXSTRA)from TBL_GIDERLER order by ID asc",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblOdemeler.Text = dr2[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            // SON AYIN PERSONEL MAAŞLARI 

            SqlCommand komut3 = new SqlCommand("select MAASLAR from TBL_GIDERLER",bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblPersonelMaas.Text = dr3[0].ToString()+" TL";
            }
            bgl.baglanti().Close();

            // TOPLAM MUŞTERİ SAYISI 

            SqlCommand komut4 = new SqlCommand("select count(*) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblMusteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();

            // TOPLAM FİRMA SAYISI 

            SqlCommand komut5 = new SqlCommand("select count(*) from TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblFirmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();


            // TOPLAM Firma ŞEHİR SAYISI 

            SqlCommand komut6 = new SqlCommand("select count(Distinct(IL)) from TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblFirmaSehirSayisi.Text = dr6[0].ToString();
            }
            bgl.baglanti().Close();


            // TOPLAM Müşteri ŞEHİR SAYISI 

            SqlCommand komut7 = new SqlCommand("select count(Distinct(IL)) from TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblMusterşSehirSayisi.Text = dr7[0].ToString();
            }
            bgl.baglanti().Close();

            // TOPLAM Personel SAYISI 

            SqlCommand komut8 = new SqlCommand("select count(*) from TBL_PERSONELLER", bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblPersonelSayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            // TOPLAM Stok SAYISI 

            SqlCommand komut9 = new SqlCommand("select sum(ADET) from TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lblStokSayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

          

        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            
            // ELEKTİRİL
            if (sayac > 0 && sayac <= 5)
            {
                groupControl10.Text = "ELEKTİRİK";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 4 AY,ELEKTIRIK FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();

            }

            //SU
            if (sayac>5 && sayac>=10)
            {
                groupControl10.Text = "SU";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,SU FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //DOGALGAZ
            if (sayac > 10 && sayac >= 15)
            {
                groupControl10.Text = "DOĞALGAZ";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,DOGALGAZ FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //INTERNET
            if (sayac > 15 && sayac >= 20)
            {
                groupControl10.Text = "İNTERNET";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,INTERNET FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //EXSTRA
            if (sayac > 20 && sayac >= 25)
            {
                groupControl10.Text = "EXSTRA";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,EXSTRA FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if(sayac == 26)
            {
                sayac = 0;
            }
        }

        int sayac2 = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            

            sayac2++;

            // ELEKTİRİL
            if (sayac2 > 0 && sayac2 <= 5)
            {
                groupControl11.Text = "ELEKTİRİK";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut10 = new SqlCommand("select top 4 AY,ELEKTIRIK FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();

            }

            //SU
            if (sayac2 > 5 && sayac2 >= 10)
            {
                groupControl11.Text = "SU";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,SU FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //DOGALGAZ
            if (sayac2 > 10 && sayac2 >= 15)
            {
                groupControl11.Text = "DOĞALGAZ";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,DOGALGAZ FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //INTERNET
            if (sayac2 > 15 && sayac2 >= 20)
            {
                groupControl11.Text = "İNTERNET";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,INTERNET FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }

            //EXSTRA
            if (sayac2 > 20 && sayac2 >= 25)
            {
                groupControl11.Text = "EXSTRA";
                chartControl2.Series["Aylar"].Points.Clear();
                SqlCommand komut11 = new SqlCommand("select top 4 AY,EXSTRA FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac2 == 26)
            {
                sayac2 = 0;
            }

        }
    }
}
