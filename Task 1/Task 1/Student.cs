using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Student
    {
        public static string schoolName = "Ithari International College";
        public string Name;
        public int Age;
        public string Grade;
        public Student(string name, int age, string grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }
}
