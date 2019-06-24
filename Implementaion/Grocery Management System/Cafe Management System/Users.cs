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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        DbConnection con = new DbConnection();
        private void button1_Click(object sender, EventArgs e)
        {

            string gender;
            

            if (rb1.Checked == true)
            {
                gender = "Male";
            }
            else if (rb2.Checked == true)
            {
                gender = "Female";
            }
            else if (rb3.Checked == true)
            {
                gender = "Others";
            }
            else
            {
                MessageBox.Show("Please select gender");
                return;
            }
            UserBll user = new UserBll();
            user.uid = userid;
            user.fn = (txtfname.Text);
            user.ln = (txtlname.Text);
            user.uname = (txtuname.Text);
            user.pswd = (txtpassword.Text);
            user.g = (gender);
            user.ut = cmbusertype.SelectedValue.ToString();
            user.insertdata();

            string selectedid = cmbusertype.SelectedValue.ToString();
            //MessageBox.Show($"your id is {selectedid}");
            // query = "insert into users(fname,lname,user_typeid,gender) values ('" + txtfname.Text + "','" + txtlname.Text + "'," + txtusertype.Text + ",'" + gender + "')";

            //con.manipulate(query);
            MessageBox.Show("Data Inserted!!");
            display();
            // item items = new item();
            // items.ShowDialog();
        }

        private void display()
        {
            UserBll user = new UserBll();
            dgview.DataSource = user.select();

            /* string query = "select userid,fname,lname,user_typeid,gender from users order by userid desc ";
             DataTable dt = con.retrieve(query);
             dgview.DataSource= dt;*/
        }
        private void txtlname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            string query;
            query = "select usertype_id,usertype from usertype";
            DataTable dt = con.retrieve(query);
            cmbusertype.DataSource = dt;
            cmbusertype.DisplayMember = "usertype";
            cmbusertype.ValueMember = "usertype_id";

            display();
        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        int userid;
        private void dgview_Click(object sender, EventArgs e)
        {
            int columnindex = dgview.CurrentCell.ColumnIndex;
            userid = int.Parse(dgview.CurrentRow.Cells["uid"].Value.ToString());

           // MessageBox.Show($"the col :{columnindex},{userid}");

            string query;
            DataTable dt;
            if (dgview.CurrentRow.Cells[columnindex].Value.ToString() == "Edit")
            {
                query = "select userid, fname, lname, user_typeid, gender,username,passwords from users where userid=" + userid;
                dt = con.retrieve(query);

                txtfname.Text = dt.Rows[0][1].ToString();
                txtlname.Text = dt.Rows[0][2].ToString();
                lblgender.Text = dt.Rows[0][3].ToString();
                cmbusertype.Text = dt.Rows[0][4].ToString();
                txtuname.Text = dt.Rows[0][5].ToString();
                txtpassword.Text = dt.Rows[0][6].ToString();
                btnsave.Text = "update";
            }

            else if (dgview.CurrentRow.Cells[columnindex].Value.ToString() == "Delete")
            {
                DialogResult confirmresult = MessageBox.Show("Are you sure you want to delete?", "Confirm delete?",
                    MessageBoxButtons.YesNoCancel);
                if (confirmresult == DialogResult.Yes)
                {
                    query = "delete from item where item_no=" + userid;
                    con.manipulate(query);
                    display();
                }
            }
            
        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbusertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
