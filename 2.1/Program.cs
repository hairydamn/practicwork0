using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номера билетов: ");
            for (int i = 1; i < 300; i++)
            {
                if (i >= 200 && i <= 210)
                {
                    Console.WriteLine(i);
                }
                else if (i >= 220 && i <= 235)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
