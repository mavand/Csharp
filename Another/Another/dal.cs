using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another

{
    class dal
    {

        SqlConnection conn = new SqlConnection("Data Source=VALONS;Initial Catalog=gym;Integrated Security=True");

        SqlCommand cmd;
        
        try{
      

        conn.Open();
                cmd = new SqlCommand("Insert into Member (SocialSecurity, Name, City, Street, Zipcode, Email, Phone) values 
   
}
}
