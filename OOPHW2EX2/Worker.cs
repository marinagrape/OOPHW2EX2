using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Make a Worker class that inherits from the User class and introduces an additional 
//private salary field, as well as public getSalary and setSalary methods.

//Create an object of this class 'Ivan', age 25, salary 1000.Create
//a second object of this class 'Vasya', age 26, salary 2000.
//Find the sum of Ivan's and Vasya's salaries.

namespace OOPHW2EX2
{
    class Worker : User
    {
 
        private int _salary;

        public Worker(string name, int age, int salary)
        {
            base._name = name;
            base._age = age;
            _salary = salary;
        }

        public void SetSalary(int salary)
        {
            _salary = salary;
        }
        public int GetSalary()
        {
            return _salary;

        }
    }
}
