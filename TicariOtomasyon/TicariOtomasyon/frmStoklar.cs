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
    public partial class frmStoklar : Form
    {
        public frmStoklar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmStoklar_Load(object sender, EventArgs e)
        {
            // series serilerden geliyor chart içindeki değerleri seri olarak kabul ediyor
            //.Points 'de bizim konumlarımız s ile y kordinatları hesabı 
            // addPoints ile ben buna konum ekliyecem ilk komut String olcak ikinci tam sayı olcak
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 8);

            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,SUM(ADET)as ADET from TBL_URUNLER group by URUNAD",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            // Chart Stok listeleme
            SqlCommand komut = new SqlCommand("select URUNAD,SUM(ADET)as ADET from TBL_URUNLER group by URUNAD", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString())); 
            }
        }
    }
}
