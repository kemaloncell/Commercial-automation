namespace TicariOtomasyon
{
    partial class FrmGiderler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiderler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.richNot = new System.Windows.Forms.RichTextBox();
            this.cmbyil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbAy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtelektirik = new DevExpress.XtraEditors.TextEdit();
            this.txtSu = new DevExpress.XtraEditors.TextEdit();
            this.txtExstra = new DevExpress.XtraEditors.TextEdit();
            this.txtMaas = new DevExpress.XtraEditors.TextEdit();
            this.txtinternet = new DevExpress.XtraEditors.TextEdit();
            this.txtGaz = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbyil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektirik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinternet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1381, 669);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.richNot);
            this.groupControl1.Controls.Add(this.cmbyil);
            this.groupControl1.Controls.Add(this.cmbAy);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtelektirik);
            this.groupControl1.Controls.Add(this.txtSu);
            this.groupControl1.Controls.Add(this.txtExstra);
            this.groupControl1.Controls.Add(this.txtMaas);
            this.groupControl1.Controls.Add(this.txtinternet);
            this.groupControl1.Controls.Add(this.txtGaz);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Location = new System.Drawing.Point(1388, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(541, 669);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "groupControl1";
            // 
            // richNot
            // 
            this.richNot.Location = new System.Drawing.Point(160, 413);
            this.richNot.Name = "richNot";
            this.richNot.Size = new System.Drawing.Size(244, 108);
            this.richNot.TabIndex = 11;
            this.richNot.Text = "";
            // 
            // cmbyil
            // 
            this.cmbyil.Location = new System.Drawing.Point(159, 106);
            this.cmbyil.Name = "cmbyil";
            this.cmbyil.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbyil.Properties.Appearance.Options.UseFont = true;
            this.cmbyil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbyil.Properties.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbyil.Size = new System.Drawing.Size(244, 36);
            this.cmbyil.TabIndex = 10;
            // 
            // cmbAy
            // 
            this.cmbAy.Location = new System.Drawing.Point(159, 63);
            this.cmbAy.Name = "cmbAy";
            this.cmbAy.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cmbAy.Properties.Appearance.Options.UseFont = true;
            this.cmbAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAy.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şuat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziraz",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAy.Size = new System.Drawing.Size(244, 36);
            this.cmbAy.TabIndex = 10;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(268, 597);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(244, 41);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Formu Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(268, 550);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(244, 41);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(8, 597);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(244, 41);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(8, 550);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(244, 41);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(86, 410);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(67, 27);
            this.labelControl10.TabIndex = 2;
            this.labelControl10.Text = "Notlar:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(4, 377);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(149, 27);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "Ekstra giderler:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(69, 330);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 27);
            this.labelControl8.TabIndex = 2;
            this.labelControl8.Text = "Maaşlar:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(67, 288);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 27);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "İnternet:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(55, 246);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(98, 27);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Doğalgaz:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(121, 204);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 27);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Su:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(69, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(84, 27);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Elektirik:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(122, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 27);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Yıl:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(121, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 27);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Ay:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(122, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 27);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "ID:";
            // 
            // txtelektirik
            // 
            this.txtelektirik.Location = new System.Drawing.Point(159, 153);
            this.txtelektirik.Name = "txtelektirik";
            this.txtelektirik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtelektirik.Properties.Appearance.Options.UseFont = true;
            this.txtelektirik.Size = new System.Drawing.Size(244, 36);
            this.txtelektirik.TabIndex = 0;
            // 
            // txtSu
            // 
            this.txtSu.Location = new System.Drawing.Point(159, 200);
            this.txtSu.Name = "txtSu";
            this.txtSu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSu.Properties.Appearance.Options.UseFont = true;
            this.txtSu.Size = new System.Drawing.Size(244, 36);
            this.txtSu.TabIndex = 0;
            // 
            // txtExstra
            // 
            this.txtExstra.Location = new System.Drawing.Point(160, 368);
            this.txtExstra.Name = "txtExstra";
            this.txtExstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExstra.Properties.Appearance.Options.UseFont = true;
            this.txtExstra.Size = new System.Drawing.Size(244, 36);
            this.txtExstra.TabIndex = 0;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(159, 326);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMaas.Properties.Appearance.Options.UseFont = true;
            this.txtMaas.Size = new System.Drawing.Size(244, 36);
            this.txtMaas.TabIndex = 0;
            // 
            // txtinternet
            // 
            this.txtinternet.Location = new System.Drawing.Point(159, 284);
            this.txtinternet.Name = "txtinternet";
            this.txtinternet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtinternet.Properties.Appearance.Options.UseFont = true;
            this.txtinternet.Size = new System.Drawing.Size(244, 36);
            this.txtinternet.TabIndex = 0;
            // 
            // txtGaz
            // 
            this.txtGaz.Location = new System.Drawing.Point(159, 242);
            this.txtGaz.Name = "txtGaz";
            this.txtGaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGaz.Properties.Appearance.Options.UseFont = true;
            this.txtGaz.Size = new System.Drawing.Size(244, 36);
            this.txtGaz.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(159, 16);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(244, 36);
            this.txtID.TabIndex = 0;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 944);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGiderler";
            this.Text = "GİDERLER";
            this.Load += new System.EventHandler(this.FrmGiderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbyil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtelektirik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtinternet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox richNot;
        private DevExpress.XtraEditors.ComboBoxEdit cmbyil;
        private DevExpress.XtraEditors.ComboBoxEdit cmbAy;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSu;
        private DevExpress.XtraEditors.TextEdit txtMaas;
        private DevExpress.XtraEditors.TextEdit txtGaz;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtelektirik;
        private DevExpress.XtraEditors.TextEdit txtExstra;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtinternet;
    }
}