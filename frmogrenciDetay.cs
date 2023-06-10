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
using System.Data.SqlClient;

namespace kütüphane_uygulaması
{
    public partial class frmogrenciDetay : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmogrenciDetay()
        {
            InitializeComponent();
        }

        private void frmOgrenciDetay_Load(object sender, EventArgs e)
        {
            frmGirişler frm = new frmGirişler();
            frm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("INSERT INTO kitaplar (kitapAdi, kitapTür, alişTarihi, verişTarihi) VALUES (@kitapAdi, @kitapTür, @alişTarihi, @verişTarihi)", bgl.baglanti());
            //komut.Parameters.AddWithValue("@kitapAdi", textBox1.Text);
            //komut.Parameters.AddWithValue("@kitapTür", comboBox1.Text);
            //komut.Parameters.AddWithValue("@alişTarihi", textBox3.Text);
            //komut.Parameters.AddWithValue("@verişTarihi", textBox4.Text);

            //komut.ExecuteNonQuery();
            //bgl.baglanti().Close();
            //MessageBox.Show("kayıt işleminiz başarıyla gerçekleşti");
            //this.Hide();
            //frmogrenciDetay frm = new frmogrenciDetay();
            //frm.Show(Owner);
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

        private void button3_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("UPDATE kitaplar SET kitapAdi = @kitapAdi, kitapTür = @kitapTür, alişTarihi = @alişTarihi, verişTarihi = @verişTarihi WHERE kitapAdi = @eskiKitapAdi AND kitapTür = @eskiKitapTür AND alişTarihi = @eskiAlişTarihi AND verişTarihi = @eskiVerişTarihi", bgl.baglanti());
            //komut.Parameters.AddWithValue("@kitapAdi", textBox1.Text);
            //komut.Parameters.AddWithValue("@kitapTür", comboBox1.Text);

            //if (DateTime.TryParse(textBox3.Text, out DateTime alişTarihi))
            //{
            //    komut.Parameters.AddWithValue("@alişTarihi", alişTarihi);
            //}
            //else
            //{
            //    MessageBox.Show("Geçersiz alişTarihi formatı!");
            //    return;
            //}

            //if (DateTime.TryParse(textBox4.Text, out DateTime verişTarihi))
            //{
            //    komut.Parameters.AddWithValue("@verişTarihi", verişTarihi);
            //}
            //else
            //{
            //    MessageBox.Show("Geçersiz verişTarihi formatı!");
            //    return;
            //}

            //// Önceki değerleri belirlemek için ek parametreler eklendi
            ////komut.Parameters.AddWithValue("@eskiKitapAdi", eskiKitapAdi);
            ////komut.Parameters.AddWithValue("@eskiKitapTür", eskiKitapTür);
            ////komut.Parameters.AddWithValue("@eskiAlişTarihi", eskiAlişTarihi);
            ////komut.Parameters.AddWithValue("@eskiVerişTarihi", eskiVerişTarihi);

            //komut.ExecuteNonQuery();
            //bgl.baglanti().Close();
            //MessageBox.Show("Kayıt başarıyla güncellendi");
            //this.Hide();
            //frmogrenciDetay frm = new frmogrenciDetay();
            //frm.Show(Owner);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
