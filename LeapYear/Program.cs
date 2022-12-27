using System;

namespace LeapYear
{
    class Programm
    {
        static void IsLeapYear()
        {
            Console.WriteLine("Введите год в формате YYYY");
            int a = int.Parse(Console.ReadLine());
            if (((a % 4==0)&&!(a % 100 ==0)) || (a % 400 == 0))
            {
                Console.WriteLine($@"Год {a} високосный!");
            }
            else
            {
                Console.WriteLine($@"Год {a} не является високосным!");
            }
        }

        static void Main()
        {
            IsLeapYear();
            Console.ReadKey();
        }
    }
}
