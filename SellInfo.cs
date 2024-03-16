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
    public partial class SellInfo : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string Message = "DONE";
        String errorMessage = "Something went wrong";
        string gender;
        public SellInfo()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homebtn(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void exitbtn(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        private void addSellInfo(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            try
            {
                conn.Open();
                var insertQuery = "insert into sell_info2 values(@name,@phone,@email,@brand,@quantity,@productid,@price,@date)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", cstmrName.Text);
                cmd.Parameters.AddWithValue("@phone", cstmrPhone.Text);
                cmd.Parameters.AddWithValue("@email", cstmrEmail.Text);
                cmd.Parameters.AddWithValue("@brand", purchasedBrand.SelectedItem);
                cmd.Parameters.AddWithValue("@quantity", quantity.Text);
                cmd.Parameters.AddWithValue("@productid", Productid.Text);
                cmd.Parameters.AddWithValue("@price", cost.Text);
                cmd.Parameters.AddWithValue("@date", date.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(Message);

            }
            catch
            {
                MessageBox.Show(errorMessage);
            }
        }

        

        private void showinfo(object sender, EventArgs e)
        {
            showSellInfo sh=new showSellInfo();
            sh.Show();
            this.Hide();
        }
    }
}
