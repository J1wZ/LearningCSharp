using System;

namespace PrimaryNum
{
    public class Programm
    {
        public static void MakeThatNum()
        {
            Console.WriteLine("Введите число  0 ≤ n ≤10000");
            int a = int.Parse(Console.ReadLine());
            if (IsPrimeNum(a))
            {
                Console.WriteLine($@"Число {a} простое!");
            }
            else
            {
                Console.WriteLine($@"Число {a} не является простым!");
            }
            Console.ReadKey();
        }

        public static bool IsPrimeNum(int a)
        {
            bool ans = true;
            
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    ans = false;
                }
            }
            return ans;
            
        }

        static void Main()
        {
            MakeThatNum();
        }
    }
}
