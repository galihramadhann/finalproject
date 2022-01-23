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

namespace PENGARSIPAN
{
    public partial class menu_utama : Form
    {
        public menu_utama()
        {
            InitializeComponent();
        }

        SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-0EV4K4D6\SQLEXPRESS01;Initial Catalog=Pengarsipan;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            pengarsipan_masuk pm = new pengarsipan_masuk();
            pm.Show();
        }

        private void menu_utama_Load(object sender, EventArgs e)
        {

        }

        private void btnkeluar_Click(object sender, EventArgs e)
        {

            pengarsipan_keluar pk = new pengarsipan_keluar();
            pk.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("MANAWA SAMPEYAN PENGIN METU?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
