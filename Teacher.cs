using System;
using System.Collections.Generic;
namespace PRN211_LAB1
{
    class Teacher : People
    {

        public Teacher()
        {

        }

        public Teacher(string id_card, string full_name, string birthday, string address, string email, string phone, string teacherCode, string joinDate)
        {
            ID_card = id_card;
            Full_name = full_name;
            Birthday = birthday;
            Address = address;
            Email = email;
            Phone = phone;
            TeacherCode = teacherCode;
            JoinDate = joinDate;
        }
        Subject[] arr = new Subject[100];
        public string this[int index]
        {
            get
            {
                return arr[index].ToString();
            }
            set
            {
                arr[index].inputSubject();
            }
        }
        public DateTime Odate { get; set; }
        public string TeacherCode { get; set; }
        public string JoinDate { get; set; }

        public override void printInfo()
        {
            System.Console.WriteLine("Full Name: " + Full_name);
            System.Console.WriteLine("Number Of Year Old: " + getAge());
            System.Console.WriteLine("Teacher Code: " + TeacherCode);
            System.Console.WriteLine("Joined Date: " + JoinDate);
        }

        public void inputTeacher()
        {
            base.inputPeople();
            System.Console.Write("Enter teacher code: ");
            TeacherCode = CheckType.checkTeacherCode();
            JoinDate = CheckType.checkBirthDay();
            Odate = Convert.ToDateTime(JoinDate);
        }


        public int getWorkedYear()
        {
            var today = DateTime.Today;
            return today.Year - Odate.Year;
        }
    }
}