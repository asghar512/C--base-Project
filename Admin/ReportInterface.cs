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
    public partial class ReportInterface : Form
    {
        public ReportInterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome a = new AdminHome();
            a.Show();
            this.Hide();
        }

        private void ReportInterface_Load(object sender, EventArgs e)
        {
            dateTimePicker2.MaxDate = DateTime.Today;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
