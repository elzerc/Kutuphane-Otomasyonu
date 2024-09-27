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
    public partial class GecikmisKitapForm : Form
    {
        private const string ConnectionString = "Data Source=Kutuphane.db;Version=3;";
        public GecikmisKitapForm()
        {
            InitializeComponent();
            GecikmisKitaplarıGetir();
        }
        private void GecikmisKitaplarıGetir()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                // SQL sorgusu - Gecikmiş kitapları getir
                string selectQuery = @"SELECT KitapAdi, OduncAlmaTarihi, IadeTarihi
                                       FROM OduncKitaplar
                                       WHERE IadeTarihi IS NULL AND DATE('now') > DATE(OduncAlmaTarihi, '+14 days')";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                string kitapAdi = reader["KitapAdi"].ToString();
                                DateTime oduncAlmaTarihi = Convert.ToDateTime(reader["OduncAlmaTarihi"]);

                                // ListBox'e yeni bir öğe ekleyerek gecikmiş kitapları göster
                                listBox1.Items.Add($"Kitap Adı: {kitapAdi}, Ödünç Alma Tarihi: {oduncAlmaTarihi.ToShortDateString()}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Gecikmiş kitap bulunmamaktadır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        public string GelenVeri { get; private set; }
        private void Formkapat_Click(object sender, EventArgs e)
        {

            GelenVeri = "Merhaba Ana Form!";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
