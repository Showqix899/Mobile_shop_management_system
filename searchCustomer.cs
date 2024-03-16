using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmgmt
{
    public partial class searchCustomer : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string messgae = "Done";
        string errorMessage = "Something went wrong";
        public searchCustomer()
        {
            InitializeComponent();
        }

        private void Searchbtn(object sender, EventArgs e)
        {
            try
            {
                connectionOfSql cnn = new connectionOfSql();


                SqlConnection conn = new SqlConnection(cnn.connectionString);
                conn.Open();
                var insertQuery = "SELECT * FROM customer_info WHERE phone = @phone";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@phone", customerNumber.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                showCustomerInfo.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show(errorMessage);
            }
        }

        

        private void backbtn(object sender, EventArgs e)
        {
            Customerinfo customerinfo = new Customerinfo();
            customerinfo.Show();
            this.Hide();
        }

        private void crossbtn(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
