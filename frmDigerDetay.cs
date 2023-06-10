using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_uygulaması
{
    public partial class frmDigerDetay : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmDigerDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO kitaplar (kitapAdi, kitapTür, alişTarihi, verişTarihi) VALUES (@kitapAdi, @kitapTür, @alişTarihi, @verişTarihi)", bgl.baglanti());
            komut.Parameters.AddWithValue("@kitapAdi", textBox1.Text);
            komut.Parameters.AddWithValue("@kitapTür", comboBox1.Text);

            if (DateTime.TryParse(textBox3.Text, out DateTime alişTarihi))
            {
                komut.Parameters.AddWithValue("@alişTarihi", alişTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz alişTarihi formatı!");
                return;
            }

            if (DateTime.TryParse(textBox4.Text, out DateTime verişTarihi))
            {
                komut.Parameters.AddWithValue("@verişTarihi", verişTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz verişTarihi formatı!");
                return;
            }

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kayıt işleminiz başarıyla gerçekleşti");
            this.Hide();
            frmogrenciDetay frm = new frmogrenciDetay();
            frm.Show(Owner);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM kitaplar WHERE kitapAdi = @kitapAdi AND kitapTür = @kitapTür AND alişTarihi = @alişTarihi AND verişTarihi = @verişTarihi", bgl.baglanti());
            komut.Parameters.AddWithValue("@kitapAdi", textBox1.Text);
            komut.Parameters.AddWithValue("@kitapTür", comboBox1.Text);

            if (DateTime.TryParse(textBox3.Text, out DateTime alişTarihi))
            {
                komut.Parameters.AddWithValue("@alişTarihi", alişTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz alişTarihi formatı!");
                return;
            }

            if (DateTime.TryParse(textBox4.Text, out DateTime verişTarihi))
            {
                komut.Parameters.AddWithValue("@verişTarihi", verişTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz verişTarihi formatı!");
                return;
            }

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt başarıyla silindi");
            this.Hide();
            frmogrenciDetay frm = new frmogrenciDetay();
            frm.Show(Owner);
        }
    }
}
