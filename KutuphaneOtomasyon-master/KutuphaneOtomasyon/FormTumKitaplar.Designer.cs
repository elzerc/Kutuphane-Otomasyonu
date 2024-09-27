namespace KutuphaneOtomasyon
{
    partial class FormTumKitaplar
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
            lstTumKitaplar = new ListBox();
            SuspendLayout();
            // 
            // FormKapat
            // 
            FormKapat.Location = new Point(38, 380);
            FormKapat.Name = "FormKapat";
            FormKapat.Size = new Size(116, 58);
            FormKapat.TabIndex = 0;
            FormKapat.Text = "Ana Sayfaya Dön";
            FormKapat.UseVisualStyleBackColor = true;
            FormKapat.Click += FormKapat_Click;
            // 
            // lstTumKitaplar
            // 
            lstTumKitaplar.FormattingEnabled = true;
            lstTumKitaplar.ItemHeight = 20;
            lstTumKitaplar.Location = new Point(194, 42);
            lstTumKitaplar.Name = "lstTumKitaplar";
            lstTumKitaplar.Size = new Size(425, 324);
            lstTumKitaplar.TabIndex = 1;
            lstTumKitaplar.SelectedIndexChanged += lstTumKitaplar_SelectedIndexChanged;
            // 
            // FormTumKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpapersden_com_custom_fractal_design_2560x1440;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lstTumKitaplar);
            Controls.Add(FormKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTumKitaplar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTumKitaplar";
            ResumeLayout(false);
        }

        #endregion

        private Button FormKapat;
        private ListBox lstTumKitaplar;
    }
}