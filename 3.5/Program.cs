using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = rnd.Next(1, 1000); 
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            int max = a.Max();
            int min = a.Min();

            Console.WriteLine(max);
            Console.WriteLine(min);

            Console.ReadKey();
        }
    }
}
