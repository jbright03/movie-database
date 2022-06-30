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
    public partial class Form6 : Form
    {

        

        string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jamie Bright\\source\\repos\\movie database\\movie database\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  if (txtusername.Text == "" || txtpassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (txtpassword.Text != txtconfirmpassword.Text)
                MessageBox.Show("passwords do not match");
            else
            {
                 using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("adduser",conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@username", txtusername.Text.Trim());
                sqlcmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("registration confirmed");

                clear();

            }
            void clear()
            {
                txtusername.Text = txtpassword.Text = txtconfirmpassword.Text = "";

                    this.Hide();
                    var form1 = new Form1(); form1.Show();
                }
            }
             
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.Show();
        }
    }
}
