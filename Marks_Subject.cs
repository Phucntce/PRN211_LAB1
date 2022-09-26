using System;
namespace PRN211_LAB1
{
    class Marks_Subject : Mark, IMarks
    {
        public Marks_Subject() { }
        public Marks_Subject(string rollNo, string studentName, string subject, int testTime, int marks, int passLevel)
        {
            Marks = marks;
            PassLevel = passLevel;
            RollNo = rollNo;
            StudentName = studentName;
            Subject = subject;
            TestTime = testTime;
        }
        public string RollNo { get; set; }
        public string StudentName { get; set; }
        public string Subject { get; set; }
        public int TestTime { get; set; }

        public void inputInfo()
        {
            System.Console.Write("Enter RollNo: ");
            RollNo = CheckType.checkRollNoMarkSubject();
            System.Console.Write("Enter Student Name: ");
            StudentName = CheckType.checkFullName();
            System.Console.Write("Enter Subject Name: ");
            Subject = CheckType.checkSubjectName();
            System.Console.Write("Enter Test Time: ");
            TestTime = CheckType.checkNumber(1, 4);
        }
        public void inputMarks()
        {
            System.Console.Write("Enter marks: ");
            Marks = CheckType.checkNumber(0, 100);
        }

        public void printMarks()
        {
            System.Console.WriteLine(ToString());
        }
        

        public override bool getBonus()
        {
            return true;
        }

        public override string ToString()
        {
            string tmp = "";
            if (checkPass()){
                tmp+= "\nStatus: Passed";
            } else {
                tmp+= "\nStatus: Not Pass";
            }
            return $"Student name: {StudentName}\nSubject name: {Subject}\nMarks: {Marks}{tmp}";
        }
    }
}