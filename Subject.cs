using System;
namespace PRN211_LAB1 {
    class Subject {
        public Subject (){

        }
        
        public Subject (string subjectCode, string subjectName, int theory, int practice){
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Theory = theory;
            Practice = practice;
        }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int Theory { get; set; }
        public int Practice { get; set; }

        public int getTotalLessons(){
            return Theory + Practice;
        }

        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}\nSubject Name: {SubjectName}\nTheory: {Theory}\nPractice: {Practice}\nTotal number of lesson: {getTotalLessons()}";
        }
        
        public void inputSubject (){
            System.Console.Write("Enter subject code: ");
            SubjectCode = CheckType.checkSubjectCode();
            System.Console.Write("Enter subject name: ");
            SubjectName = CheckType.checkSubjectName();
            System.Console.Write("Enter theory: ");
            Theory = CheckType.checkNumber(0, 100);
            System.Console.Write("Enter practice: ");
            Practice = CheckType.checkNumber(0, 100);
        }

        public void printInfo(Subject s){
            Console.WriteLine(s.ToString());
        }
    }
}