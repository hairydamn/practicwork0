using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во ящиков: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int ct;
            int c;
            int a = 1;
            int d = 1;

            if (b % 27 == 0)
            {
                ct = b / 27;
            }
            else
            {
                ct = b / 27 + 1;
            }

            if (ct % 12 == 0)
            {
                c = ct / 12 + 1;
            }
            else
            {
                c = ct / 12 + 1;
            }

            for (int i = 1; i <= c; i++)
            {
                Console.WriteLine("Грузовик: " + i);
                int j = 0;
                while (j < 12 && d <= ct)
                {
                    Console.WriteLine("\tКонтейнер: " + d);
                    int k = 0;
                    while (k < 27 && a <= b)
                    {
                        Console.WriteLine("\tЯщик: " + a);
                        k++;
                        a++;
                    }
                    j++;
                    d++;
                }
                Console.ReadKey();
            }
        }
    }
}
