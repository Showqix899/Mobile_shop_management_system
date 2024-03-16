using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopmgmt
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        

        

        private void Admin(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {
            Admin_loginform admin_Loginform = new Admin_loginform();
            admin_Loginform.Show();
            this.Hide();
          
            
        }

        private void stock_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.Show();
            this.Hide();
        }

        private void logOutbtn(object sender, EventArgs e)
        {
            SingUp SingUp = new SingUp();
            SingUp.Show();
            this.Hide();
        }

        private void closebtn(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sellInfo(object sender, EventArgs e)
        {
           SellInfo SellInfo = new SellInfo();
            SellInfo.Show();   
            this.Hide();
        }
    }
}
