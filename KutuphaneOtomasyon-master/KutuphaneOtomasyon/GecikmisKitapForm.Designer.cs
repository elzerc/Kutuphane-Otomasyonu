namespace KutuphaneOtomasyon
{
    partial class GecikmisKitapForm
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
            Formkapat = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // Formkapat
            // 
            Formkapat.Location = new Point(41, 364);
            Formkapat.Name = "Formkapat";
            Formkapat.Size = new Size(123, 58);
            Formkapat.TabIndex = 0;
            Formkapat.Text = "Ana Sayfaya Geri Dön";
            Formkapat.UseVisualStyleBackColor = true;
            Formkapat.Click += Formkapat_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(212, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(370, 284);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // GecikmisKitapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpapersden_com_custom_fractal_design_2560x1440;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(Formkapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GecikmisKitapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GecikmisKitapForm";
            ResumeLayout(false);
        }

        #endregion

        private Button Formkapat;
        private ListBox listBox1;
    }
}