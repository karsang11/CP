using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class Itembll
    {
        private int itemid;
        private string item;
        private float rate;

        public int iid
        {
            get { return itemid; }
            set { itemid = value; }
        }
        public string i
        {
            get { return item; }
            set { item = value; }
        }

        public float r
        {
            get { return rate; }
            set { rate = value; }
        }

        DbConnection conn = new DbConnection();
        public void insertdata()
        {
            
            string query = "insert into item (item_name,rate) values ('" + item + "'," + rate + ")";
            conn.manipulate(query);
        }
        public void updatedata()
        {
            string query;
            query = "update item set item_name = '" + item + "', rate=" + rate + " where item_no=" + itemid;

            conn.manipulate(query);
        }
            public DataTable select()
        {
            string query;
            query = "select item_no,item_name,rate from item order by item_no desc";
            DataTable dt = conn.retrieve(query);
            return dt;
        }
    }
}
