using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Another.Controller
{
    class MainController
    {
        Dal dal = new Dal();

        public DataTable GetAll(string table)
        {
            DataTable dt = dal.GetAll(table);
            return dt;
        }

        public DataTable SearchAll(string table, string name)
        {
            DataTable dt = dal.SearchAll(table, name);
            return dt;
        }               

        /*public DataTable GetWorkout()
        {
            DataTable dt = dal.GetWorkout();
            return dt;
        }*/

        public DataTable DeleteMW(string ss)
        {
            DataTable dt = dal.DeleteMW(ss);
            return dt;
        }
    }
}
