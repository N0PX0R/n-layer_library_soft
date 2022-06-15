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
    public partial class Frmodunc : Form
    {
        public odunc Odunc { get; set; }
        public bool Güncelleme { get; set; } = false;

        public Frmodunc()
        {
            InitializeComponent();
        }

        private void Frmodunc_Load(object sender, EventArgs e)
        {
            
            txtoduncid.Text = Odunc.oduncID.ToString();
            if (Güncelleme)
            {
                txtuyeid.Text = Odunc.uyeID.ToString();
                txtkitapid.Text = Odunc.kitapID.ToString();
                dtAldigi.Value = Odunc.aldigiTarih;
                dtverdigi.Value = Odunc.verdigiTarih;
            }
        }

        private void uyesec_Click(object sender, EventArgs e)
        {
            Uye frm = new Uye();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtuyeid.Text = frm.Uyeler.uyeID.ToString();
            }
        }

        private void kitapsec_Click(object sender, EventArgs e)
        {
            kitap frm = new kitap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtkitapid.Text = frm.ktp.kitapID.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Odunc.aldigiTarih = dtAldigi.Value;
            Odunc.verdigiTarih = dtverdigi.Value;
            Odunc.kitapID = Guid.Parse(txtkitapid.Text);
            Odunc.uyeID = Guid.Parse(txtuyeid.Text);
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
