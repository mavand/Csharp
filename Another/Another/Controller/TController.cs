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
        Form1 form1 = new Form1();
        Dal dal = new Dal();


        public DataTable Query()
        {
            DataTable dt = dal.Query();
            return dt;
        }
    }
}
