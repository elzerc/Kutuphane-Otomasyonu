namespace KutuphaneOtomasyon
{
    partial class FormKitapEkle
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
            FormKapat = new Button();
            btnKitapEkle = new Button();
            txtKitapAdi = new TextBox();
            txtYazarAdi = new TextBox();
            txtKopyaSayisi = new TextBox();
            SuspendLayout();
            // 
            // FormKapat
            // 
            FormKapat.Location = new Point(50, 367);
            FormKapat.Name = "FormKapat";
            FormKapat.Size = new Size(108, 54);
            FormKapat.TabIndex = 0;
            FormKapat.Text = "Ana Sayfaya Dön";
            FormKapat.UseVisualStyleBackColor = true;
            FormKapat.Click += FormKapat_Click;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Location = new Point(513, 159);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(120, 53);
            btnKitapEkle.TabIndex = 1;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = true;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(164, 109);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.PlaceholderText = "Kitap Adı Giriniz";
            txtKitapAdi.Size = new Size(221, 27);
            txtKitapAdi.TabIndex = 2;
            // 
            // txtYazarAdi
            // 
            txtYazarAdi.Location = new Point(164, 172);
            txtYazarAdi.Name = "txtYazarAdi";
            txtYazarAdi.PlaceholderText = "Yazar Adı Giriniz";
            txtYazarAdi.Size = new Size(221, 27);
            txtYazarAdi.TabIndex = 3;
            // 
            // txtKopyaSayisi
            // 
            txtKopyaSayisi.Location = new Point(164, 234);
            txtKopyaSayisi.Name = "txtKopyaSayisi";
            txtKopyaSayisi.PlaceholderText = "Kaç Adet Ekleme Yapacaksınız";
            txtKopyaSayisi.Size = new Size(221, 27);
            txtKopyaSayisi.TabIndex = 4;
            // 
            // FormKitapEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpapersden_com_custom_fractal_design_2560x1440;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtKopyaSayisi);
            Controls.Add(txtYazarAdi);
            Controls.Add(txtKitapAdi);
            Controls.Add(btnKitapEkle);
            Controls.Add(FormKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKitapEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKitapEkle";
            Load += FormKitapEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FormKapat;
        private Button btnKitapEkle;
        private TextBox txtKitapAdi;
        private TextBox txtYazarAdi;
        private TextBox txtKopyaSayisi;
    }
}