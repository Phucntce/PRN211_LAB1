using System;
namespace PRN211_LAB1
{
    class Student : People
    {


        public Student() { }
        public Student(string id_card, string full_name, string birthday, string address, string email, string phone, string rollNo, string classNo)
        {
            ID_card = id_card;
            Full_name = full_name;
            Birthday = birthday;
            Address = address;
            Email = email;
            Phone = phone;
            RollNo = rollNo;
            ClassNo = classNo;

        }
        public Marks_Subject[] arr = new Marks_Subject[100];
        public string this[int index]
        {
            get
            {
                return arr[index].ToString();
            }
            set
            {
                arr[index].inputMarks();
            }
        }
        public string RollNo { get; set; }
        public string ClassNo { get; set; }

        public void inputStudent()
        {
            base.inputPeople();
            RollNo = CheckType.checkRollNo();
            ClassNo = CheckType.checkClassNo();
        }

        // public int calculateAvg()[
        //     int sum = 0;

        // ]
        public override void printInfo()
        {
            System.Console.WriteLine("Full Name: " + Full_name);
            System.Console.WriteLine("Birthday: " + Birthday);
            System.Console.WriteLine("RollNo: " + RollNo);
            System.Console.WriteLine("ClassNo: " + ClassNo);
        }

    }
}