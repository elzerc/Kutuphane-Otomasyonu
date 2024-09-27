namespace KutuphaneOtomasyon
{
    partial class FormKitapAra
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
            txtAramaKelimesi = new TextBox();
            lstSonuclar = new ListBox();
            btnAra = new Button();
            SuspendLayout();
            // 
            // FormKapat
            // 
            FormKapat.Location = new Point(34, 373);
            FormKapat.Name = "FormKapat";
            FormKapat.Size = new Size(119, 52);
            FormKapat.TabIndex = 0;
            FormKapat.Text = "Ana Sayfaya Dön";
            FormKapat.UseVisualStyleBackColor = true;
            FormKapat.Click += FormKapat_Click;
            // 
            // txtAramaKelimesi
            // 
            txtAramaKelimesi.Location = new Point(34, 62);
            txtAramaKelimesi.Name = "txtAramaKelimesi";
            txtAramaKelimesi.PlaceholderText = "Aramak istediğiniz kitap adını ya da yazarı giriniz";
            txtAramaKelimesi.Size = new Size(350, 27);
            txtAramaKelimesi.TabIndex = 1;
            txtAramaKelimesi.TextChanged += txtAramaKelimesi_TextChanged;
            // 
            // lstSonuclar
            // 
            lstSonuclar.BackColor = Color.White;
            lstSonuclar.FormattingEnabled = true;
            lstSonuclar.ItemHeight = 20;
            lstSonuclar.Location = new Point(413, 35);
            lstSonuclar.Name = "lstSonuclar";
            lstSonuclar.Size = new Size(321, 344);
            lstSonuclar.TabIndex = 2;
            lstSonuclar.SelectedIndexChanged += lstSonuclar_SelectedIndexChanged;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(277, 112);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // FormKitapAra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpapersden_com_custom_fractal_design_2560x1440;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAra);
            Controls.Add(lstSonuclar);
            Controls.Add(txtAramaKelimesi);
            Controls.Add(FormKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKitapAra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKitapAra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FormKapat;
        private TextBox txtAramaKelimesi;
        private ListBox lstSonuclar;
        private Button btnAra;
    }
}