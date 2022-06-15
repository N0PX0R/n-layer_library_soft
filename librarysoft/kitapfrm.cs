using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarysoft
{
    public partial class kitapfrm : Form
    {
        public kitapfrm()
        {
            InitializeComponent();
        }
        public kitaplar ktp { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void kitapfrm_Load(object sender, EventArgs e)
        {
            txtID.Text = ktp.kitapID.ToString();
            if (Güncelleme)
            {
                txtKitapad.Text = ktp.kitapAd;
                txtKitaptur.Text = ktp.kitapTur;
                txtKitapbasim.Text = ktp.kitapBasim;
                txtKitapyayin.Text = ktp.kitapYayin;
                txtSayfasayi.Text = ktp.kitapSayfa.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtKitapad)) return;
            if (!ErrorControl(txtKitaptur)) return;
            if (!ErrorControl(txtKitapbasim)) return;
            if (!ErrorControl(txtKitapyayin)) return;
            if (!ErrorControl(txtSayfasayi)) return;
            

            ktp.kitapAd = txtKitapad.Text;
            ktp.kitapTur = txtKitaptur.Text;
            ktp.kitapBasim = txtKitapbasim.Text;
            ktp.kitapYayin = txtKitapyayin.Text;
            ktp.kitapSayfa = int.Parse(txtSayfasayi.Text);
            


            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                    return true;

                }
            }
            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
