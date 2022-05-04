using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework1
{
    public class Worker_task2
    {

        private string name;
        private int age;
        private float salary;

        public Worker_task2() 
        {
        name = "John Doe";
        age = 1;
        salary = 1;
        }

        public Worker_task2(string name,int age, float salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string value)
        {
            if (value != null)
            {
                name = value;
            }
        }

        public int getAge()
        {
            return age;
        }
        public void setAge(int value)
        {
            if (value != 0)
            {
                age = value;
            }
        }

        public float getSalary()
        {
            return salary;
        }
        public void setSalary(int value)
        {
            if (value != 0)
            {
                salary = value;
            }
        }

        public static void DisplaysumOfSalaryAndAge(Worker_task2 obj1, Worker_task2 obj2)
        {
            Console.WriteLine("|Sum of sallaries: " + (obj1.getSalary() + obj2.getSalary()) + "|");
            Console.WriteLine("|Sum of ages: " + (obj1.getAge() + obj2.getAge()) + "|");
        }

        public void checkAge(int value)
        {
            if (value > 100 || value < 1)
            {
                Console.WriteLine("the age is incorrect");
            }
            else
            {
                setAge(value);
            }
        }

        //Альтеранативные варинаты геттера и сеттера
        /*  public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public float Salary { get => salary; set => salary = value; }
        */

        //еще один вариант геттера и сеттера

        /*    public float Salary
            {
                get
                {
                    return salary;
                }

                set
                {
                    if (value > 0)
                    {
                        salary = value;
                    }
                }
            }
            public int Age
            {
                get
                {
                    return age; 
                }

                set
                {
                    if (value > 0)
                    {
                        age = value;
                    }
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    if (value != null)
                    {
                        name = value;
                    }
                }
            }

        }*/

    }
}
