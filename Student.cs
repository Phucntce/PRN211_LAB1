using System;
namespace PRN211_LAB1 {
    class Student : People {
        public string RollNo { get; set; }
        public string ClassNo { get; set; }

        public void inputStudent() {
            base.inputPeople();
            
        }
        public override void printInfo (){

        }
        
    }
}