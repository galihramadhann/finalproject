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
    public partial class pengarsipan_keluar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-0EV4K4D6\SQLEXPRESS01;Initial Catalog=Pengarsipan;Integrated Security=True");

        public pengarsipan_keluar()
        {
            InitializeComponent();
        }

        string tglwkt;
        string jns;


        private void pengarsipan_keluar_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into pengarsipan values('" + txtid.Text + "', '" + txtkode.Text + "', '"
                + txtnosurat.Text + "', '" + dtptgl.Text + "','" + txtpengirim.Text + "', '" + txtperihal.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtkode.Text = "";
            txtnosurat.Text = "";
            dtptgl.Text = "";
            txtpengirim.Text = "";
            txtperihal.Text = "";
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maindisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maindisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow pilih = maindisplay.Rows[index];
            txtid.Text = pilih.Cells[0].Value.ToString();
            txtkode.Text = pilih.Cells[1].Value.ToString();
            txtnosurat.Text = pilih.Cells[2].Value.ToString();
            dtptgl.Text = pilih.Cells[3].Value.ToString();
            txtpengirim.Text = pilih.Cells[4].Value.ToString();
            txtperihal.Text = pilih.Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into pengarsipan values('" + txtid.Text + "', '" + txtkode.Text + "', '"
                + txtnosurat.Text + "', '" + dtptgl.Text + "','" + txtpengirim.Text + "', '" + txtperihal.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtkode.Text = "";
            txtnosurat.Text = "";
            dtptgl.Text = "";
            txtpengirim.Text = "";
            txtperihal.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime jam = DateTime.Now;
            this.mainlbwktu.Text = jam.ToString();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from pengarsipan";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            maindisplay.DataSource = dt;
            con.Close();
        }

        private void mainlbwktu_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
