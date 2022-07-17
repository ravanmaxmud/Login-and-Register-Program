using Login_and_Register.DataBase.Models;
using Login_and_Register.DataBase.Repostery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_and_Register.Aplication_Locig
{
     class Authentication
    {
       
        public static void Register()
        {
            Console.WriteLine();
            string firstName =GetFirstName();
            string lastName = GetLastName();
            string email = GetEmail();
            string password = GetPassword();
            Console.Write("Conifirim Your Password : ");
            string confirimPassword= Console.ReadLine();
            Console.WriteLine();

            if (UserValidation.IsValidPassword(password,confirimPassword))
            {
                UserInfo user = UserRepo.AddUser(firstName, lastName, email, password);
                Console.WriteLine("User aded the system" + user.GetInfo());
                Console.WriteLine("You successfully registered, now you can login with your new account!");

            }
        }

        private static string GetFirstName()
        {
            Console.Write("Please enter user's name : ");
            string firstName = Console.ReadLine();

            while (!UserValidation.IsNameCorrect(firstName))
            {
                Console.Write("Please enter correct user's name : ");
                firstName = Console.ReadLine();
            }

            return firstName;
        }
        private static string GetLastName()
        {
            Console.Write("Please Enter User's surname : ");
            string lastName = Console.ReadLine();
            while (!UserValidation.IsLastNNameCorrect(lastName))
            {
                Console.Write("Please enter correct user's surname : ");
                lastName = Console.ReadLine();
            }
            return lastName;

        }
        private static string GetEmail()
        {
            Console.Write("Please Enter User's Email : ");
            string email = Console.ReadLine();
            while (!UserValidation.IsMailCorrect(email))
            {
                Console.Write("Please enter correct user's Email : ");
                email = Console.ReadLine();
            }
            return email;

        }
        private static string GetPassword()
        {
            Console.Write("Please Enter User's Password : ");
            string password = Console.ReadLine();
            while (!UserValidation.IsPasswordCorrect(password))
            {
                Console.Write("Please enter correct user's Password : ");
                password = Console.ReadLine();
            }
            return password;

        }
        public static void Login()
        {
            Console.WriteLine();
            Console.Write("Please Enter User Email : ");
            string email = Console.ReadLine();

            Console.Write("Please Enter User Password : ");
            string password = Console.ReadLine();
            if (UserValidation.IsLoginCorrect(email, password))
            {
                UserInfo user = UserRepo.GetUserByEmail(email);
                Console.WriteLine("Welcome to your account :", user.GetShortInfo());
            }

        }
    }
}
