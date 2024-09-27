using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class FormKitapAra : Form
    {
        private const string ConnectionString = "Data Source=Kutuphane.db;Version=3;";




        public FormKitapAra()
        {
            InitializeComponent();
        }

        public string GelenVeri { get; internal set; }
        public string Sqlite { get; private set; }

        //public string ConnectionString { get; private set; }

        private void FormKapat_Click(object sender, EventArgs e)
        {
            GelenVeri = "Merhaba Ana Form!";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtAramaKelimesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    
                    string sql = "SELECT * FROM Kitaplar WHERE KitapAdi LIKE @AramaKelimesi";

                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        
                        command.Parameters.AddWithValue("@AramaKelimesi", "%" + txtAramaKelimesi.Text + "%");

                        
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            lstSonuclar.Items.Clear();

                            while (reader.Read())
                            {
                                string kitapAdi = reader["KitapAdi"].ToString();
                                string yazarAdi = reader["YazarAdi"].ToString();
                                int kopyaSayisi = Convert.ToInt32(reader["KopyaSayisi"]);

                                
                                lstSonuclar.Items.Add($"Kitap Adı: {kitapAdi}, Yazar: {yazarAdi}, Kitap Sayısı: {kopyaSayisi}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                MessageBox.Show($"Arama sırasında bir hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lstSonuclar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
