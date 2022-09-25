using System;
namespace PRN211_LAB1{
    abstract class Mark {
        public int Marks { get; set; }
        public int PassLevel { get; set; }

        public bool checkPass(){
            if (Marks >= 40 && Marks <= 100)
                return true;
            else
                return false;
        }

        public abstract bool getBonus();
    }
}