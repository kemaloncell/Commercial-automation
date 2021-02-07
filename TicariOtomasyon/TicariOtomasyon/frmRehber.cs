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
    public partial class frmRehber : Form
    {
        public frmRehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmRehber_Load(object sender, EventArgs e)
        {
            //**  MÜŞTERİLER PAGESİ İÇİN OLAN KISIM  **/
            DataTable dt = new DataTable();//datatable veritabanı ile programın arasında duran bir sağalayı gibi düşün
            SqlDataAdapter da = new SqlDataAdapter("select AD,SOYAD,TELEFON,TELEFON2,MAIL FROM TBL_MUSTERILER",bgl.baglanti());
            // sorguyu dataadapter ike yazdık 
            da.Fill(dt); // sonra da.datayı dt nini içine fill ile doldurduk
            gridControl1.DataSource = dt; //daha sonra gridcontrolün datasourcesine dt den gelen değeri bastık 

            //**  FİRMALAR PAGESİ İÇİN OLAN KISIM  **/
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select AD,YETKILIADSOYAD,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX from TBL_FIRMALAR",bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //** müşteriler mailini göstermek için satırın sol tarafına çift tık ile basınca maili göndermek için **//
            frmMail frm = new frmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle); //seçtiğimiz satırın verisini dr adlı değere atadık dataRow datatable satırı gibi düşün

            if (dr != null) // dr bilinmeyen bir değer değilse
            {
                frm.mail = dr["MAIL"].ToString(); // frm burda mail formu yarratıkya onun nesnesi orada mail adında bir değişken oluşturduk ve labela atadık şimdi onu dolurcaz müşteririnin maili ile
            }
            frm.Show(); // frm formunu göster
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            //** Firmalar mailini göstermek için satırın sol tarafına çift tık ile basınca maili göndermek için   **//

            frmMail frm = new frmMail();
            DataRow dr = gridView2.GetDataRow(gridView1.FocusedRowHandle); //seçtiğimiz satırın verisini dr adlı değere atadık dataRow datatable satırı gibi düşün

            if (dr != null) // dr bilinmeyen bir değer değilse
            {
                frm.mail = dr["MAIL"].ToString(); // frm burda mail formu yarratıkya onun nesnesi orada mail adında bir değişken oluşturduk ve labela atadık şimdi onu dolurcaz müşteririnin maili ile
            }
            frm.Show(); // frm formunu göster
        }
    }
    
}
