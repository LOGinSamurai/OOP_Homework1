using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework1
{
    public class main
    {
        public static void Main(String[] args)
        {
            //Task1
            Worker_task1 John = new Worker_task1();
            John.age = 25;
            John.name = "John";
            John.salary = 1000;


            Worker_task1 Sam = new Worker_task1();
            Sam.age = 26;
            Sam.name = "Sam";
            Sam.salary = 2000;

            Worker_task1.sumOfSalaryAndAge(John, Sam);

            //Task2
            Worker_task2 John_task2 = new Worker_task2();
            John_task2.setAge(25);
            John_task2.setName("John");
            John_task2.setSalary(1000);

            Worker_task2 Sam_task2 = new Worker_task2();
            Sam_task2.setAge(26);
            Sam_task2.setName("Sam");
            Sam_task2.setSalary(2000);

            Worker_task2.DisplaysumOfSalaryAndAge(John_task2, Sam_task2);
            Sam_task2.checkAge(0);
            Sam_task2.checkAge(101);
            Sam_task2.checkAge(50);
            Console.WriteLine("New age: "+Sam_task2.getAge());

            //Task from presentation
            Matrix neo = new Matrix();
            neo.generateNewMatrix();
            neo.GetSummOfDiagonalsElements();

            int[,] matrixOfIntegers = new int[,]{
                { 1, 0, 2},
                { 0, 0, 0},
                { 0, 0, 0} };

            Matrix triniti = new Matrix(matrixOfIntegers);
            triniti.GetSummOfDiagonalsElements();

            Matrix morfius = new Matrix();
            morfius.generateNewMatrix(1,10);
            morfius.GetSummOfDiagonalsElements();

        }



    }
    
}
