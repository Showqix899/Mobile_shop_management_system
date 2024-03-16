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

    public partial class SingUp : Form
    {

        public SingUp()
        {
            InitializeComponent();

        }

        string messgae = "Done";
        string errorMessage = "Something went wrong";



        

        



       

        private void registrationbtn(object sender, EventArgs e)
        {

            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);


            try
            {
                conn.Open();

                var checkQuery = "SELECT COUNT(*) FROM registration WHERE username = @username OR email = @email";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", Username_r.Text);
                checkCmd.Parameters.AddWithValue("@email", email_r.Text);

                int userCount = (int)checkCmd.ExecuteScalar();

                if (userCount > 0)
                {

                    MessageBox.Show("User with this username or email already exists.");
                }
                else
                {

                    var insertQuery = "insert into registration values(@username,@email,@phone,@password)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@username", Username_r.Text);
                    cmd.Parameters.AddWithValue("@email", email_r.Text);
                    cmd.Parameters.AddWithValue("@phone", phone_r.Text);
                    cmd.Parameters.AddWithValue("@password", pass_r.Text);



                    cmd.ExecuteNonQuery();


                    Username_r.Clear();
                    email_r.Clear();
                    phone_r.Clear();
                    pass_r.Clear();

                    MessageBox.Show(messgae);









                }

                conn.Close();
            }

            catch
            {

                MessageBox.Show(errorMessage);
            }

        }

        private void loginBtn(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from registration where username=@username and password = @password", conn);
            cmd.Parameters.AddWithValue("@username", login_name.Text);
            cmd.Parameters.AddWithValue("@phone", login_name.Text);
            cmd.Parameters.AddWithValue("@password", login_pass.Text);
            if (login_name.Text == "")
            {
                MessageBox.Show("Enter Username");

            }
            else if (login_pass.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                //MessageBox.Show(messgae);
                login_name.Clear();
                login_pass.Clear();
                Home home = new Home();

                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("invalid username or password");
                login_name.Clear();
                login_pass.Clear();
            }
        }

        private void closeBtn(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
