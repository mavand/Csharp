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
            DataTable dt = dal.MemberWorkout(ss);
            return dt;
        }
    }
}
