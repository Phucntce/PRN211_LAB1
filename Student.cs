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
        // public static int Size { get; set; }

        private int[] marks;
        public int[] Marks { get; set; }

        public int this[int index]
        {
            get => Marks[index];
            set => Marks[index] = value;
        }
        public string RollNo { get; set; }
        public string ClassNo { get; set; }

        public void calAvg()
        {
            System.Console.Write("Enter numer of mark: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Marks = new int[size];
            for (int i = 0; i < size; i++)
            {
                System.Console.Write($"Enter mark {i+1}: ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum+= Marks[i];
            }
            double avg = sum/size;
            System.Console.WriteLine($"Avg: {avg}");


        }

        // public void inputMark(){
        //     System.Console.Write("Enter number of mark: ");
        //     int sz = Convert.ToInt32(Console.ReadLine());
        //     for (int i = 0; i < sz; i++){
        //         System.Console.WriteLine($"Enter mark {i}: ");
        //         Marks[i] = Convert.ToInt32(Console.ReadLine());
        //     }

        //     int sum = 0;
        //     for (int i = 0; i < sz; i++){
        //         sum+= Marks[i];
        //     }
        //     System.Console.WriteLine($"The average of mark is: {sum/sz}");
        // }
        public void inputStudent()
        {
            base.inputPeople();
            System.Console.Write("Enter Roll No: ");
            RollNo = CheckType.checkRollNo();
            System.Console.Write("Enter Class No: ");
            ClassNo = CheckType.checkClassNo();
        }

        public override void printInfo()
        {
            System.Console.WriteLine("Full Name: " + Full_name);
            System.Console.WriteLine("Birthday: " + Birthday);
            System.Console.WriteLine("RollNo: " + RollNo);
            System.Console.WriteLine("ClassNo: " + ClassNo);
        }

    }
}