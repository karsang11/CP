using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
       
        DbConnection conn = new DbConnection();

        DashboardBll dashboards = new DashboardBll();
        private void button4_Click(object sender, EventArgs e)
        {
            dashboards.insert();
            Bill bill = new Bill();
            bill.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usertype usertype = new usertype();
            usertype.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            item items = new item();
            items.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
