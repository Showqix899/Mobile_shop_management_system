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

namespace shopmgmt
{
    public partial class mobileStock : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source=DAXTER899\\SQLEXPRESS;Initial Catalog=mobile;Integrated Security=True");
        string Message = "DONE";
        String errorMessage = "Something went wrong";

        string gender;

        public static DataTable DataSource { get; internal set; }

        public mobileStock()
        {
            InitializeComponent();
            
        }

        private void ADD_stock(object sender, EventArgs e)
        {
            try
            {
                connectionOfSql cnn = new connectionOfSql();


                SqlConnection conn = new SqlConnection(cnn.connectionString);
                conn.Open();

                var inserQuery = "insert into stockTable values(@id,@brand,@name,@colour,@ram,@rom,@processor,@price)";
                SqlCommand cmd = new SqlCommand(inserQuery, conn);
                cmd.Parameters.AddWithValue("@id", addMobileId.Text);
                cmd.Parameters.AddWithValue("@brand", brand.SelectedItem);
                cmd.Parameters.AddWithValue("@name", phoneName.Text);
                cmd.Parameters.AddWithValue("@colour", colour.SelectedItem);
                cmd.Parameters.AddWithValue("@ram", ram.SelectedItem);
                cmd.Parameters.AddWithValue("@rom", rom.SelectedItem);
                cmd.Parameters.AddWithValue("@processor", processor.Text);
                cmd.Parameters.AddWithValue("@price", mobilePrice.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                addMobileId.Clear();
                
                mobileName.Clear();
                //colour.Items.Clear();
                //ram.Items.Clear();
                //rom.Items.Clear();
                processor.Clear();
                mobilePrice.Clear();

                

                MessageBox.Show(Message);
            }
            catch
            {
                MessageBox.Show(errorMessage);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addcustomer(object sender, EventArgs e)

        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            try
            {
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                else if (radioButton2.Checked == true)
                {
                    gender = "Female";
                }
                conn.Open();
                var insertQuery = "insert into customer_info values(@name,@address,@phone,@email,@gender)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@name", customerName.Text);
                cmd.Parameters.AddWithValue("@address", customerAddress.Text);
                cmd.Parameters.AddWithValue("@phone", customerPhone.Text);
                cmd.Parameters.AddWithValue("@email", customerEmail.Text);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(Message);
                customerName.Clear();
                customerAddress.Clear();
                customerPhone.Clear();
                customerEmail.Clear();
                
                

            }
            catch { MessageBox.Show(errorMessage); }

        }

        private void deletCustomer(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
                var deletCommand = "delete customer_info where phone=@phone";
                SqlCommand delcmd = new SqlCommand(deletCommand, conn);
                delcmd.Parameters.AddWithValue("@phone", customerPhone.Text);
                delcmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(Message);
                customerPhone.Clear();
            
            
        }

        private void deleteMobile(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
            var deletCommand = "delete stockTable where id=@id";
            SqlCommand delcmd = new SqlCommand(deletCommand, conn);
            delcmd.Parameters.AddWithValue("@id", addMobileId.Text);
            delcmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(Message);
            addMobileId.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

       

        private void customerInfo(object sender, EventArgs e)
        {
            Customerinfo customerinfo = new Customerinfo(); 
            customerinfo.Show();
            this.Hide();
        }

        private void homebtn(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

    }
}
