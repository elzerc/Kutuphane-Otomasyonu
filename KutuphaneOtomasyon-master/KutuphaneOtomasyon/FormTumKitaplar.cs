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
    public partial class FormTumKitaplar : Form
    {
        private const string ConnectionString = "Data Source=Kutuphane.db;Version=3;";
        public FormTumKitaplar()
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
                        lstTumKitaplar.Items.Clear();

                        while (reader.Read())
                        {
                            string kitapAdi = reader["KitapAdi"].ToString();
                            string yazarAdi = reader["YazarAdi"].ToString();
                            int kopyaSayisi = Convert.ToInt32(reader["KopyaSayisi"]);

                            
                            lstTumKitaplar.Items.Add($"Kitap Adı: {kitapAdi}, Yazar: {yazarAdi}, Kitap Sayısı: {kopyaSayisi}");
                        }
                    }
                }
            }
        }
        public string GelenVeri { get; private set; }
        private void FormKapat_Click(object sender, EventArgs e)
        {
            GelenVeri = "Merhaba Ana Form!";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lstTumKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
