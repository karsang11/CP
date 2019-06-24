using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class BIllitemBll
    {
        private int bill_no;
        private int item_no;
        private int qty;
        private int total;
        private int rate;

        DbConnection conn = new DbConnection();
        public int _bill_no
        {
            get { return bill_no; }
            set { bill_no = value; }

        }
        public int _item_no
        {
            get { return _item_no; }
            set { item_no = value; }
        }

        public int _qty
        {
             get { return qty; }
            set { qty = value; }
        }

       public int _total
        {
            get { return total; }
            set { total = value; }
        }

        public int _rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public int totals()
        {
            return qty * rate;
        }

        public DataTable calcsum()
        {
            string query;
            query = "select total from bill_item where bill_no= " + total;
            DataTable dt =conn.retrieve(query);
            return dt;
        }
        public void insertdata()
        {
            int OneTotal = _qty * _rate;
            string query = "insert into bill_item(bill_no,item_no,quantity,total) values(" + bill_no + "," + item_no + "," + qty + "," + OneTotal + ")";
            conn.manipulate(query);
        }



    }
}
