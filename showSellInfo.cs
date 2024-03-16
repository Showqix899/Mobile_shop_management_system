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
    public partial class showSellInfo : Form
    {
        public showSellInfo()
        {
            InitializeComponent();
        }

        private void homeBtn(object sender, EventArgs e)
        {
            Home home  = new Home();
            home.Show();
            this.Hide();

        }

        private void exitBtn(object sender, EventArgs e)
        {
            SellInfo sellInfo = new SellInfo();
            sellInfo.Show();
            this.Hide();

          
        }

        private void viewsellinfo(object sender, EventArgs e)
        {
            connectionOfSql cnn = new connectionOfSql();


            SqlConnection conn = new SqlConnection(cnn.connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From sell_info2", conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            sellInformation.DataSource = datatable;
        }

        private void searchBtn(object sender, EventArgs e)
        {
            searchSellInfo searchSellInfo = new searchSellInfo();   
            searchSellInfo.Show();
            this.Hide();
        }
    }
}
