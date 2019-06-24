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

    public partial class item : Form
    {
        public item()
        {
            InitializeComponent();
        }
        DbConnection conn = new DbConnection();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            Itembll insert = new Itembll();
            insert.iid = itemid;
            insert.i = (txtitemname.Text);
            insert.r = (float.Parse(txtrate.Text));
            if (btnsave.Text == "Save")
            {
             
                insert.insertdata();
                
            }

            else
            {

                    insert.updatedata();
                               
            }
            btnsave.Text = "Save";

          //  MessageBox.Show("inserted!!");
            display();
        }
        private void display()
        {
            Itembll items = new Itembll();
            dgview.DataSource = items.select();
            /* string query;
            // query= "select item_no,item_name,rate from item order by item_no desc";

            // DataTable dt = conn.retrieve(query);
             dgview.DataSource = dt;*/



        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int itemid;

        //for editing data and deleting data
        private void dgview_Click(object sender, EventArgs e)
        {
            int columnindex = dgview.CurrentCell.ColumnIndex;
            itemid = int.Parse(dgview.CurrentRow.Cells["itemno"].Value.ToString());

           // MessageBox.Show("col index" + columnindex + "itemno" + itemid);
           // MessageBox.Show($"col index {columnindex},{itemid}");

            string query;
            DataTable dt;

            if (dgview.CurrentRow.Cells[columnindex].Value.ToString()=="Edit")
            {
                query = "select item_no,item_name,rate from item where item_no =" + itemid;
                dt = conn.retrieve(query);
                txtitemname.Text = dt.Rows[0][1].ToString();
                txtrate.Text = dt.Rows[0][2].ToString();
                btnsave.Text = "update";

                

            }

            else if (dgview.CurrentRow.Cells[columnindex].Value.ToString()=="Delete")
            {
                DialogResult confirmresult = MessageBox.Show("Are you sure you want to delete?", "Confirm delete?",
                    MessageBoxButtons.YesNoCancel);
                if(confirmresult==DialogResult.Yes)
                {
                    query = "delete from item where item_no=" + itemid;
                    conn.manipulate(query);
                    display();
                }
            }
        }
    }
}
