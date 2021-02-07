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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void giderListesi()
        {
            // grid doldurmak için datable kullanıyoruz okkkey ve adaptere yazıyoruz sorguyu
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * FROM TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;
               // gride veritabanındaki değerleri bastık 
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            giderListesi();
            temizle();
            
        }
        void temizle()
        {
            txtID.Text = "";
            cmbAy.Text = "";
            cmbyil.Text = "";
            txtelektirik.Text = "";
            txtSu.Text = "";
            txtGaz.Text = "";
            txtinternet.Text = "";
            txtMaas.Text = "";
            txtExstra.Text = "";
            richNot.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTIRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EXSTRA,NOTLAR) values(@p1,@p2,@p3," +
                "@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            // decimale çevirmem gerek çünkü giren kişi int giriyor
            // boş bırkırsan textleri hata verir 0 ver değer vermiceksen ıd girme not boş kalabilir 
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            komut.Parameters.AddWithValue("@p2", cmbyil.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtelektirik.Text));
            komut.Parameters.AddWithValue("@p4",decimal.Parse(txtSu.Text));
            komut.Parameters.AddWithValue("@p5",decimal.Parse(txtGaz.Text));
            komut.Parameters.AddWithValue("@p6",decimal.Parse(txtinternet.Text));
            komut.Parameters.AddWithValue("@p7",decimal.Parse(txtMaas.Text));
            komut.Parameters.AddWithValue("@p8",decimal.Parse(txtExstra.Text));
            komut.Parameters.AddWithValue("@p9",richNot.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider bilgisi tabloya eklendi ", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            giderListesi();
            temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //üstüne gelinde texler dolsun 
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); // seçitiğimiz veriyi al dr ye at
            if(dr != null)// bilinmeyen değerden farklı ise
            {
                txtID.Text = dr["ID"].ToString();
                cmbAy.Text = dr["AY"].ToString();
                cmbyil.Text = dr["YIL"].ToString();
                txtelektirik.Text = dr["ELEKTIRIK"].ToString();
                txtSu.Text = dr["SU"].ToString();
                txtGaz.Text = dr["DOGALGAZ"].ToString();
                txtinternet.Text = dr["INTERNET"].ToString();
                txtMaas.Text = dr["MAASLAR"].ToString();
                txtExstra.Text = dr["EXSTRA"].ToString();
                richNot.Text = dr["NOTLAR"].ToString();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            cmbAy.Text = "";
            cmbyil.Text = "";
            txtelektirik.Text = "";
            txtSu.Text = "";
            txtGaz.Text = "";
            txtinternet.Text = "";
            txtMaas.Text = "";
            txtExstra.Text = "";
            richNot.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_GIDERLER where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderListesi();
            MessageBox.Show("Gider bilgisi listeden silindi", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            temizle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update TBL_GIDERLER set AY=@p1,YIL=@p2,ELEKTIRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7" +
                ",EXSTRA=@p8,NOTLAR=@p9 where ID=@p10", bgl.baglanti());

            guncelle.Parameters.AddWithValue("@p1", cmbAy.Text);
            guncelle.Parameters.AddWithValue("@p2", cmbyil.Text);
            guncelle.Parameters.AddWithValue("@p3", decimal.Parse(txtelektirik.Text));
            guncelle.Parameters.AddWithValue("@p4", decimal.Parse(txtSu.Text));
            guncelle.Parameters.AddWithValue("@p5", decimal.Parse(txtGaz.Text));
            guncelle.Parameters.AddWithValue("@p6", decimal.Parse(txtinternet.Text));
            guncelle.Parameters.AddWithValue("@p7", decimal.Parse(txtMaas.Text));
            guncelle.Parameters.AddWithValue("@p8", decimal.Parse(txtExstra.Text));
            guncelle.Parameters.AddWithValue("@p9", richNot.Text);
            guncelle.Parameters.AddWithValue("@p10", txtID.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider bilgisi tabloya güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            giderListesi();
            temizle();
        }

        
    }
}
