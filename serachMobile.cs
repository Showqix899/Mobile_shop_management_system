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
    public partial class serachMobile : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
       // string messgae = "Done";
        //string errorMessage = "Something went wrong";
        public serachMobile()
        {
            InitializeComponent();
        }

        private void seacrhMobile(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
            var insertQuery = "SELECT * FROM stockTable WHERE brand = @brand";
            SqlCommand cmd = new SqlCommand(insertQuery, conn);
            cmd.Parameters.AddWithValue("@brand", brandName.SelectedItem);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            adapter.Fill(dt);
            showMobile.DataSource = dt;
            
            
            
            
           conn.Close(); 
            

        }

        private void closeButton(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backbtn(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.Show();
            this.Hide();
        }
    }
}
