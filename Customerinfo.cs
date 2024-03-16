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
    public partial class Customerinfo : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        //string messgae = "Done";
       // string errorMessage = "Something went wrong";
        public Customerinfo()
        {
            InitializeComponent();
        }

        private void customerinfo(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From customer_info", conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            customerinfoview.DataSource = datatable;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mobileStock mobilestock = new mobileStock();
            mobilestock.Show();
            this.Hide();
        }

        private void Searchbtn(object sender, EventArgs e)
        {
            searchCustomer searchCustomer = new searchCustomer();
            searchCustomer.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homeBtn(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }
    }
}
