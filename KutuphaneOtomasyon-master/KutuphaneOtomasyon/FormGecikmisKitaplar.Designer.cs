namespace KutuphaneOtomasyon
{
    partial class FormGecikmisKitaplar
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
            SuspendLayout();
            // 
            // FormKapat
            // 
            FormKapat.Location = new Point(94, 370);
            FormKapat.Name = "FormKapat";
            FormKapat.Size = new Size(94, 29);
            FormKapat.TabIndex = 0;
            FormKapat.Text = "button1";
            FormKapat.UseVisualStyleBackColor = true;
            FormKapat.Click += FormKapat_Click;
            // 
            // FormGecikmisKitaplar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FormKapat);
            Name = "FormGecikmisKitaplar";
            Text = "FormGecikmisKitaplar";
            ResumeLayout(false);
        }

        #endregion

        private Button FormKapat;
    }
}