// Домашка из файла + домашка из преезнтации(реворк прошлой дз под классы и методы)
public class Worker
{
   /*в первой части тут public и соответственно нет геттреов и сеттеров*/ private string name;
   /*в первой части тут public и соответственно нет геттреов и сеттеров*/ private int age;
   /*в первой части тут public и соответственно нет геттреов и сеттеров*/ private float salary;

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
    //перергрузка метода чекЭйдж
    public void checkAge(float value)
    {
        if (value is float)
        {
            Console.WriteLine("the age is incorrect");
        }
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
        if (value != null)
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
        if (value != null)
        {
            salary = value;
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

    // реворк диагонлаей матриц под классы
    public class Matrix {

    public int[,] matrixOfIntegers ;

    public Matrix()
    {
        matrixOfIntegers = new int[,]{
                { 1, 0, 4},
                { 0, 2, 0},
                { 5, 0, 3} };
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
public class Program {
    public static void Main(String[] args)
    {
        Matrix matrix = new Matrix();
        matrix.GetSummOfDiagonalsElements();
            //зкаоментил первую часть что бы проверить вторую и третью
            /*  Worker John = new Worker();
              Worker Sam = new Worker();
              John.age = 25;
              John.name = "John";
              John.salary = 1000;
              Sam.age = 26;
              Sam.name = "Sam";
              Sam.salary = 2000;
              Console.WriteLine("summ of slaries: "+(John.salary+Sam.salary));
              Console.WriteLine("summ of ages: "+(John.age+Sam.age));*/

            Worker John = new Worker();
            John.setAge(25);
            John.setName("John");
            John.setSalary(1000);

            Worker Sam = new Worker();
            Sam.setAge(26);
            Sam.setName("Sam");
            Sam.setSalary(2000);

            Console.WriteLine("Sum of sallaries: "+ (John.getSalary()+Sam.getSalary()));
            Console.WriteLine("Sum of ages: " + (John.getAge() + Sam.getAge()));
            Sam.checkAge(101);
            Sam.checkAge(100);
            Console.WriteLine("Sams age: " + Sam.getAge());
            Sam.checkAge(99.5F);
        }
    }
}
