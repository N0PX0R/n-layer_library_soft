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
    public partial class Uye : Form
    {
        public Uye()
        {
            InitializeComponent();
        }

        private void btnuyekle_Click(object sender, EventArgs e)
        {
            Frmuye frmuye = new Frmuye()
            {
                Text = "Uye Ekle",
                uye = new uyeler() { uyeID = Guid.NewGuid() },
            };

        tekrar:
            var sonuc = frmuye.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.UyeEkle(frmuye.uye);

                if (b)
                {

                    DataSet ds = Bul.Bul.uyeGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void btnuyeduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Frmuye frmuye = new Frmuye()
            {
                Text = "Uye Güncelle",
                Güncelleme = true,
                uye = new uyeler()
                {
                    uyeID = Guid.Parse(row.Cells[0].Value.ToString()),
                    uyeAd = row.Cells[1].Value.ToString(),
                    uyeSoyad = row.Cells[2].Value.ToString(),
                    uyeTel = row.Cells[3].Value.ToString(),
                    uyeAdres = row.Cells[4].Value.ToString()
                },
            };

            var sonuc = frmuye.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.UyeGuncelle(frmuye.uye);

                if (b)
                {
                    row.Cells[1].Value = frmuye.uye.uyeAd;
                    row.Cells[2].Value = frmuye.uye.uyeSoyad;
                    row.Cells[3].Value = frmuye.uye.uyeTel;
                    row.Cells[4].Value = frmuye.uye.uyeAdres;
                }

            }
        }

        private void btnuyesil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.UyeSil(ID);

                if (b)
                {

                    DataSet ds = Bul.Bul.uyeGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }
        public uyeler Uyeler { get; set; }
        private void Uye_Load(object sender, EventArgs e)
        {
            DataSet ds1 = Bul.Bul.uyeGetir("");
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];


            Uyeler = new uyeler()
            {
                uyeID = Guid.Parse(row.Cells[0].Value.ToString()),
                uyeAd = row.Cells[1].Value.ToString(),
                uyeSoyad = row.Cells[2].Value.ToString(),
                uyeTel = row.Cells[3].Value.ToString(),
                uyeAdres = row.Cells[4].Value.ToString(),

            };


            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataSet ds = Bul.Bul.uyeGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
