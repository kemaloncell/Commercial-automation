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
using System.Xml;

namespace TicariOtomasyon
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        void stoklar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select URUNAD,sum(adet) as adet from TBL_URUNLER group by URUNAD having sum(adet) >= 20 order by sum(adet) ",bgl.baglanti());
            da.Fill(dt);
            gridControlStoklar.DataSource = dt;
        }

        void ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select top 5  TARIH , SAAT , BASLIK from TBL_NOTLAR  order by ID desc", bgl.baglanti());
            da.Fill(dt);
            gridControlAjanda.DataSource = dt;
        }

        void FirmaHareketler()
        {
            SqlDataAdapter da = new SqlDataAdapter("exec FirmaHareket2 ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlFirmahareket.DataSource = dt;

        }

        void fihrist()
        {
            SqlDataAdapter da = new SqlDataAdapter("select AD, TELEFON1 from TBL_FIRMALAR ", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControlFihrist.DataSource = dt;
        }

        void haberler()
        {

            XmlTextReader xml = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xml.Read())
            {
                if (xml.Name == "title")
                {
                    listBox1.Items.Add(xml.ReadString());
                }
            }       
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
       
            stoklar();
            ajanda();
            FirmaHareketler();
            fihrist();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
            haberler();
          
        }
    }
}
