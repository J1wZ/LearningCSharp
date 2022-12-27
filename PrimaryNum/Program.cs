using System;

namespace PrimaryNum
{
    class Programm
    {
        static void IsPrymeNum()
        {
            bool ans = true;
            Console.WriteLine("Введите число  0 ≤ n ≤10000");
            int a = int.Parse(Console.ReadLine());
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    ans = false;
                }
            }
            if (ans)
            {
                Console.WriteLine($@"Число {a} простое!");
            }
            else
            {
                Console.WriteLine($@"Число {a} не является простым!");
            }
        }

        static void Main()
        {
            IsPrymeNum();
            Console.ReadKey();
        }
    }
}
