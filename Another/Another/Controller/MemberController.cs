using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another.Controller
{
    class MemberController
    {
        Dal dal = new Dal();

        public DataTable NewMember(string ss, string name, string city, string street, string zip, string email, string phone)
        {
            DataTable dt = dal.NewMember(ss, name, city, street, zip, email, phone);
            return dt;
        }        
     
        public DataTable DeleteMember(string tableName, string pk)
        {
            DataTable dt = dal.DeleteMember(tableName, pk);
            return dt;
        }

        public DataTable EditMember(string ss, string name, string city, string street, string zip, string email, string phone, string pk)
        {
            DataTable dt = dal.EditMember(ss, name, city, street, zip, email, phone, pk);
            return dt;
        }

    }
}
