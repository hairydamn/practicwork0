using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k1 = 1;
            int k2 = 1;
            for (int i = 20000; i <= 5409314; i++)
            {
                if (i % 2 == 0)
                {
                    k1++;
                }
                else
                {
                    k2++;
                }
            }
            Console.WriteLine("Количество билетов на 'Alai Oli': " + k1);
            Console.WriteLine("Количество билетов на 'Торба на круче': " + k2);
            Console.ReadKey();
        }
    }
}
