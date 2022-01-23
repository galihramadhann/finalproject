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
    public partial class pengarsipan_masuk : Form
    {
        public pengarsipan_masuk()
        {
                InitializeComponent();
            }

        SqlConnection con = new SqlConnection (@"Data Source=LAPTOP-0EV4K4D6\SQLEXPRESS01;Initial Catalog=Pengarsipan;Integrated Security=True");


       private void resetdata()
       {
           txtid.Text = "";
            txtkode.Text = "";
            txtno.Text = "";
            dtptanggal.Text = "";
            txtpengirim.Text = "";
            txtperihal.Text = "";
       }
        private void pengarsipan_masuk_Load(object sender, EventArgs e)
        {
            resetdata();
            showdata();
        }

        private void showdata()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from suratmasuk";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter (cmd);
            da.Fill(ds, "suratmasuk");
            dgvmasuk.DataSource = ds;
            dgvmasuk.DataMember = "suratmasuk";
            dgvmasuk.ReadOnly = true;
        }
        
        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show(" Isi suratmasuk yang akan dihapus");
                goto berhenti;
            }

            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from suratmasuk where id_masuk = '" + txtid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();

        berhenti:
            ;
           

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
          if(txtid.Text == "" | txtkode.Text == "" | txtno.Text == "" | dtptanggal.Text == "" | txtpengirim.Text == "" |txtperihal.Text == "")
            { 
                MessageBox.Show("semua data harus diisi", "peringatan");
                //goto berhenti;

            }
      else
              con.Open();
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = con;
          cmd.CommandType = CommandType.Text;
          cmd.CommandText = " update suratmasuk set kode_sm='" + txtkode.Text + "', no_surat='" + txtno.Text + "', tanggal_surat='" + dtptanggal.Text + "', pengirim='" + txtpengirim.Text + "', perihal ='" + txtperihal.Text + "' where id_masuk = '" + txtid.Text + "'";
          cmd.ExecuteNonQuery();
          con.Close();
             showdata();
            resetdata();

        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from suratmasuk where id_masuk like '%" + txtcaridata.Text + "%'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "suratmasuk");
            dgvmasuk.DataSource = ds;
            dgvmasuk.DataMember = "suratmasuk";
            dgvmasuk.ReadOnly = true;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
             if(txtid.Text == "" | txtkode.Text == "" | txtno.Text == "" | dtptanggal.Text == "" | txtpengirim.Text == "" |txtperihal.Text == "" )
             { MessageBox.Show("Semua data harus diisi", "Peringatan");
                 goto berhenti;
             }

            int num;
            bool isNum = int.TryParse(txtid.Text.ToString() , out num);
            if (!isNum)
            {
                MessageBox.Show("isi id harus angka", "Peringatan");
                goto berhenti;
            }

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into suratmasuk values ('" + txtid.Text + "','" + txtkode.Text + "','" + txtno.Text + "','" + dtptanggal.Value.ToString("yyyy-MM-dd HH:mm:ss.fffffffK") + "','" + txtpengirim.Text + "','" + txtperihal.Text + "')";
            MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();
            con.Close();
            showdata();
            resetdata();
            berhenti:
            ;
            }

        private void btnreser_Click(object sender, EventArgs e)
        {
            showdata();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        }
    }

    