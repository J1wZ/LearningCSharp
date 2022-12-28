using System;

namespace LeapYear
{
    public class Programm
    {

        public static void Leap()
        {
            Console.WriteLine("Введите год в формате YYYY");
            int a = int.Parse(Console.ReadLine());
            if (IsLeapYear(a))
            {
                Console.WriteLine($@"Год {a} високосный!");
            }
            else
            {
                Console.WriteLine($@"Год {a} не является високосным!");
            }
            Console.ReadKey();
        }
        public static bool IsLeapYear(int a)
        {
            if (a >=0 && (((a % 4==0)&&!(a % 100 ==0)) || (a % 400 == 0)))
            {
                return true;
                
            }
            else
            {
                return false;
                
            }
        }

        static void Main()
        {
            Leap();
        }
    }
}
