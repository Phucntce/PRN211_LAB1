using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace PRN211_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = printMenu();
                switch (choice)
                {
                    case 1:
                        Student t = new Student();
                        t.inputStudent();
                        t.printInfo();
                        System.Console.WriteLine();
                        break;
                    case 2:
                        Teacher te = new Teacher();
                        te.inputTeacher();
                        te.printInfo();
                        System.Console.WriteLine();
                        break;
                    case 3:
                        Subject s = new Subject();
                        s.inputSubject();
                        s.printInfo();
                        System.Console.WriteLine();
                        break;
                    case 4:
                        Marks_Subject m = new Marks_Subject();
                        m.inputInfo();
                        m.inputMarks();
                        System.Console.WriteLine(m.ToString());
                        System.Console.WriteLine();
                        break;
                    case 5:
                        System.Console.WriteLine("Thank for using my application!");
                        System.Console.WriteLine("Good Bye! See You Again!");
                        return;
                }
                
            }

        }

        public static int printMenu()
        {
            System.Console.WriteLine("1. Manage student.");
            System.Console.WriteLine("2. Manage teacher.");
            System.Console.WriteLine("3. Manage Subject.");
            System.Console.WriteLine("4. Manage Marks.");
            System.Console.WriteLine("5. Exit.");
            System.Console.Write("Enter your choice: ");
            int option = CheckType.checkNumber(1, 5);
            return option;
        }
    }
}

