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


    public partial class FormKitapOduncAl : Form
    {
        private const string ConnectionString = "Data Source=Kutuphane.db;Version=3;";
        public FormKitapOduncAl()
        {
            InitializeComponent();
            KitaplariListele();
        }
        private void KitaplariListele()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Kitaplar";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        listBox1.Items.Clear();

                        while (reader.Read())
                        {
                            string kitapAdi = reader["KitapAdi"].ToString();
                            string yazarAdi = reader["YazarAdi"].ToString();
                            int kopyaSayisi = Convert.ToInt32(reader["KopyaSayisi"]);

                            listBox1.Items.Add($"Kitap Adı: {kitapAdi}, Yazar: {yazarAdi}, Kitap Sayısı: {kopyaSayisi}");
                        }
                    }
                }
            }
        }
        public string GelenVeri { get; private set; }
        public string ConnectionString1 { get; private set; }

        private void FormKapat_Click(object sender, EventArgs e)
        {
            GelenVeri = "Merhaba Ana Form!";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKitapOduncAl_Click(object sender, EventArgs e)
        {
            string seciliKitap = listBox1.SelectedItem.ToString();
            string[] kitapBilgileri = seciliKitap.Split(',');

            string kitapAdi = kitapBilgileri[0].Substring(kitapBilgileri[0].IndexOf(':') + 1).Trim();
            string yazarAdi = kitapBilgileri[1].Substring(kitapBilgileri[1].IndexOf(':') + 1).Trim();

           
            OduncAl(kitapAdi, yazarAdi);
        }
        private void OduncAl(string kitapAdi, string yazarAdi)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string sql = "UPDATE Kitaplar SET KopyaSayisi = KopyaSayisi - 1, AlisTarihi = @AlisTarihi WHERE KitapAdi = @KitapAdi AND YazarAdi = @YazarAdi";

                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@AlisTarihi", DateTime.Now);
                    command.Parameters.AddWithValue("@KitapAdi", kitapAdi);
                    command.Parameters.AddWithValue("@YazarAdi", yazarAdi);

                    
                    command.ExecuteNonQuery();

                    MessageBox.Show("Kitap başarıyla ödünç alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    KitaplariListele();
                }
            }
        }
    }
}
