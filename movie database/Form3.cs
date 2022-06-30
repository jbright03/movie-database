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

namespace movie_database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jamie Bright\\source\\repos\\movie database\\movie database\\FlimsDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT title,publisher,year FROM movietables", sqlcon);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);

                DGV1.DataSource = dtb1;

            }
          

            Update();
        }

        private void RUsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jamie Bright\\source\\repos\\movie database\\movie database\\FlimsDB.mdf;Integrated Security=True;Connect Timeout=30");

            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select title,publisher,year from movietables where title like'%" + RUsearch.Text + "%'");
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            cmd1.Connection = conn;


            DataTable dt = new DataTable();

            da.SelectCommand = cmd1;

            dt.Clear();

            da.Fill(dt);

            DGV1.DataSource = dt;


            conn.Close();

        }

        private void watchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wv.movies123.sbs/");
        }

        private void myMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4(); form4.Show();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
