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
                        System.Console.WriteLine("1. Input student.");
                        System.Console.WriteLine("2. Calculate average mark and display information");
                        System.Console.WriteLine();
                        break;
                    case 2:
                        System.Console.WriteLine("1. Input teacher.");
                        System.Console.WriteLine("2. Display the number of year that the teacher has worked");
                        break;
                    case 3:
                        System.Console.WriteLine("1. Input subject");
                        System.Console.WriteLine("2. Calculate total number of lesson");
                        break;
                    case 4:
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

