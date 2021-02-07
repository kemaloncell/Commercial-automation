using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmUrunler fr;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr == null || fr.IsDisposed) // ürün yeniden yeniden açılmasın diye basit bir if  veya ürün hiç açılmadıysa aç 
            {
                fr = new frmUrunler();
                fr.MdiParent = this;// bu formun üzerinde mdi olarak açılsın
                fr.Show();
            }
            
        }
        public string kullanici;
        private void Form1_Load(object sender, EventArgs e)
        {
            // hızlı bakış ekranı için anasayfada yükledik 
            if (fr14 == null || fr14.IsDisposed)
            {
                fr14 = new frmAnasayfa();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
        
        frmMusteriler fr2;
        private void btnMusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr2 == null || fr2.IsDisposed)// ürün yeniden yeniden açılmasın diye basit bir if 
            {
                fr2 = new frmMusteriler();
                fr2.MdiParent = this;// bu formun üzerinde mdi olarak açılsın
                fr2.Show();
            }

        }

       
        FrmFirmalar fr3;
        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr3==null || fr3.IsDisposed)
            {
                fr3 = new FrmFirmalar();// ürün yeniden yeniden açılmasın diye basit bir if 
                fr3.MdiParent = this;// bu formun üzerinde mdi olarak açılsın
                fr3.Show();
            }

        }
        frmPersonel fr4;
        private void btnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null || fr4.IsDisposed)// ürün yeniden yeniden açılmasın diye basit bir if 
            {
                fr4 = new frmPersonel();
                fr4.MdiParent = this;// bu formun üzerinde mdi olarak açılsın
                fr4.Show();
            }

        }
        frmRehber fr5;
        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null || fr5.IsDisposed)// ürün yeniden yeniden açılmaasın diye
            {
                fr5 = new frmRehber();
                fr5.MdiParent = this;// direkt formun mdiparenti olarak açılsın her seferinde farklı yazıyorum ama :D
                fr5.Show();
            }

        }
        FrmGiderler fr6;
        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr6 == null || fr6.IsDisposed)// fr6 boş ise aç formu değilse var ise aynı formdan açma
            {
                fr6 = new FrmGiderler();
                fr6.MdiParent = this;
                fr6.Show();

            }
            

        }
        FrmBankalar Fr7;
        private void btnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Fr7 == null || Fr7.IsDisposed)
            {
                Fr7 = new FrmBankalar();
                Fr7.MdiParent = this;// ana modülün parenti olarak açıl 
                Fr7.Show();
            }
        }

        FrmFaturalar Fr8;
        private void btnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Fr8 == null || Fr8.IsDisposed)
            {
                Fr8 = new FrmFaturalar();
                Fr8.MdiParent = this;
                Fr8.Show();
            }
        }

        frmNotlar fr9;
        private void btnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(fr9 == null || fr9.IsDisposed)
            {
                fr9 = new frmNotlar();
                fr9.MdiParent = this;
                fr9.Show();
                
            }
        }

        FrmHareketler fr10;
        private void BtnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr10 == null || fr10.IsDisposed)
            {
                fr10 = new FrmHareketler();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        frmStoklar fr11;
        private void btnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr11 == null || fr11.IsDisposed)
            {
                fr11 = new frmStoklar();
                fr11.MdiParent = this;
                fr11.Show();
            }

        }

        frmAyarlar fr12;
        private void ayarlarBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {     
                fr12 = new frmAyarlar();
                fr12.Show();     
        }


        frmKasa fr13;
        private void btnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null || fr13.IsDisposed)
            {
                fr13 = new frmKasa();
                fr13.ad = kullanici;
                fr13.MdiParent = this;
                fr13.Show();
            }
        }

        frmAnasayfa fr14;
        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(fr14 == null || fr14.IsDisposed)
            {
                fr14 = new frmAnasayfa();
                fr14.MdiParent = this;
                fr14.Show();
            }
        }
    }
}
