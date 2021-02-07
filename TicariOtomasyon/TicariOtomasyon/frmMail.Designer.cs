namespace TicariOtomasyon
{
    partial class frmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMail));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtkonu = new System.Windows.Forms.TextBox();
            this.richMesaj = new System.Windows.Forms.RichTextBox();
            this.gonder = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Konu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mesaj:";
            // 
            // txtmail
            // 
            this.txtmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Location = new System.Drawing.Point(116, 164);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(336, 35);
            this.txtmail.TabIndex = 1;
            // 
            // txtkonu
            // 
            this.txtkonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonu.Location = new System.Drawing.Point(116, 223);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Size = new System.Drawing.Size(336, 35);
            this.txtkonu.TabIndex = 1;
            // 
            // richMesaj
            // 
            this.richMesaj.Location = new System.Drawing.Point(116, 289);
            this.richMesaj.Name = "richMesaj";
            this.richMesaj.Size = new System.Drawing.Size(336, 186);
            this.richMesaj.TabIndex = 2;
            this.richMesaj.Text = "";
            // 
            // gonder
            // 
            this.gonder.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonder.Appearance.Options.UseFont = true;
            this.gonder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.gonder.Location = new System.Drawing.Point(116, 520);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(336, 74);
            this.gonder.TabIndex = 3;
            this.gonder.Text = "Gönder";
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TicariOtomasyon.Properties.Resources.mailbackgorund;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 139);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Stencil", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "MAIL GÖNDERME FORMU";
            // 
            // frmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.richMesaj);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMail";
            this.Load += new System.EventHandler(this.frmMail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtkonu;
        private System.Windows.Forms.RichTextBox richMesaj;
        private DevExpress.XtraEditors.SimpleButton gonder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}