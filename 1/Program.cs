using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Внесите сумму... ");
            int st = Convert.ToInt32(Console.ReadLine());
            if (st >= 50)
            {
                Console.WriteLine("Вы сможете купить воду, чай, латте и эспрессо ");
            }
            else if (st >= 40 && st < 50)
            {
                Console.WriteLine("Вы сможете купить воду, чай и эспрессо ");
            }
            else if (st >= 30 && st < 40)
            {
                Console.WriteLine("Вы сможете купить воду и чай ");
            }
            else if (st >= 20 && st < 30)
            {
                Console.WriteLine("Вы сможете купить воду ");
            }
            else
            {
                Console.WriteLine("Вы ничего не сможете купить ");
            }
            Console.ReadKey();
        }
    }
}
