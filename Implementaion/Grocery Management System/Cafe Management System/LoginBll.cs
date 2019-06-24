using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class LoginBll
    {
        private string username;
        private string password;

        public string uname
        {
            get { return username; }
            set { username = value; ; }
        }

        public string pswd
        {
            get { return password;}
            set { password=value; }
        }

        DbConnection conn = new DbConnection();
        public bool checkuser()
        {
            string query;
            query = "select username from users where username='" + username + "'and passwords='" + password + "'";
            DataTable dt = conn.retrieve(query);

            if (dt.Rows.Count>0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }

}