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
        
     
           public DataTable DeleteMembers(string str)
        {
            DataTable dt = dal.DeleteMembers(str);
            return dt;
        }
    }
}
