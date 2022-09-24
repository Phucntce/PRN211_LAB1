using System;


namespace PRN211_LAB1
{
    abstract class People
    {
        public People() { }


        public People(string id_card, string full_name, string birthday, string address, string email, string phone)
        {
            ID_card = id_card;
            Full_name = full_name;
            Birthday = birthday;
            Address = address;
            Email = email;
            Phone = phone;
        }
        public string ID_card { get; set; }
        public string Full_name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Id card: {ID_card}, Full Name: {Full_name}, BirthDay: {Birthday}, Address: {Address}, Email: {Email}, Phone: {Phone}";
        }

        public void inputPeople()
        {
            System.Console.Write("Enter ID card: ");
            ID_card = CheckType.checkIDCard();
            System.Console.Write("Enter Full Name: ");
            Full_name = Console.ReadLine();
            System.Console.Write("Enter BirthDay (mm/dd/yyyy): ");
            Birthday = Console.ReadLine();
            DateTime dt = DateTime.Parse(Birthday);
            System.Console.Write("Enter Adress: ");
            Address = CheckType.checkInputAddress();
            System.Console.Write("Enter Email: ");
            Email = CheckType.checkEmail();
            System.Console.Write("Enter Phone: ");
            Phone = CheckType.checkInputPhone();
        }

        public abstract void printInfo();
        
    }
}