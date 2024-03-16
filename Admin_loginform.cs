using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmgmt
{
    public partial class Admin_loginform : Form
    {
        public Admin_loginform()
        {
            InitializeComponent();
        }
        // SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string messgae = "Done";
        //string errorMessage = "Something went wrong";

        private void button1_Click(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from admin_login where username=@username and password = @password", conn);
            cmd.Parameters.AddWithValue("@username", adminUsername.Text);
            // cmd.Parameters.AddWithValue("@phone", login_name.Text);
            cmd.Parameters.AddWithValue("@password", adminPassword.Text);
            if (adminUsername.Text == "")
            {
                MessageBox.Show("Enter Username");

            }
            else if (adminPassword.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                //MessageBox.Show(messgae);
                adminUsername.Clear();
                adminPassword.Clear();
                mobileStock mobileStock = new mobileStock();
                mobileStock.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}