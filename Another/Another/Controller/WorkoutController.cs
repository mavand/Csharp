﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another.Controller
{
    class WorkoutController
    {
        Dal dal = new Dal();

        public DataTable NewWorkout(string wID, string name, string date, string time, string length, string level)
        {
            DataTable dt = dal.NewWorkout(wID, name, date, time, length, level);
            return dt;
        }

        public DataTable DeleteWorkout(string tableName, string pk)
        {
            DataTable dt = dal.DeleteWorkout(tableName, pk);
            return dt;
        }

        public DataTable EditWorkout(string wID, string name, string date, string time, string length, string level, string pk)
        {
            DataTable dt = dal.EditWorkout(wID, name, date, time, length, level, pk);
            return dt;
        }
    }
}