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
    public partial class Frmuye : Form
    {
        public Frmuye()
        {
            InitializeComponent();
        }
        public uyeler uye { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void Frmuye_Load(object sender, EventArgs e)
        {
            txtID.Text = uye.uyeID.ToString();
            if (Güncelleme)
            {
                txtAd.Text = uye.uyeAd;
                txtSoyad.Text = uye.uyeSoyad;
                txtTel.Text = uye.uyeTel;
                txtAdres.Text = uye.uyeAdres;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtAdres)) return;

            uye.uyeAd = txtAd.Text;
            uye.uyeSoyad = txtSoyad.Text;
            uye.uyeTel = txtTel.Text;
            uye.uyeAdres = txtAdres.Text;
            

            DialogResult = DialogResult.OK;
        }

        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
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

            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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
    }
}
