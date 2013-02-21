using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another.Controller
{
    class InstructorController
    {
        Dal dal = new Dal();

        public DataTable NewInstructor(string instID, string ss, string name, string city, string street, string zip, string email, string phone)
        {
            DataTable dt = dal.NewInstructor(instID, ss, name, city, street, zip, email, phone);
            return dt;
        }

        public DataTable DeleteInstructor(string tableName, string pk)
        {
            DataTable dt = dal.DeleteInstructor(tableName, pk);
            return dt;
        }

        public DataTable EditInstructor(string instId, string ss, string name, string city, string street, string zip, string email, string phone, string pk)
        {
            DataTable dt = dal.EditInstructor(instId, ss, name, city, street, zip, email, phone, pk);
                return dt;
        }
    }
}
