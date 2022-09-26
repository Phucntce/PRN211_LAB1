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
                string strRegex = @"^\w{9}$";
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

        public static string checkBirthDay(){
            while (true){
                string birthday = Console.ReadLine();
                string strRegex = @"^\b(0?[1-9]|[12]\d|3[01])[\/\-.](0?[1-9]|10|11|12)[\/\-.]((1\d{3})|(20[0-2]{2}))\b$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(birthday)){
                    return birthday;
                } else {
                    System.Console.WriteLine("Not valid birthday");
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

        public static string checkFullName(){
            while (true){
                string name = Console.ReadLine();
                string strRegex = @"^[a-zA-Z ]+$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(name)){
                    return name;
                } else {
                    System.Console.WriteLine("Not valid name!");
                    System.Console.Write("Enter again: ");
                }
            }
        }


        public static string checkInputPhone()
        {
            while (true)
            {
                string strRegex = @"^0[0-9]{9,10}$";
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

        public static int checkNumber (int min, int max){
            while (true){
                try {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result < min || result > max){
                        throw new Exception();
                    }
                    return result;
                } catch (Exception){
                    System.Console.WriteLine($"Please input number in range [{min}, {max}]");
                    System.Console.Write("Enter again: ");
                }
            }
        }

        public static string checkTeacherCode(){
            while(true){
                string teacherCode = Console.ReadLine();
                string strRegex = @"^([A]\d{4})|([B]\d{4})$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(teacherCode)){
                    return teacherCode;
                } else{
                    System.Console.WriteLine("Not valid teacher code!");
                    System.Console.Write("Enter again: ");
                }
            }
        }

        public static string checkRollNo(){
            while (true){
                string rollNo = Console.ReadLine();
                string strRegex = @"^A12[0-9]{2}[1-9]{1}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(rollNo))
                    return rollNo;
                else{
                    System.Console.WriteLine("Not valid Roll No. Roll No from A12001 - A12999");
                    System.Console.Write("Enter again: ");
                }
                    
            }
        }

        public static string checkClassNo(){
            while (true){
                string classNo = Console.ReadLine();
                string strRegex = @"^(CP|DI|DM)[1-9][0-9]{3}(0?[1-9]|11|12|10)(G|H|I|J|K|F|M)[a-zA-Z0-9]{2}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(classNo)){
                    return classNo;
                } else {
                    System.Console.WriteLine("Not valid Class No");
                    System.Console.Write("Enter again: ");
                }
            }
        }

        public static string checkSubjectCode (){
            while (true){
                string result = Console.ReadLine();
                string strRegex = @"^[A-Za-z]{6}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(result)){
                    return result;
                } else {
                    System.Console.WriteLine("Invalid subject code. The subject code must be 6 characters.");
                    System.Console.Write("Enter again: ");
                }
            }
        }

        public static string checkSubjectName(){
            while (true){
                string result = Console.ReadLine();
                string strRegex = @"^[A-Za-z0-9]{1,50}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(result) || !(String.IsNullOrEmpty(result))){
                    return result;
                } else {
                    System.Console.WriteLine("Invalid subject name!. The subject name has most 50 characters.");
                    System.Console.Write("Enter again: ");
                }
            }
        }

        public static string checkRollNoMarkSubject(){
            while(true){
                string result = Console.ReadLine();
                string strRegex = @"^A12[0-9]{3}$";
                Regex re = new Regex(strRegex);
                if (re.IsMatch(result)){
                    return result;
                } else {
                    System.Console.WriteLine("RollNo from A12001-A12999");
                    System.Console.Write("Enter again: ");
                }
            }
        }


    }
}