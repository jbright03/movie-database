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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Jamie Bright\\source\\repos\\movie database\\movie database\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from logintable where username = '" + txtusername.Text.Trim() + "' and password = " + txtpassword.Text.Trim() + "";
            SqlDataAdapter sda = new SqlDataAdapter(query,sqlcon);
            DataTable dtbl1 = new DataTable();
            sda.Fill(dtbl1);
            if (dtbl1.Rows.Count == 1)
            {
              Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }

            else
            {
                MessageBox.Show("check username and password");
            }
          
        }

        private void Form5_Load(object sender, EventArgs e)
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
