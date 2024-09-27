namespace KutuphaneOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnKitapEkle = new Button();
            btnKitapAra = new Button();
            btnTumKitaplar = new Button();
            btnKitapOduncAl = new Button();
            btnKitapIadeEt = new Button();
            GecikmisKitap = new Button();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.BackColor = Color.Transparent;
            btnKitapEkle.BackgroundImageLayout = ImageLayout.None;
            btnKitapEkle.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKitapEkle.ForeColor = Color.Black;
            btnKitapEkle.Location = new Point(144, 167);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(163, 71);
            btnKitapEkle.TabIndex = 0;
            btnKitapEkle.Text = "Kitap Ekle ";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // btnKitapAra
            // 
            btnKitapAra.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKitapAra.Location = new Point(326, 167);
            btnKitapAra.Name = "btnKitapAra";
            btnKitapAra.Size = new Size(154, 71);
            btnKitapAra.TabIndex = 1;
            btnKitapAra.Text = "Kitap Ara";
            btnKitapAra.UseVisualStyleBackColor = true;
            btnKitapAra.Click += button2_Click;
            // 
            // btnTumKitaplar
            // 
            btnTumKitaplar.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTumKitaplar.Location = new Point(509, 167);
            btnTumKitaplar.Name = "btnTumKitaplar";
            btnTumKitaplar.Size = new Size(154, 71);
            btnTumKitaplar.TabIndex = 2;
            btnTumKitaplar.Text = "Tüm Kitapları Listele";
            btnTumKitaplar.UseVisualStyleBackColor = true;
            btnTumKitaplar.Click += btnTumKitaplar_Click;
            // 
            // btnKitapOduncAl
            // 
            btnKitapOduncAl.BackColor = Color.Transparent;
            btnKitapOduncAl.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKitapOduncAl.Location = new Point(144, 254);
            btnKitapOduncAl.Name = "btnKitapOduncAl";
            btnKitapOduncAl.Size = new Size(163, 71);
            btnKitapOduncAl.TabIndex = 3;
            btnKitapOduncAl.Text = "Kitap Ödünç Al";
            btnKitapOduncAl.UseVisualStyleBackColor = false;
            btnKitapOduncAl.Click += btnKitapOduncAl_Click;
            // 
            // btnKitapIadeEt
            // 
            btnKitapIadeEt.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnKitapIadeEt.Location = new Point(326, 254);
            btnKitapIadeEt.Name = "btnKitapIadeEt";
            btnKitapIadeEt.Size = new Size(154, 71);
            btnKitapIadeEt.TabIndex = 4;
            btnKitapIadeEt.Text = "Kitap İade Et";
            btnKitapIadeEt.UseVisualStyleBackColor = true;
            btnKitapIadeEt.Click += btnKitapIadeEt_Click;
            // 
            // GecikmisKitap
            // 
            GecikmisKitap.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GecikmisKitap.Location = new Point(509, 254);
            GecikmisKitap.Name = "GecikmisKitap";
            GecikmisKitap.Size = new Size(154, 71);
            GecikmisKitap.TabIndex = 7;
            GecikmisKitap.Text = "Gecikmiş Kitapları Listele";
            GecikmisKitap.UseVisualStyleBackColor = true;
            GecikmisKitap.Click += GecikmisKitap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(270, 114);
            label2.Name = "label2";
            label2.Size = new Size(258, 17);
            label2.TabIndex = 9;
            label2.Text = "Lütfen Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Handwriting", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(150, 43);
            label3.Name = "label3";
            label3.Size = new Size(513, 36);
            label3.TabIndex = 10;
            label3.Text = "KÜTÜPHANEMİZE HOŞGELDİNİZ";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 390);
            button1.Name = "button1";
            button1.Size = new Size(105, 48);
            button1.TabIndex = 11;
            button1.Text = "Uygulamayı Kapat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(GecikmisKitap);
            Controls.Add(btnKitapIadeEt);
            Controls.Add(btnKitapOduncAl);
            Controls.Add(btnTumKitaplar);
            Controls.Add(btnKitapAra);
            Controls.Add(btnKitapEkle);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane";
            ResumeLayout(false);
            PerformLayout();
        }

        //private void btnGecikmisKitaplar_Click(object sender, EventArgs e)
        //{
        //    //throw new NotImplementedException();
        //}

        #endregion

        private Button btnKitapEkle;
        private Button btnKitapAra;
        private Button btnTumKitaplar;
        private Button btnKitapOduncAl;
        private Button btnKitapIadeEt;
        private Button GecikmisKitap;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}