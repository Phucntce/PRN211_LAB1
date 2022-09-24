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
    }
}