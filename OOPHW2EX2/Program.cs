using System;
////Create an object of this class 'Ivan', age 25, salary 1000.Create
//a second object of this class 'Vasya', age 26, salary 2000.
//Find the sum of Ivan's and Vasya's salaries.
namespace OOPHW2EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("John", 25, 1000);
            Worker worker2 = new Worker("Ivan", 25, 1000);
            Worker worker3 = new Worker("Vasya", 26, 2000);
            Student student1 = new Student("Lola", 20, 800, "Biology");


            //worker3.SetName("Vasya");
            //worker3.SetAge(26);
            //worker3.SetSalary(2000);

            Console.WriteLine("The sum of Ivan and Vasya's salaries: " + (worker2.GetSalary() + worker3.GetSalary()));
            Console.WriteLine("_________________");
            student1.PrintStudent();
        }
    }
}
