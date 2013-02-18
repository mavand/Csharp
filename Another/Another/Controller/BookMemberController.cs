using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Another.Controller
{
    class BookMemberController
    {
        Dal dal = new Dal();

        public DataTable SelectWorkout(string workout)
        {
            DataTable dt = dal.SelectWorkout(workout);
            return dt;
        }

        public DataTable BookMemberWorkout(string ss, string workid, string date)
        {
            DataTable dt = dal.BookMemberWorkout(ss, workid, date);
            return dt;
        }
    }
}
