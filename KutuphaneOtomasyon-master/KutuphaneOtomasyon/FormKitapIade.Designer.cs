namespace KutuphaneOtomasyon
{
    partial class FormKitapIade
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
            txtKitapAdi = new TextBox();
            btnIade = new Button();
            SuspendLayout();
            // 
            // FormKapat
            // 
            FormKapat.Location = new Point(57, 384);
            FormKapat.Name = "FormKapat";
            FormKapat.Size = new Size(124, 54);
            FormKapat.TabIndex = 0;
            FormKapat.Text = "Ana Sayfaya Dön";
            FormKapat.UseVisualStyleBackColor = true;
            FormKapat.Click += FormKapat_Click;
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(129, 176);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.PlaceholderText = "İade etmek istediğiniz kitabın adını giriniz";
            txtKitapAdi.Size = new Size(307, 27);
            txtKitapAdi.TabIndex = 3;
            txtKitapAdi.TextChanged += txtKitapAdi_TextChanged;
            // 
            // btnIade
            // 
            btnIade.Location = new Point(489, 176);
            btnIade.Name = "btnIade";
            btnIade.Size = new Size(94, 29);
            btnIade.TabIndex = 4;
            btnIade.Text = "İade Et";
            btnIade.UseVisualStyleBackColor = true;
            btnIade.Click += btnIade_Click;
            // 
            // FormKitapIade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpapersden_com_custom_fractal_design_2560x1440;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIade);
            Controls.Add(txtKitapAdi);
            Controls.Add(FormKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKitapIade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKitapIade";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtKitapId_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button FormKapat;
        private TextBox txtKitapAdi;
        private Button btnIade;
    }
}