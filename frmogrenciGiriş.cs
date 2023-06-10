﻿using System;
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
    public partial class frmogrenciGiriş : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmogrenciGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select* from ogrenciler where sifre=@sifre and ogrenciAd= @ogrenciAd", bgl.baglanti());
            komut.Parameters.AddWithValue("sifre", textBox1.Text);
            komut.Parameters.AddWithValue("ogrenciAd", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmogrenciDetay frm = new frmogrenciDetay();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.baglanti().Close();

        }
      

        private void frmOgrenciGiriş_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmOgrenciKayit frm = new frmOgrenciKayit();
            frm.Show();
            this.Hide();



        }
    }
}
