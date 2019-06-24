using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class Billbll
    {
        private int billno;
        private int userid;
        private float total;
        private float discount;
        private float vat;
        private float netttotal;
        private float rate;
        private int quantity;

        DbConnection conn = new DbConnection();
       public int _billno
        {
            get { return billno; }
            set { billno = value; }
        }

        public int _userid
        {
            get { return userid; }
            set { userid = value; }
        }

        public float _total
        {
            get { return total; }
            set { total = value; }
        }

        public float _discount
        {
            get { return discount; }
            set { discount = value; }
        } 

        public float _vat
        {
            get { return vat; }
            set { vat = value; }

        }

        public float _netttotal
        {
            get { return netttotal; }
            set { netttotal = value; }
        }

        public float _rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public int  _quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
      /*  public void insertdata()
        {
            string query = "insert into userid,total,discount,vat,nettotal(Bill) values (" + billno + ","
                + userid + "," + total + "," + discount + "," + vat + "," + netttotal + ")";
            conn.manipulate(query);
        }*/

        public DataTable combo()
        {
            string query;
            query = "select item_no,item_name from item";
            DataTable dt = conn.retrieve(query);
            return dt;
        }
       /* public void insert()
        {
            string query;
            query = "insert into Bill(total) values(null)";
            conn.manipulate(query);

        }*/
        public DataTable loadgrid()
        {
            string query;
            query = "select i.item_no,i.rate,bi.quantity from item i,bill_item bi where i.item_no=bi.item_no and bi.bill_no=" + billno;
            DataTable dt = conn.retrieve(query);
            return dt;
            
        }
       public int selectbill_no()
        {
            string query;
            query = "select max(bill_no) from Bill";
            DataTable dt = conn.retrieve(query);
            
            if (dt.Rows.Count>0 && dt.Rows[0][0].ToString()!="")
            
            {
           
                return int.Parse(dt.Rows[0][0].ToString());
            }

            else
            {
                return 1;
            }
            

            
        }
        
    }
}
