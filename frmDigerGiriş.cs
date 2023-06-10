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
    public partial class frmDigerGiriş : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmDigerGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select* from diger where Id=@Id and Ad= @Ad", bgl.baglanti());
            komut.Parameters.AddWithValue("Id", textBox1.Text);
            komut.Parameters.AddWithValue("Ad", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmDigerDetay frm = new frmDigerDetay();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDigerKayit frm = new frmDigerKayit();
            frm.Show();
            this.Hide();

        }
    }
}
