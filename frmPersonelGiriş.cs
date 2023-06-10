using System;
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
    public partial class frmPersonelGiriş : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public frmPersonelGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select* from personeller where personelId=@personelıd and personelAd= @personelAd", bgl.baglanti());
            komut.Parameters.AddWithValue("personelId", textBox1.Text);
            komut.Parameters.AddWithValue("personelAd", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmpersonelDetay frm = new frmpersonelDetay();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.baglanti().Close();

        }

        private void frmPersonelGiriş_Load(object sender, EventArgs e)
        {

        }

     
    }
}
