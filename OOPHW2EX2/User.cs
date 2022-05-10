using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Make a User class, which will have the following protected 
//fields - name(name), age(age), public methods setName, getName,
//setAge, getAge.

namespace OOPHW2EX2
{
    class User
    {
        protected string _name;
        protected int _age;


        public void SetName(string name)
        {
            _name = name;
        }

        public void GetName()
        {
            Console.WriteLine(_name);
        }

        public void SetAge(int age)
        {
            _age = age;
        }

        public void GetAge()
        {
            Console.WriteLine(_age);

        }
    }
}
