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
    public partial class kitap : Form
    {
        public kitap()
        {
            InitializeComponent();
        }
        public kitaplar ktp { get; set; }
        private void kitap_Load(object sender, EventArgs e)
        {
            DataSet ds2 = Bul.Bul.kitapGetir("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void btnkitapsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.KitapSil(ID);

                if (b)
                {

                    DataSet ds = Bul.Bul.kitapGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }

            }
        }

        private void btnkitapekle_Click(object sender, EventArgs e)
        {
            kitapfrm frm = new kitapfrm()
            {
                Text = "Kitap Ekle",
                ktp = new kitaplar() { kitapID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.KitapEkle(frm.ktp);

                if (b)
                {

                    DataSet ds = Bul.Bul.kitapGetir("");
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnkitapara_Click(object sender, EventArgs e)
        {
            DataSet ds = Bul.Bul.kitapGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            ktp = new kitaplar()
            {
                kitapID = Guid.Parse(row.Cells[0].Value.ToString()),
                kitapAd = row.Cells[1].Value.ToString(),
                kitapTur = row.Cells[2].Value.ToString(),
                kitapBasim = row.Cells[3].Value.ToString(),
                kitapYayin = row.Cells[4].Value.ToString(),
                kitapSayfa =int.Parse(row.Cells[5].Value.ToString())

            };

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
