using System;
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
        public string TeacherCode { get; set; }
        public string JoinDate { get; set; }

        public override void printInfo()
        {
            
        }

        public void inputTeacher(){
            base.inputPeople();
            System.Console.Write("Enter teacher code: ");
            TeacherCode = CheckType.checkTeacherCode();
        }
    }
}