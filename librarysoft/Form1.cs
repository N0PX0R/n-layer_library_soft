using System;
using librarysoft.Bul;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Uye uyl = new Uye();
        kitap ktp = new kitap();

        private void btnKitaplar_Click(object sender, EventArgs e)
        {
            ktp.ShowDialog();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            uyl.ShowDialog();
        }

        private void btnOdunc_Click(object sender, EventArgs e)
        {
            Frmodunc frm = new Frmodunc()
            {
                Text = "Ödünç Verme",
                Odunc = new odunc()
                {
                    oduncID = Guid.NewGuid()
                }
            };


        tekrar:
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.OduncEkle(frm.Odunc);

                if (b)
                {

                    DataSet ds1 = Bul.Bul.oduncGetir();
                    if (ds1 != null)
                        dataGridView1.DataSource = ds1.Tables[0];
                }
                else
                    goto tekrar;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds1 = Bul.Bul.oduncGetir();
            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];
        }

        private void btnOduncduzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            Frmodunc frm = new Frmodunc()
            {
                Text = "Ödünç Güncelle",
                Güncelleme = true,
                Odunc = new odunc()
                {
                    oduncID = Guid.Parse(row.Cells[0].Value.ToString()),
                    uyeID = Guid.Parse(row.Cells[1].Value.ToString()),
                    kitapID = Guid.Parse(row.Cells[2].Value.ToString()),
                    aldigiTarih = DateTime.Parse(row.Cells[7].Value.ToString()),
                    verdigiTarih = DateTime.Parse(row.Cells[8].Value.ToString()),

                },
            };

            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.OduncGuncelle(frm.Odunc);

                if (b)
                {
                    row.Cells[1].Value = frm.Odunc.uyeID;
                    row.Cells[2].Value = frm.Odunc.kitapID;
                    row.Cells[7].Value = frm.Odunc.aldigiTarih;
                    row.Cells[8].Value = frm.Odunc.verdigiTarih;
                    
                }

            }
        }

        private void btnOduncsil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();


            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi onayla",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = Bul.Bul.OduncSil(ID);

                if (b)
                {

                    DataSet ds = Bul.Bul.oduncGetir();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
        }
    }
}
