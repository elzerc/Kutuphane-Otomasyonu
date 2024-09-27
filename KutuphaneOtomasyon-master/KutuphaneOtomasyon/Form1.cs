using System.Globalization;
using System.Data.SQLite;

namespace KutuphaneOtomasyon

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //this.FormClosing += Form1_FormClosing;
        }

        //    private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        //    {
        //        throw new NotImplementedException();
        //        e.Cancel = true; // Form kapatýlmasýný engelle
        //        this.Hide();     // Formu gizle

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            FormKitapAra formKitapAra = new FormKitapAra();
            formKitapAra.ShowDialog();

            string gelenVeri = formKitapAra.GelenVeri;
            //this.Hide(); // Ana formu gizle
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {


            //btnKitapEkle.BackColor = Color.Transparent;


            FormKitapEkle formKitapEkle = new FormKitapEkle();
            formKitapEkle.ShowDialog();

            string gelenVeri = formKitapEkle.GelenVeri;


        }

        private void btnTumKitaplar_Click(object sender, EventArgs e)
        {
            FormTumKitaplar formTumKitaplar = new FormTumKitaplar();
            formTumKitaplar.ShowDialog();
            string gelenVeri = formTumKitaplar.GelenVeri;
            //this.Hide(); // Ana formu gizle
        }

        private void btnKitapOduncAl_Click(object sender, EventArgs e)
        {
            FormKitapOduncAl formKitapOduncAl = new FormKitapOduncAl();
            formKitapOduncAl.ShowDialog();

            string gelenVeri = formKitapOduncAl.GelenVeri;
            //this.Hide(); // Ana formu gizle
        }

        private void btnKitapIadeEt_Click(object sender, EventArgs e)
        {
            FormKitapIade formKitapIade = new FormKitapIade();
            formKitapIade.ShowDialog();

            string gelenVeri = formKitapIade.GelenVeri;


            //this.Hide(); // Ana formu gizle


        }
        private void GecikmisKitap_Click(object sender, EventArgs e)
        {
            GecikmisKitapForm gecikmisKitapForm = new GecikmisKitapForm();
            gecikmisKitapForm.ShowDialog();

            string gelenVeri = gecikmisKitapForm.GelenVeri;
        }

        //private void btnGecikmisKitaplar_Click(object sender, EventArgs e, string gelenVeri)
        //{
        //    FormGecikmisKitaplar formGecikmisKitaplar = new FormGecikmisKitaplar();
        //    formGecikmisKitaplar.ShowDialog();


        //    string gelenVeri2 = formGecikmisKitaplar.GelenVeri;
        //    //this.Hide(); // Ana formu gizle

        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            

        }
    }
}