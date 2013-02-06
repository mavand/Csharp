using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another.Model
{
    class Member
    {
        public Member(){}

        public Member(string socialSecurity, string name, string city, string street, string zipCode, string email, string phone)
        {
            SocialSecurity = socialSecurity;
            Name = name;
            City = city;
            Street = street;
            ZipCode = zipCode;
            Email = email;
            Phone = phone;
       }
        
        private string socialSecurity;
        public string SocialSecurity
        {
            get { return socialSecurity; }
            set { socialSecurity = value; }
        }
        
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        
        private string zipCode;
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
