namespace KutuphaneOtomasyon
{
    partial class FormKitapOduncAl
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
            listBox1 = new ListBox();
            btnKitapOduncAl = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // FormKapat
            // 
            FormKapat.Location = new Point(40, 373);
            FormKapat.Name = "FormKapat";
            FormKapat.Size = new Size(106, 57);
            FormKapat.TabIndex = 0;
            FormKapat.Text = "Ana Sayfaya Dön";
            FormKapat.UseVisualStyleBackColor = true;
            FormKapat.Click += FormKapat_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(215, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(315, 284);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnKitapOduncAl
            // 
            btnKitapOduncAl.Location = new Point(548, 328);
            btnKitapOduncAl.Name = "btnKitapOduncAl";
            btnKitapOduncAl.Size = new Size(94, 29);
            btnKitapOduncAl.TabIndex = 2;
            btnKitapOduncAl.Text = "Ödünç Al";
            btnKitapOduncAl.UseVisualStyleBackColor = true;
            btnKitapOduncAl.Click += btnKitapOduncAl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 41);
            label1.Name = "label1";
            label1.Size = new Size(257, 20);
            label1.TabIndex = 3;
            label1.Text = "Ödünç almak istediğiniz kitabı seçiniz";
            // 
            // FormKitapOduncAl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.wallpapersden_com_custom_fractal_design_2560x1440;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnKitapOduncAl);
            Controls.Add(listBox1);
            Controls.Add(FormKapat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKitapOduncAl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKitapOduncAl";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FormKapat;
        private ListBox listBox1;
        private Button btnKitapOduncAl;
        private Label label1;
    }
}