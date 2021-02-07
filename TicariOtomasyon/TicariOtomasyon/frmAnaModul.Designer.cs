namespace TicariOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.btnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.btnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ayarlarBtn = new DevExpress.XtraBars.BarButtonItem();
            this.BtnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.btnRaporlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonMiniToolbar2 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonMiniToolbar3 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonMiniToolbar4 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonMiniToolbar5 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.applicationMenu2 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.applicationMenu3 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnUrunler,
            this.btnStoklar,
            this.btnMusteriler,
            this.btnFirmalar,
            this.btnAnasayfa,
            this.btnPersoneller,
            this.btnGiderler,
            this.btnKasa,
            this.btnNotlar,
            this.btnBankalar,
            this.btnRehber,
            this.btnFaturalar,
            this.btnAyarlar,
            this.barButtonItem1,
            this.barButtonItem2,
            this.ayarlarBtn,
            this.BtnHareketler,
            this.btnRaporlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar2);
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar3);
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar4);
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar5);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.Size = new System.Drawing.Size(1834, 202);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Caption = "ÜRÜNLER";
            this.btnUrunler.Id = 1;
            this.btnUrunler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUrunler.ImageOptions.SvgImage")));
            this.btnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunler_ItemClick);
            // 
            // btnStoklar
            // 
            this.btnStoklar.Caption = "STOKLAR";
            this.btnStoklar.Id = 2;
            this.btnStoklar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStoklar.ImageOptions.SvgImage")));
            this.btnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnStoklar.Name = "btnStoklar";
            this.btnStoklar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnStoklar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStoklar_ItemClick);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Caption = "MÜŞTERİLER";
            this.btnMusteriler.Id = 3;
            this.btnMusteriler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMusteriler.ImageOptions.SvgImage")));
            this.btnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnMusteriler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriler_ItemClick);
            // 
            // btnFirmalar
            // 
            this.btnFirmalar.Caption = "FİRMALAR";
            this.btnFirmalar.Id = 4;
            this.btnFirmalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFirmalar.ImageOptions.SvgImage")));
            this.btnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFirmalar.Name = "btnFirmalar";
            this.btnFirmalar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnFirmalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFirmalar_ItemClick);
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Caption = "ANASAYFA";
            this.btnAnasayfa.Id = 5;
            this.btnAnasayfa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAnasayfa.ImageOptions.SvgImage")));
            this.btnAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAnasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAnasayfa_ItemClick);
            // 
            // btnPersoneller
            // 
            this.btnPersoneller.Caption = "PERSONELLER";
            this.btnPersoneller.Id = 6;
            this.btnPersoneller.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPersoneller.ImageOptions.SvgImage")));
            this.btnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.btnPersoneller.Name = "btnPersoneller";
            this.btnPersoneller.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPersoneller_ItemClick);
            // 
            // btnGiderler
            // 
            this.btnGiderler.Caption = "GİDERLER";
            this.btnGiderler.Id = 7;
            this.btnGiderler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiderler.ImageOptions.SvgImage")));
            this.btnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnGiderler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGiderler_ItemClick);
            // 
            // btnKasa
            // 
            this.btnKasa.Caption = "KASA";
            this.btnKasa.Id = 8;
            this.btnKasa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKasa.ImageOptions.SvgImage")));
            this.btnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnKasa.Name = "btnKasa";
            this.btnKasa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnKasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasa_ItemClick);
            // 
            // btnNotlar
            // 
            this.btnNotlar.Caption = "NOTLAR";
            this.btnNotlar.Id = 9;
            this.btnNotlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNotlar.ImageOptions.SvgImage")));
            this.btnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNotlar_ItemClick);
            // 
            // btnBankalar
            // 
            this.btnBankalar.Caption = "BANKALAR";
            this.btnBankalar.Id = 10;
            this.btnBankalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBankalar.ImageOptions.SvgImage")));
            this.btnBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBankalar_ItemClick);
            // 
            // btnRehber
            // 
            this.btnRehber.Caption = "REHBER";
            this.btnRehber.Id = 11;
            this.btnRehber.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRehber.ImageOptions.SvgImage")));
            this.btnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRehber_ItemClick);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.Caption = "FATURALAR";
            this.btnFaturalar.Id = 12;
            this.btnFaturalar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFaturalar.ImageOptions.SvgImage")));
            this.btnFaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFaturalar_ItemClick);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "AYARLAR";
            this.btnAyarlar.Id = 13;
            this.btnAyarlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAyarlar.ImageOptions.SvgImage")));
            this.btnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnAyarlar.Name = "btnAyarlar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ayarlar";
            this.barButtonItem1.Id = 14;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Ayarlar";
            this.barButtonItem2.Id = 15;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // ayarlarBtn
            // 
            this.ayarlarBtn.Caption = "AYARLAR";
            this.ayarlarBtn.Id = 16;
            this.ayarlarBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarBtn.ImageOptions.Image")));
            this.ayarlarBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("ayarlarBtn.ImageOptions.LargeImage")));
            this.ayarlarBtn.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ayarlarBtn.ItemAppearance.Normal.Options.UseFont = true;
            this.ayarlarBtn.Name = "ayarlarBtn";
            this.ayarlarBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ayarlarBtn_ItemClick);
            // 
            // BtnHareketler
            // 
            this.BtnHareketler.Caption = "HARAKETLER";
            this.BtnHareketler.Id = 17;
            this.BtnHareketler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnHareketler.ImageOptions.Image")));
            this.BtnHareketler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnHareketler.ImageOptions.LargeImage")));
            this.BtnHareketler.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHareketler.ItemAppearance.Hovered.Options.UseFont = true;
            this.BtnHareketler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHareketler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnHareketler.Name = "BtnHareketler";
            this.BtnHareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnHareketler_ItemClick);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Caption = "RAPORLAR";
            this.btnRaporlar.Id = 18;
            this.btnRaporlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.ImageOptions.Image")));
            this.btnRaporlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRaporlar.ImageOptions.LargeImage")));
            this.btnRaporlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnRaporlar.Name = "btnRaporlar";
            // 
            // ribbonMiniToolbar1
            // 
            this.ribbonMiniToolbar1.ParentControl = this;
            // 
            // ribbonMiniToolbar2
            // 
            this.ribbonMiniToolbar2.ParentControl = this;
            // 
            // ribbonMiniToolbar3
            // 
            this.ribbonMiniToolbar3.ParentControl = this;
            // 
            // ribbonMiniToolbar4
            // 
            this.ribbonMiniToolbar4.ParentControl = this;
            // 
            // ribbonMiniToolbar5
            // 
            this.ribbonMiniToolbar5.ParentControl = this;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ticari Otomasyon Sistemi";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnHareketler);
            this.ribbonPageGroup1.ItemLinks.Add(this.ayarlarBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // applicationMenu2
            // 
            this.applicationMenu2.Name = "applicationMenu2";
            this.applicationMenu2.Ribbon = this.ribbonControl1;
            // 
            // applicationMenu3
            // 
            this.applicationMenu3.Name = "applicationMenu3";
            this.applicationMenu3.Ribbon = this.ribbonControl1;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1834, 812);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anamodül";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnUrunler;
        private DevExpress.XtraBars.BarButtonItem btnStoklar;
        private DevExpress.XtraBars.BarButtonItem btnMusteriler;
        private DevExpress.XtraBars.BarButtonItem btnFirmalar;
        private DevExpress.XtraBars.BarButtonItem btnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem btnPersoneller;
        private DevExpress.XtraBars.BarButtonItem btnGiderler;
        private DevExpress.XtraBars.BarButtonItem btnKasa;
        private DevExpress.XtraBars.BarButtonItem btnNotlar;
        private DevExpress.XtraBars.BarButtonItem btnBankalar;
        private DevExpress.XtraBars.BarButtonItem btnRehber;
        private DevExpress.XtraBars.BarButtonItem btnFaturalar;
        private DevExpress.XtraBars.BarButtonItem btnAyarlar;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar2;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar3;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar4;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar5;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu2;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem ayarlarBtn;
        private DevExpress.XtraBars.BarButtonItem BtnHareketler;
        private DevExpress.XtraBars.BarButtonItem btnRaporlar;
    }
}

