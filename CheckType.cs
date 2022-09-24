using System;
using System.Text.RegularExpressions;
namespace PRN211_LAB1
{
    class CheckType
    {
        public static string checkIDCard()
        {
            while (true)
            {
                string id_card = Console.ReadLine();
                string strRegex = @"^[0-9]{9}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(id_card))
                {
                    return id_card;
                }
                else
                {
                    System.Console.WriteLine("Not valid Id Card");
                    System.Console.Write("Enter again: ");
                }
            }


        }

        public static string checkEmail()
        {
            while (true)
            {
                string email = Console.ReadLine();
                string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(email))
                {
                    return email;
                }
                else
                {
                    System.Console.WriteLine("Email is not valid!");
                    System.Console.Write("Enter again: ");
                }
            }


        }

        public static string checkInputAddress()
        {
            while (true)
            {
                string address = Console.ReadLine();
                if (String.IsNullOrEmpty(address))
                {
                    System.Console.WriteLine("Not empty");
                    System.Console.Write("Enter again: ");
                }
                else
                {
                    return address;
                }
            }
        }

        public static string checkInputPhone()
        {
            while (true)
            {
                string strRegex = @"^[0-0]{10}$";
                string phone = Console.ReadLine();
                Regex re = new Regex(strRegex);
                if (re.IsMatch(phone))
                {
                    return phone;
                }
                else
                {
                    System.Console.WriteLine("Not valid phone number!");
                    System.Console.Write("Enter again: ");
                }
            }
        }
    }
}