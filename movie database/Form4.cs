using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Collections;

namespace movie_database
{
    public partial class Form4 : Form
    {
        


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jamie Bright\\source\\repos\\movie database\\movie database\\FlimsDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {  
                sqlcon.Open();
                
                
                SqlDataAdapter sqlda = new SqlDataAdapter("SELECT title,publisher,year FROM movietables", sqlcon);
                DataTable dtb2 = new DataTable();
                sqlda.Fill(dtb2);

                DGV2.DataSource = dtb2;

                DataGridViewComboBoxColumn CB = new DataGridViewComboBoxColumn();
                CB.HeaderText = "rating";
                CB.Name = "ratings";
                ArrayList row = new ArrayList();
                row = new ArrayList();
                row.Add("1");
                row.Add("2");
                row.Add("3");
                row.Add("4");
                row.Add("5");
                row.Add("6");
                row.Add("7");
                row.Add("8");
                row.Add("9");
                row.Add("10");

                CB.Items.AddRange(row.ToArray());
                
                DGV2.Columns.Add(CB);
                
               

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Hide();
            var form3 = new Form3(); form3.Show();
        }

        private void watchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wv.movies123.sbs/");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3(); form3.Show();
        }

       
    }
}
