namespace USB_Port_Kontrol_V1._0
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btngirisyap = new DevExpress.XtraEditors.SimpleButton();
            this.txtkullanicisifre = new DevExpress.XtraEditors.TextEdit();
            this.txtkullaniciadi = new DevExpress.XtraEditors.TextEdit();
            this.lblkullaniciadi = new DevExpress.XtraEditors.LabelControl();
            this.lblsifre = new DevExpress.XtraEditors.LabelControl();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullanicisifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btngirisyap
            // 
            this.btngirisyap.Image = ((System.Drawing.Image)(resources.GetObject("btngirisyap.Image")));
            this.btngirisyap.Location = new System.Drawing.Point(280, 28);
            this.btngirisyap.Name = "btngirisyap";
            this.btngirisyap.Size = new System.Drawing.Size(89, 42);
            this.btngirisyap.TabIndex = 8;
            this.btngirisyap.Text = "Giriş Yap";
            this.btngirisyap.Click += new System.EventHandler(this.btngirisyap_Click);
            // 
            // txtkullanicisifre
            // 
            this.txtkullanicisifre.Location = new System.Drawing.Point(124, 98);
            this.txtkullanicisifre.Name = "txtkullanicisifre";
            this.txtkullanicisifre.Size = new System.Drawing.Size(143, 20);
            this.txtkullanicisifre.TabIndex = 7;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(124, 39);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(143, 20);
            this.txtkullaniciadi.TabIndex = 6;
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblkullaniciadi.Appearance.Options.UseFont = true;
            this.lblkullaniciadi.Location = new System.Drawing.Point(124, 17);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(85, 16);
            this.lblkullaniciadi.TabIndex = 9;
            this.lblkullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // lblsifre
            // 
            this.lblsifre.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblsifre.Appearance.Options.UseFont = true;
            this.lblsifre.Location = new System.Drawing.Point(124, 76);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(39, 16);
            this.lblsifre.TabIndex = 10;
            this.lblsifre.Text = "Şifre :";
            // 
            // btntemizle
            // 
            this.btntemizle.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.Image")));
            this.btntemizle.Location = new System.Drawing.Point(280, 76);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(89, 42);
            this.btntemizle.TabIndex = 11;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::USB_Port_Kontrol_V1._0.Properties.Resources.girisyap;
            this.pictureEdit1.Location = new System.Drawing.Point(13, 17);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(105, 101);
            this.pictureEdit1.TabIndex = 12;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 135);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblkullaniciadi);
            this.Controls.Add(this.btngirisyap);
            this.Controls.Add(this.txtkullanicisifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Name = "Giris";
            this.Text = "Giris Yap";
            ((System.ComponentModel.ISupportInitialize)(this.txtkullanicisifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btngirisyap;
        private DevExpress.XtraEditors.TextEdit txtkullanicisifre;
        private DevExpress.XtraEditors.TextEdit txtkullaniciadi;
        private DevExpress.XtraEditors.LabelControl lblkullaniciadi;
        private DevExpress.XtraEditors.LabelControl lblsifre;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}