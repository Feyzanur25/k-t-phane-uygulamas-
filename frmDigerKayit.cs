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
    public partial class frmDigerKayit : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmDigerKayit()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDigerKayit frm = new frmDigerKayit();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO diger (Ad,Soyad, TCKimlikNo, telefon, sifre, cinsiyet) VALUES (@Ad, @Soyad, @TCKimlikNo, @telefon, @sifre, @cinsiyet)", bgl.baglanti());
            komut.Parameters.AddWithValue("@Ad", textBox1.Text);
            komut.Parameters.AddWithValue("@Soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@TCKimlikNo", textBox3.Text);
            komut.Parameters.AddWithValue("@telefon", textBox4.Text);
            komut.Parameters.AddWithValue("@sifre", textBox5.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kayıt işleminiz başarıyla gerçekleşti");
            this.Hide();
            frmDigerKayit frm = new frmDigerKayit();
            frm.Show(Owner);
        }
    }
}
