using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Cafe_Management_System
{
    class DbConnection
    {
        SqlConnection cms = new SqlConnection(@"Data Source=JOKER\SQLEXPRESS; Initial Catalog=Grocery_Managemenent_system; Integrated Security=TRUE");
        
        //sql connection cms = new sqlconnection(myconnstring);

        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        //used for insert, update, delete
        public void manipulate(string query)
        {
            cms.Open();
            cmd.Connection = cms;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cms.Close();
        }

        public DataTable retrieve(string query)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(query, cms);
            da.Fill(ds);
            return ds.Tables[0];
        }

    }
}
