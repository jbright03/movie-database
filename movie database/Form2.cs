using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration; 
namespace movie_database
{                                                                                                                                                       
    public partial class Form2 : Form
    {
        
        public Form2()
        { 
            InitializeComponent();
           
           
        } 

        private void Form2_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Usearchbox_TextChanged(object sender, EventArgs e)
        {
            

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jamie Bright\\source\\repos\\movie database\\movie database\\FlimsDB.mdf;Integrated Security=True;Connect Timeout=30");
            
                conn.Open();
            SqlCommand cmd1 = new SqlCommand("select id,title,publisher,year from movietables where title like'%" + Usearchbox.Text + "%'");
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1(); form1.Show();
        }



        // update dgview


    }
}
