using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.2 Make a Student class that inherits from the User class 
//and introduces additional private fields scholarship, course,
//and a method that will display them.

namespace OOPHW2EX2
{
    class Student : User
    {
        private int _scholarship;
        private string _course;

        public Student(string name, int age, int money, string course)
        {
            _scholarship = money;
            _course = course;
            base._name = name;
            base._age = age;
        }

        public void PrintStudent()
        {
            Console.WriteLine("Student's info: Name: " + _name + "\nCourse: " + _course + "\nScloarship EUR = " + _scholarship);
        }
    }
}
