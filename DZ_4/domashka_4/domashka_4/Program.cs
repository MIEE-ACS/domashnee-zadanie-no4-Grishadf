using System;

namespace domashka_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количсевто элементов в матрице : ");
            int N = int.Parse(Console.ReadLine());
            double[] a = new double[N];

            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                Random rnd = new Random();
                int st = rnd.Next(0, 2);

                a[i] = random.NextDouble() * 100 * Math.Pow(-1, st); // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
                Console.Write("{0,8:F2}", a[i]);
            }
            Console.WriteLine("\n");


            MaxModulElem(a); 

            SumPositiv(a);

            ConvertArray(a);

        }



        static double max = 0;
        static int k = 0;
        static void MaxModulElem(double[] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)   // В for с помощью функции C# узнаём длину массива
            {
                if ( Math.Abs(a[i]) > max )
                {
                    max = Math.Abs(a[i]);
                    k = i + 1;
                }
            }

            Console.Write($"Номер большего по модулю элемента : {k}");
        }


        static int num = 0;   // Номер положительного элемента
        static double sum = 0;
        static void SumPositiv(double[] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i] > 0)
                {
                    num = i + 1;
                    break;
                }
            }

            for (int i = num; i < a.GetLength(0); i++)
            {
                sum += a[i]; 
            }

            Console.Write($"Первый положительный элемент : {a[num-1]}");
            Console.Write("\n");

            Console.Write($"Сумма элементов после 1-ого положительного элемента : {sum}");
            Console.Write("\n\n");
        }



        static void ConvertArray(double[] a)
        {
            Console.Write("Введите начало интервала : ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введите конец интервала : ");
            int finish = int.Parse(Console.ReadLine());


            double[] sosi = new double[a.GetLength(0)];
            int j = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if ( (Math.Truncate(a[i]) >= start) & (Math.Truncate(a[i]) <= finish) )
                {
                    sosi[j] = a[i];
                    a[i] = 0;
                    j++;
                                        
                }

            }


            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i] != 0)
                {
                    sosi[j + i] = a[i];
                }
                else
                {
                    j--;
                }
            }


            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write("{0,8:F2}", sosi[i]);
            }
            Console.WriteLine("\n");

        }



    }
}
