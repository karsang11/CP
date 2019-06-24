using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management_System
{
    class UserBll
    {
        private int userid;
        private string fname;
        private string lname;
        private string gender;
        private string usertype;
        private string username;
        private string password;

        public int uid
        {
            get{ return userid; }
            set { userid = value; }
        }
        public string fn
        {
            get { return fname; }
            set { fname = value; }

        }

        public string ln
        {
            get { return lname; }
            set { lname = value; }
        }


        public string g
        {
            get { return gender; }
            set { gender = value; }
        }
        
        public string ut
        {
            get { return usertype; }
            set { usertype = value; }
        }    

        public string uname
        {
            get { return username; }
            set { username = value; }
        }

        public string pswd
        {
            get { return password; }
            set { password = value; }
        }

        DbConnection conn = new DbConnection();
        public void insertdata()
        {
           
            string query = "insert into users(fname,lname,user_typeid,gender,username,passwords) values ('" +fname+ "','"+lname+"','"+ usertype + "','" + gender + "','"+username+"','"+password+"')";
            conn.manipulate(query);
        }

        public DataTable select()
        {
            //string query = "select userid,fname,lname,user_typeid,gender from users order by userid desc";
            string query = "select userid, fname, lname, usertype, gender,username,passwords from users u ,user_type ut where u.user_typeid = ut.user_typeid";
            DataTable dt= conn.retrieve(query);
            return dt;
        }

        
    }

    
}
