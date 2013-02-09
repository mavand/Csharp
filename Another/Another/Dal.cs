using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Another
{
    class Dal
    {
        SqlConnection con = new SqlConnection("server=(local);" +
                                               "Integrated Security=true;" +
                                               "database=gym;");
        public Dal()
        {  
        }

        public DataTable SelectAll(string str)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from "+str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close(); 
            return dt;
        }        
    }
}
