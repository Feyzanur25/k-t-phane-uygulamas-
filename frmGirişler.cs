using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane_uygulaması
{
    public partial class frmGirişler : Form
    {
        public frmGirişler()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmPersonelGiriş frm = new frmPersonelGiriş();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmogrenciGiriş frm = new frmogrenciGiriş();
            frm.Show();
            this.Hide();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            frmDigerGiriş frm = new frmDigerGiriş();
            frm.Show();
            this.Hide();

        }

        private void frmGirişler_Load(object sender, EventArgs e)
        {

        }

       
    }
}
