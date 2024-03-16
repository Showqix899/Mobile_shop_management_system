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
    public partial class searchSellInfo : Form
    {
        string messgae = "Done";
        string errorMessage = "Something went wrong";
        public searchSellInfo()
        {
            InitializeComponent();
        }


        private void clsBtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backBtn(object sender, EventArgs e)
        {
            showSellInfo showSellInfo = new showSellInfo();
            showSellInfo.Show();
            this.Hide();
        }

        private void serachBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connectionOfSql cnn = new connectionOfSql();


                SqlConnection conn = new SqlConnection(cnn.connectionString);
                conn.Open();
                var insertQuery = "SELECT * FROM sell_info2 WHERE phone = @phone";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@phone", numberCoustomer.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adapter.Fill(dt);
                sellInfoDisplay.DataSource = dt;
                conn.Close();
            }
            catch
            {
                MessageBox.Show(errorMessage);
            }
        }
    }
}
