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

        public DataTable selectWorkout(string workout)
        {
            DataTable dt = dal.selectWorkout(workout);
            return dt;
        }
    }
}
