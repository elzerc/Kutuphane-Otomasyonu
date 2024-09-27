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
    public partial class FormKitapIade : Form
    {
        private const string ConnectionString = "Data Source=Kutuphane.db;Version=3;";

        public FormKitapIade()
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

        private void txtKitapAdi_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnKitapIade_Click(object sender, EventArgs e)
        {

        }

        private void btnIade_Click(object sender, EventArgs e)
        {

            string kitapAdi = txtKitapAdi.Text;

            if (string.IsNullOrEmpty(kitapAdi))
            {
                MessageBox.Show("Lütfen bir kitap adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectQuery = "SELECT KitapId FROM Kitaplar WHERE KitapAdi = @KitapAdi";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand selectCommand = new SQLiteCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@KitapAdi", kitapAdi);

                    using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int kitapId = Convert.ToInt32(reader["KitapId"]);

                            string insertQuery = "INSERT INTO OduncKitaplar (KitapId, OduncAlmaTarihi, IadeTarihi) VALUES (@KitapId, @OduncAlmaTarihi, @IadeTarihi)";

                            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@KitapId", kitapId);
                                insertCommand.Parameters.AddWithValue("@OduncAlmaTarihi", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                                insertCommand.Parameters.AddWithValue("@IadeTarihi", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                                try
                                {
                                    insertCommand.ExecuteNonQuery();
                                    MessageBox.Show("Kitap başarıyla iade edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                            string updateQuery = "UPDATE Kitaplar SET KopyaSayisi = KopyaSayisi + 1 WHERE KitapId = @KitapId";

                            using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@KitapId", kitapId);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen isimde bir kitap bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            this.Close();


        }

        //private static void txtKitapId_TextChanged1(object sender, EventArgs e)
        //{

        //}


    }
}
