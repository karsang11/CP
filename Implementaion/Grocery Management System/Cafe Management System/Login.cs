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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginBll login = new LoginBll();
            login.uname = txtuname.Text;
            login.pswd = txtpswd.Text;

            bool isvalid = login.checkuser();
            if(isvalid)
            {
                this.Hide();

                dashboard dash = new dashboard();
                dash.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("either username or password is incorrect");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
