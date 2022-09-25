using System;
namespace PRN211_LAB1
{
    class Student : People
    {
        static public int size =10;
        private int[] marks = new int[size];
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
        public int this[int index]
        {
            get { 
                int tmp = 0;
                if (index >= 0 && index < size - 1{
                    tmp = marks[index];
                }
                return tmp;
             }
            set { 
                if (index >= 0 && index < size - 1){
                    marks[index] = value;
                }
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

        public int calculateAvg(){
            int sum = 0;
            for (int i = 0; i < size - 1; i++){
                sum+= marks[i];
            }
            return sum / size;
        }
        public override void printInfo()
        {
            
        }

    }
}