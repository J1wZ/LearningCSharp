using System;

namespace Arrow
{
    class Programm
    {
        static void GoArrow()
        {
            var key = Console.ReadKey(true).Key;
            Console.Clear();
            switch(key)
            {
                case ConsoleKey.DownArrow:
                    Console.WriteLine($@"|
V");
                    break;
                case ConsoleKey.UpArrow:
                    Console.WriteLine($@"/\
|");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine($@"<-");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("->");
                    break;
                default: Console.WriteLine("Используйте стелки");break;
            }
            GoArrow();
        }

        static void Main()
        {
            GoArrow();

        }
    }
}
