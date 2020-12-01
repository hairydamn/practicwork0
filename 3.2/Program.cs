using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = rnd.Next(1, 20); 
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                int l = a[i] + 10;
                a[i] = rnd.Next(1, 20);
                Console.Write(l + " ");
            }

            Console.ReadKey();
        }
    }
}
