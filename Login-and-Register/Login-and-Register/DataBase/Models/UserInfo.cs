using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_and_Register.DataBase.Models
{
     class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserInfo(string firstName ,string lastName ,string email ,string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public string GetInfo()
        {
            return $"Name :{FirstName} LastName :{LastName} Email :{Email} Password :{Password}";
        }
        public string GetShortInfo()
        {
            return $"Name :{FirstName} LastName :{LastName} Email :{Email}";
        }
    }
}
