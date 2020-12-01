using System;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = rnd.Next(0, 20); 
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            int a1 = 0;
            int a2 = 0;
            int a3 = 0;
            int a4 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 0 && a[i] <= 4)
                { 
                    a1++;
                }

                else if (a[i] >= 5 && a[i] <= 9)
                { 
                    a2++; 
                }

                else if (a[i] >= 10 && a[i] <= 14)
                {
                    a3++; 
                }

                else if (a[i] >= 15 && a[i] <= 19)
                {
                    a4++; 
                }
            }

            Console.WriteLine("Электрического типа: " + a1);
            Console.WriteLine("Водяного типа: " + a2);
            Console.WriteLine("Земляного типа: " + a3);
            Console.WriteLine("Огненного типа: " + a4);
            Console.ReadKey();
        }
    }
}
