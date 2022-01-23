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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=LAPTOP-0EV4K4D6\SQLEXPRESS01;Initial Catalog=Pengarsipan;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select * from admin where userid = '" +txtuser.Text+ "' and password = '" +txtpw.Text+ "'", koneksi);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);

            koneksi.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "admin");

            koneksi.Close();

            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            if (count == 1)
            {
                this.Hide();
                menu_utama panggil = new menu_utama();
                panggil.Show();
            }
            else
            {
                MessageBox.Show("Mohon isi user name dan password dengan benar !!!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        }
    }

