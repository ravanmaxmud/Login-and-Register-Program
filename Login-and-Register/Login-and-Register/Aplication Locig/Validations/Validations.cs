using Login_and_Register.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Login_and_Register.Aplication_Locig
{
    class Validations
    {
        public static bool IsLenghtBetween(string text, int start, int end)
        {
            return text.Length >= start && text.Length <= end;
        }
        public static bool IsConsistLetter(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z]+$");
        }
        public static bool IsFirstCharacterToUpper(string text)
        {
            return Regex.IsMatch(text, @"^[A-Z]{1,1}");
        }
        public static bool IsMailTrue(string mail)
        {
            return Regex.IsMatch(mail, @"^[a-zA-Z0-9_?.?]{0,18}@code\.edu\.az");
        }
        public static bool IsPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
        }
    }
}
