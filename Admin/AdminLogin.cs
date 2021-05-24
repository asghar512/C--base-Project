using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AdminLogin : Form
    {

        
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (usernametb.Text != "" && pwtb.Text != "")
            {
                AdminController ac = new AdminController();
                if (ac.authenticate(usernametb.Text,pwtb.Text))
                {
                    AdminHome h = new AdminHome();
                    this.Hide();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter username / password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
