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
    public partial class inventory : Form
    {
       // SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string Message = "DONE";
        String errorMessage = "Something went wrong";
        string gender;
        public inventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From stockTable",conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            mobileStock.DataSource = datatable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void SearchBtn(object sender, EventArgs e)
        {
            serachMobile serachMobile = new serachMobile();
            serachMobile.Show();
            this.Hide();
        }
    }
}
