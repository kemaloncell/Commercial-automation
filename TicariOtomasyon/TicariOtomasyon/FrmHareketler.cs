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
    public partial class FrmHareketler : Form
    {
        public FrmHareketler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void MusteriHareketler()
        {
            SqlDataAdapter da = new SqlDataAdapter("exec MusteriHareketler ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            
        }
        void FirmaHareketler()
        {
            SqlDataAdapter da = new SqlDataAdapter("exec FirmaHareketler ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }

        private void FrmHareketler_Load(object sender, EventArgs e)
        {
            MusteriHareketler();
            FirmaHareketler();
        }
    }
}
