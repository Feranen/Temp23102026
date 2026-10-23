using System;
using System.Collections.Generic;
using System.Text;

namespace Objects2.Models
{
    public class Student
    {
        // Fields
        public string name;
        public int age;
        public double average;
        public string phone = "";
        // Methods
        public void ShowInfo()
        {
            Console.WriteLine($"{name}, tel: {phone}, wiek {age}, średnia: {average}");
        }
    }
}
