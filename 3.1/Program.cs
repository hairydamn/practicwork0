using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++) 
            {
                a[i] = rnd.Next(1, 15); 
                Console.Write(a[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
