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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        DbConnection net = new DbConnection();
        Billbll bills = new Billbll();
        private void Bill_Load(object sender, EventArgs e)
        {

            int a = bills.selectbill_no();
            lblbillno.Text = a.ToString();
            cmbiname.DataSource = bills.combo();
            cmbiname.DisplayMember = "item_name";
            cmbiname.ValueMember = "item_no";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "insert into userid,total,discount,vat,nettotal(Bill) values (" + txtuserid.Text + "," + txttotal.Text + "," + txtdiscount.Text + "," + txtvat.Text + "," + txtnettotal.Text + ")";
            // net.manipulate(query);
            int bn;
            int uid;
            float total;
            float discount;
            float vat;
            float nettotal;


            bn = int.Parse(lblbillno.Text);
            uid = int.Parse(txtuserid.Text);
            total = float.Parse(txttotal.Text);
            discount = float.Parse(txtdiscount.Text);
            vat = float.Parse(txtvat.Text);
            nettotal = float.Parse(txtnettotal.Text);



            Billbll bills = new Billbll();

            MessageBox.Show("inserted");
            item Item = new item();
            Item.ShowDialog();

        }

        public void display()
        {
            string query = "select bill_no,userid,total,discount,vat,nettotal from Bill order by bill_no desc";
            DataTable dt = net.retrieve(query);
            dgview.DataSource = dt;

        }

        private void txtvat_TextChanged(object sender, EventArgs e)
        {

        }
        private void cleardata()
        {
            txtfname.Text = "";
            txtlname.Text = "";
            txtgender.Text = "";
            txtut.Text = "";

        }
        private void txtuserid_TextChanged(object sender, EventArgs e)
        {

            if (txtuserid.Text == "")
            {
                cleardata();
            }

            else
            {
                string query;
                int userid;

                userid = int.Parse(txtuserid.Text);
                query = "select fname, lname, usertype, gender from users u ,user_type ut where u.user_typeid = ut.user_typeid and userid =" + userid;
                DataTable dt = net.retrieve(query);
                if (dt.Rows.Count > 0)
                {
                    txtfname.Text = dt.Rows[0][0].ToString();
                    txtlname.Text = dt.Rows[0][1].ToString();
                    txtut.Text = dt.Rows[0][2].ToString();
                    txtgender.Text = dt.Rows[0][3].ToString();

                }
                else
                {
                    cleardata();
                }
            }
        }

        private void txtgender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbiname_Click(object sender, EventArgs e)
        {

        }

        private void txtrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbiname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select rate from item where item_name='" + cmbiname.Text + "'";
            DataTable dt = net.retrieve(query);
            if (dt.Rows.Count > 0)
            {
                txtrate.Text = dt.Rows[0][0].ToString();

            }
            else
            {
                txtrate.Text = "";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {


            //  float total = float.Parse(txtqty.Text) * float.Parse(txtrate.Text);
            //string query = "insert into bill_item(bill_no,item_no,quantity)values (" + lblbillno.Text + ",'" + cmbiname.SelectedValue + "'," + txtqty.Text+")";
            //net.manipulate(query);


            BIllitemBll billi = new BIllitemBll();
            billi._bill_no = int.Parse(lblbillno.Text);
            billi._item_no = int.Parse(cmbiname.SelectedValue.ToString());
            billi._qty = int.Parse(txtqty.Text);
            billi._rate = int.Parse(txtrate.Text);
            billi.insertdata();
            // billi._total = int.Parse(txttotal.Text);
            billi.totals();
            // billi.insertdata();
            DataTable d = billi.calcsum();
            
            txttotal.Text = d.Rows[0][0].ToString();
            dgview.DataSource = bills.loadgrid();


        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {

        }
        int itemid;
        private void dgview_Click(object sender, EventArgs e)
        {
            int columnindex = dgview.CurrentCell.ColumnIndex;
            itemid = int.Parse(dgview.CurrentRow.Cells["itemno"].Value.ToString());

            // MessageBox.Show("col index" + columnindex + "itemno" + itemid);
            // MessageBox.Show($"col index {columnindex},{itemid}");

            string query;
            DataTable dt;

            if (dgview.CurrentRow.Cells[columnindex].Value.ToString() == "Edit")
            {
                query = "select item_no,item_name,rate,quantity from item where item_no =" + itemid;
                dt = net.retrieve(query);
                cmbiname.Text = dt.Rows[0][1].ToString();
                txtrate.Text = dt.Rows[0][2].ToString();
                txtqty.Text = dt.Rows[0][3].ToString();
                btnadd.Text = "update";



            }

            else if (dgview.CurrentRow.Cells[columnindex].Value.ToString() == "Delete")
            {
                DialogResult confirmresult = MessageBox.Show("Are you sure you want to delete?", "Confirm delete?",
                    MessageBoxButtons.YesNoCancel);
                if (confirmresult == DialogResult.Yes)
                {
                    query = "delete from item where item_no=" + itemid;
                    net.manipulate(query);
                    display();
                }
            }
        }
    }
}

