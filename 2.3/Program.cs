using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int eat = 40;
            int w = 100;
            int nw = 50;
            for (int i = 0; i <= 500; i++)
            {
                int e = eat * 10 * 2;
                int k = (w * 2) - (nw * 8);
                i = e + k;
                if (i <= 500)
                {
                    Console.WriteLine("Сумма затрат: " + i + " Отпуск оплачивается!");
                }
                else
                {
                    Console.WriteLine("Сумма затрат: " + i + " Отпуск не оплачивается!");
                }

            }
            Console.ReadKey();
        }
    }
}
