using Login_and_Register.Aplication_Locig;
using System;

namespace Login_and_Register
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thees are Our Command");
            Console.WriteLine("/register");
            Console.WriteLine("/login");
            Console.WriteLine("/exit");

            while (true)
            {
                Console.Write("Please Enter Command :");
                string command = Console.ReadLine();
                if (command == "/register")
                {
                    Authentication.Register();
                }
                else if (command == "/login")
                {
                    Authentication.Login();
                }
                else if (command == "/exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter Command :");
                }
            }
        }
    }
}
