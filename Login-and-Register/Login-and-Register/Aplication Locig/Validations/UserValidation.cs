using Login_and_Register.DataBase.Repostery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_and_Register.Aplication_Locig
{
     class UserValidation
    {
        public static bool IsNameCorrect(string firstName)
        {
            if (Validations.IsLenghtBetween(firstName,3,30) && Validations.IsConsistLetter(firstName) && Validations.IsFirstCharacterToUpper(firstName))
            {
                return true;
            }
            Console.WriteLine("Daxil etdiyiniz ad yanlışdır, adın yalnız hərflərdən ibarət olduğuna, ilk hərfin böyük olduğuna və uzunluğunun 3 dən böyük, 30 - dan kiçik olduğuna əmin olun.");
            return false;
        }
        public static bool IsLastNNameCorrect(string lastName)
        {
            if (Validations.IsLenghtBetween(lastName, 3, 30) && Validations.IsConsistLetter(lastName) && Validations.IsFirstCharacterToUpper(lastName))
            {
                return true;
            }
            Console.WriteLine("Daxil etdiyiniz soyad yanlışdır, soyadın yalnız hərflərdən ibarət olduğuna, ilk hərfin böyük olduğuna və uzunluğunun 3 dən böyük, 30 - dan kiçik olduğuna əmin olun.");
            return false;
        }
        public static bool IsMailCorrect(string mail)
        {
            if (Validations.IsMailTrue(mail) && UserRepo.IsMailUnical(mail))
            {
                return true;
            }
            Console.WriteLine("Daxil etdiyiniz mail yanlisdir Xais Olunur Yeniden Chet Edin");
            return false;
        }
        public static bool IsPasswordCorrect(string password)
        {
            if (Validations.IsPassword(password))
            {
                return true;
            }
            Console.WriteLine("Daxil Etdiyiniz Sifre Ynalisdir Xais Olunur Yeniden Ceht Edin");
            return false;
        }
        public static bool IsValidPassword(string password ,string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }
            Console.WriteLine("Daxil Etdiyiniz Sifre Uyqunlasmadi Xais Olunur Yeniden Ceht Edin");
            return false;

        }
        public static bool IsLoginCorrect(string email ,string password)
        {
            if (UserRepo.IsUserExistByEmailAndPassword(email ,password))
            {
                return true;
            }
            Console.WriteLine("Xais Olunur Yeniden Ceht Edin");
            return false;
        }

    }
}
