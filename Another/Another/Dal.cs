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
        
        public DataTable SelectAll(string str)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from "+str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close(); 
            return dt;
        }

        public DataTable NewMember(string ss, string name, string city, string street, string zip, string email, string phone)
        {            
            SqlDataAdapter da = new SqlDataAdapter("insert into member values ('" +ss+"','"+name+"','"+city+"','"+street+"','"+zip+"','"+email+"','"+phone+"')" , con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return (dt);           
        }

        public DataTable NewInstructor(string instID, string ss, string name, string city, string street, string zip, string email, string phone)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into instructor values('" + instID + "','" + ss + "','" + name + "','" + city + "','" + street + "','" + zip + "','" + email + "','" + phone + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return (dt);
        }

        public DataTable NewWorkout(string wID, string name, string date, string time, string length, string level)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into workout values ('" + wID + "','" + name + "','" + date + "','" + time + "','" + length + "','" + level + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return (dt);
            
        }  
        public DataTable DeleteMembers(string str)
        {
            SqlDataAdapter da = new SqlDataAdapter("delete from Member where SocialSecurity='"+str+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        
    }
}
