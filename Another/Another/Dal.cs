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
            SqlDataAdapter da = new SqlDataAdapter("select * from " + str, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
            public DataTable SelectWorkout(string workout)
        {
            SqlDataAdapter da = new SqlDataAdapter("select workID, name, date from workout where name like '%" + workout + "%'", con);
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
        public DataTable DeleteMember(string tableName, string pk)
        {
            SqlDataAdapter da = new SqlDataAdapter("delete from "+tableName+" where SocialSecurity='" +pk+ "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable NewInstructor(string instID, string ss, string name, string city, string street, string zip, string email, string phone)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into instructor values('" + instID + "','" + ss + "','" + name + "','" + city + "','" + street + "','" + zip + "','" + email + "','" + phone + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return (dt);
        }

        public DataTable DeleteInstructor(string tableName, string pk)
        {
            SqlDataAdapter da = new SqlDataAdapter("delete from " + tableName + " where instid='" + pk + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable NewWorkout(string wID, string name, string date, string time, string length, string level)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into workout values ('" + wID + "','" + name + "','" + date + "','" + time + "','" + length + "','" + level + "')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return (dt);            
        }

        public DataTable DeleteWorkout(string tableName, string pk)
        {
            SqlDataAdapter da = new SqlDataAdapter("delete from " + tableName + " where workid='" + pk + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable SearchAll(string str, string str2)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from " + str + " where name like '%" + str2 + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable GetWorkout()
        {
            SqlDataAdapter da = new SqlDataAdapter("select name from workout", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable EditMember(string ss, string name, string city, string street, string zip, string email, string phone, string pk)
        {
            SqlDataAdapter da = new SqlDataAdapter("Update Member set SocialSecurity='" + ss + "'," + "Name='" + name + "'," + "City='" + city + "', " + "Street='" + street + "', " + "ZipCode='" + zip + "', " + "Email='" + email + "', " + "Phone='" + phone + "' where SocialSecurity='" + pk + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable EditWorkout(string wID, string name, string date, string time, string length, string level, string pk)
        {
            SqlDataAdapter da = new SqlDataAdapter("Update Workout set WorkID='" + wID + "'," + "Name='" + name + "'," + "Date='" + date + "', " + "Time='" + time + "', " + "Length='" + length + "', " + "Level='" + level + "' where WorkID='" + pk + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable EditInstructor(string instID, string ss, string name, string city, string street, string zip, string email, string phone, string pk)
        {
            SqlDataAdapter da = new SqlDataAdapter("update instructor set InstID='" + instID + "'," + "SocialSecurity='" + ss + "'," + "Name='" + name + "'," + "City='" + city + "', " + "Street='" + street + "', " + "ZipCode='" + zip + "', " + "Email='" + email + "', " + "Phone='" + phone + "' where InstID='" + pk + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable BookMemberWorkout(string ss, string workid, string date)
        {
            SqlDataAdapter da = new SqlDataAdapter("insert into memberworkout values('"+ss+"','"+workid+"','"+date+"')", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable MemberWorkout(string ss)
        {            
            SqlDataAdapter da = new SqlDataAdapter("select Member.name as Member, Workout.name as Workout, MemberWorkout.date as Date, workout.workid as WorkID, member.socialsecurity as SS from Member join memberworkout on member.SocialSecurity=MemberWorkout.SocialSecurity join workout on memberworkout.WorkID=workout.WorkID where member.SocialSecurity='"+ss+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable DeleteMemberWorkout(string ss, string workid)
        {
            SqlDataAdapter da = new SqlDataAdapter("delete from memberworkout where socialsecurity='" +ss+ "' and workid='"+workid+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}