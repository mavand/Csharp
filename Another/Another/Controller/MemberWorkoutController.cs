using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another.Controller
{
    class MemberWorkoutController
    {
        Dal dal = new Dal();

        public DataTable MemberWorkout(string ss)
        {
            DataTable dt = dal.GetMemberWorkout(ss);
            return dt;
        }

        public DataTable DeleteMemberWorkout(string ss, string workid)
        {
            DataTable dt = dal.DeleteMemberWorkout(ss, workid);
            return dt;
        }
    }
}
