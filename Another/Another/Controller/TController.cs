using System;
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

    }
}
