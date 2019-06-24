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
    public partial class usertype : Form
    {
        public usertype()
        {
            InitializeComponent();
        }

        private void usertype_Load(object sender, EventArgs e)
        {
            display();
        }
        DbConnection connect = new DbConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            string query;

            query = "insert into user_type (usertype) values ('" + cmbusertype.Text + "')";

            connect.manipulate(query);
            MessageBox.Show("inserted");
            Users use = new Users();
            use.ShowDialog();

            display();
        }
        private void display()
        {
            string query = "select user_typeid,usertype from user_type order by user_typeid desc";
            DataTable dt = connect.retrieve(query);
            dgview.DataSource = dt;

        }
    }
}
