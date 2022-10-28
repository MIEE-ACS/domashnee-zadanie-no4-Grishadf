using System;

namespace domashka_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Количество строк : ");
            int M = int.Parse(Console.ReadLine());

            Console.Write("Количество столбцов : ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите значение, с которым удете сравнивать среднее арифметическое строк : ");
            int val = int.Parse(Console.ReadLine());



            // ---------- Задаём матрицу с рандомными значениями ----------
            /*
            Random rnd = new Random();
            int[,] a = new int[M, N];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next() / 100000000;
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }   */



            // ---------- Вводим матрицу ---------- 
            Console.WriteLine("Введите значения матрицы : ");
            double[,] a = new double[M, N];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine());
                }
                
            }


            // ---------- Печатаем матрицу ---------- 
            Console.WriteLine("\nИсходная матрица");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            
            ArithmeticMean(a, val);
           
            GaussMethod(a);
            Console.Read();
        }



        static void GaussMethod(double[,] matr)
        {
            Console.WriteLine("Матрица приведённая к треугольному виду");

            double[,] mass = matr;
            for (int i = 0; i < mass.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < mass.GetLength(0); j++)
                {
                    double koef = mass[j, i] / mass[i, i];
                    for (int k = i; k < mass.GetLength(0); k++)
                        mass[j, k] -= mass[i, k] * koef;
                }
            }
                

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write($"{mass[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

        }



        static int n = 0;
        
        static void ArithmeticMean(double[,] matr, int val)
        {
            
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                double sum = 0;
                int k = 0;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    sum += matr[i,j];
                    k++;
                }
                if (sum/k < val)
                {
                    n++;
                }
            }

            Console.WriteLine($"Количество строк сред. арифм. элементов которых меньше заданной величины: {n}");
        }

    }
}
