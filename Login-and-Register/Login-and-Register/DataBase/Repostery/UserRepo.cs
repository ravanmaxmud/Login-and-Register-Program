using Login_and_Register.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_and_Register.DataBase.Repostery
{
    class UserRepo
    {
        private static List<UserInfo> Users { get; set; } = new List<UserInfo>();

        public static UserInfo AddUser(string firstName, string lastName, string email ,string password)
        {
            UserInfo userInfo = new UserInfo(firstName, lastName, email, password);
            Users.Add(userInfo);
            return userInfo;

        }
        public static bool IsMailUnical(string mail)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Email == mail)
                {
                    Console.WriteLine("Bu email artiq movcuddur");
                    return false;
                }
            }
            return true;
        }
        public static UserInfo GetUserByEmailAndPassword(string email, string password)
        {
            foreach (UserInfo user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
        public static bool IsUserExistByEmailAndPassword(string email, string password)
        {
            foreach (UserInfo user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static UserInfo GetUserByEmail(string email)
        {
            foreach (UserInfo user in Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
