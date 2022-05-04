using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework1
{
    public class Matrix
    {

        public int[,] matrixOfIntegers;

        public Matrix()
        {
            matrixOfIntegers = new int[,]{
                { 0, 0, 0},
                { 0, 0, 0},
                { 0, 0, 0} };
        }
        public Matrix(int[,] matrixOfIntegers)
        {
            this.matrixOfIntegers = matrixOfIntegers;
        }

        public void generateNewMatrix()
        {
            int n = matrixOfIntegers.GetLength(0);
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this.matrixOfIntegers[i, j] = rnd.Next(-100, 100);
                }
            }
        }
        //example of overloading
        public void generateNewMatrix(int from, int to)
        {
            int n = matrixOfIntegers.GetLength(0);
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    this.matrixOfIntegers[i, j] = rnd.Next(from, to);
                }
            }
        }


        public void GetSummOfDiagonalsElements()
        {
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                int temp1 = 0;
                int temp2 = 0;
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if (i == j) { temp1 += matrixOfIntegers[i, j]; }
                    }
                }
                //на самом деле не важно гет ленгтх 1 или 0 ибо для наличия диагонали строки и столбцы должны сопадать :)
                for (int i = matrixOfIntegers.GetLength(0) - 1; i >= 0; i--)
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if ((i + j) == (matrixOfIntegers.GetLength(0) - 1))
                        {

                            temp2 += matrixOfIntegers[i, j];
                            /*Console.WriteLine("temp2:"+ temp2 + " i:" + i + " j:" + j);*/
                        }
                    }
                }

                Console.WriteLine("First diagonal: " + temp1);
                Console.WriteLine("Second diagonal: " + temp2);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have diogonals");
            }


        }
    }
}
