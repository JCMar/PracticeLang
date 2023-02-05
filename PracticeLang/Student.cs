using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLang
{
    internal class Student
    {
        private int id_number;
        private string name;
        private int age;
        private string course;
        public Student(int id_number, string name, int age, string course)
        {
            this.id_number = id_number;
            this.name = name;
            this.age = age;
            this.course = course;
        }
        public void displayInfo()
        {
            Console.WriteLine($"\nId Number: {this.id_number}");
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Age: {this.age}");
            Console.WriteLine($"Course: {this.course}");
        }
    }
}
