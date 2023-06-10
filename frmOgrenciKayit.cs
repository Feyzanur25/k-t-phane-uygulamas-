﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kütüphane_uygulaması
{
    public partial class frmOgrenciKayit : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmOgrenciKayit()
        {
            InitializeComponent();
        }
        private void frmOgrenciKayit_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO ogrenciler (ogrenciAd, ogrenciSoyad, TCKimlikNo, telefon, sifre, cinsiyet) VALUES (@ogrenciAd, @ogrenciSoyad, @TCKimlikNo, @telefon, @sifre, @cinsiyet)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ogrenciAd", textBox1.Text);
            komut.Parameters.AddWithValue("@ogrenciSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("@TCKimlikNo", textBox3.Text);
            komut.Parameters.AddWithValue("@telefon", textBox4.Text);
            komut.Parameters.AddWithValue("@sifre", textBox5.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboBox1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kayıt işleminiz başarıyla gerçekleşti");
            this.Hide();
            frmOgrenciKayit frm = new frmOgrenciKayit();
            frm.Show(Owner);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
