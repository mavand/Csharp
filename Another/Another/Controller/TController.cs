﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Another.Controller
{
    class TController
    {
        Dal dal = new Dal();

        public DataTable SelectAll(string str)
        {
            DataTable dt = dal.SelectAll(str);
            return dt;
        }

        public DataTable NewMember(string ss, string name, string city, string street, string zip, string email, string phone)
        {
            DataTable dt = dal.NewMember(ss,name,city,street,zip,email,phone);
            return dt;
        }
        public DataTable NewInstructor(string ss, string name, string city, string street, string zip, string email, string phone)
        {
            DataTable dt = dal.NewInstructor(ss, name, city, street, zip, email, phone);
            return dt;
        }
        public DataTable NewWorkout(string wID, string name, string date, string time, string length, string level)
        {
            DataTable dt = dal.NewWorkout(wID, name, date, time, length, level);
            return dt;
        }
        public DataTable DeleteMembers(string index)
        {
            DataTable dt = dal.DeleteMembers(index);
            return dt;
        }

    }
}