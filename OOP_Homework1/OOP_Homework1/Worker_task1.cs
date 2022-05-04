using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework1
{

    public class Worker_task1
    {
        public string name;
        public int age;
        public float salary;

        public static void sumOfSalaryAndAge(Worker_task1 obj1, Worker_task1 obj2)
        {
                Console.WriteLine("|Sum of ages: " + (obj1.age+obj2.age) + "| |Sum of salary: " + (obj1.salary+obj2.salary)+ "|");
        }
    }

  

}