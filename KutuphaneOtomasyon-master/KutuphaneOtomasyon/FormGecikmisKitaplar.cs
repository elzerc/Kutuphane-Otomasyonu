using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class FormGecikmisKitaplar : Form
    {
        public FormGecikmisKitaplar()
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
    }
}
