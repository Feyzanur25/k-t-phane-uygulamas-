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
    public partial class frmpersonelDetay : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmpersonelDetay()
        {
            InitializeComponent();
        }

        private void frmpersonelDetay_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneGirisDataSet.kayitAl' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayitAlTableAdapter.Fill(this.kutuphaneGirisDataSet.kayitAl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO kayitAl (Ad, soyad, kitapadi, alisTarihi, teslimTarihi) VALUES (@Ad, @soyad, @kitapadi, @alisTarihi, @teslimTarihi)", bgl.baglanti());
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@kitapadi", textBox3.Text);

            if (DateTime.TryParse(textBox4.Text, out DateTime alisTarihi))
            {
                komut.Parameters.AddWithValue("@alisTarihi", alisTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz alış tarihi formatı!");
                return;
            }

            if (DateTime.TryParse(textBox5.Text, out DateTime teslimTarihi))
            {
                komut.Parameters.AddWithValue("@teslimTarihi", teslimTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz teslim tarihi formatı!");
                return;
            }

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti");
            this.Hide();
            frmogrenciDetay frm = new frmogrenciDetay();
            frm.Show(Owner);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM kayitAl WHERE Ad = @Ad AND soyad = @soyad AND kitapadi = @kitapadi AND alisTarihi = @alisTarihi AND teslimTarihi = @teslimTarihi", bgl.baglanti());
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@kitapadi", textBox3.Text);

            if (DateTime.TryParse(textBox4.Text, out DateTime alisTarihi))
            {
                komut.Parameters.AddWithValue("@alisTarihi", alisTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz alış tarihi formatı!");
                return;
            }

            if (DateTime.TryParse(textBox5.Text, out DateTime teslimTarihi))
            {
                komut.Parameters.AddWithValue("@teslimTarihi", teslimTarihi);
            }
            else
            {
                MessageBox.Show("Geçersiz teslim tarihi formatı!");
                return;
            }
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap sağlam bir şekilde teslim alındı");
            this.Hide();
            frmogrenciDetay frm = new frmogrenciDetay();
            frm.Show(Owner);
        }
    }
}
