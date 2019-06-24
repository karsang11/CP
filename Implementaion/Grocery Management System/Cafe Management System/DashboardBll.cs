using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class DashboardBll
    {
        DbConnection conn = new DbConnection();
        string query;
        
        public void insert()
        {
            query = "insert into Bill(total) values(null)";
            conn.manipulate(query);
        
        }

        public DataTable select()
        {
            query = "select max(bill_no) from Bill";
            return conn.retrieve(query);
            
        }
    }
}
