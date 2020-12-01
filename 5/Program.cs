using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние между рядами в см: ");

            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите расстояние между дырочками в ряду в см: ");

            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество дырочек в ряд: ");

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите длину свободного конца шнурка в см: ");

            int a2 = Convert.ToInt32(Console.ReadLine());

            int a3 = (a2 * 2 + (b - 1) * 2 * (a + a1) + a);

            Console.WriteLine("Длина шнурка ботинка: " + a3 + " см");
            Console.ReadKey();
        }
    }
}
