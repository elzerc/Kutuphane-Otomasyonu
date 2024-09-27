using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KutuphaneOtomasyon
{
    public partial class FormKitapEkle : Form
    {
        private const string ConnectionString = "Data Source=Kutuphane.db;Version=3;";
        public FormKitapEkle()
        {
            InitializeComponent();
        }

        public string GelenVeri { get; private set; }
        private void FormKapat_Click(object sender, EventArgs e)
        {

            GelenVeri = "Merhaba Ana Form!";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void FormKitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            
            string kitapAdi = txtKitapAdi.Text;
            string yazarAdi = txtYazarAdi.Text;
            int kopyaSayisi;

            
            if (!int.TryParse(txtKopyaSayisi.Text, out kopyaSayisi))
            {
                MessageBox.Show("Geçerli bir kopya sayısı giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    try
                    {
                        string createTableSql = "CREATE TABLE IF NOT EXISTS Kitaplar (Id INTEGER PRIMARY KEY AUTOINCREMENT, KitapAdi TEXT, YazarAdi TEXT, KopyaSayisi INTEGER)";
                        command.CommandText = createTableSql;
                        command.ExecuteNonQuery();
                        string sql = "INSERT INTO Kitaplar (KitapAdi, YazarAdi, KopyaSayisi) VALUES (@KitapAdi, @YazarAdi, @KopyaSayisi)";
                        command.CommandText = sql;
                        command.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                        command.Parameters.AddWithValue("@YazarAdi", yazarAdi);
                        command.Parameters.AddWithValue("@KopyaSayisi", kopyaSayisi);

                        
                        command.ExecuteNonQuery();

                        MessageBox.Show("Kitap başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
