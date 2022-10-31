using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Raven : AbsAnimal
    {
        public Raven(string n, Food f, string v) : base(n, f, v)
        {

        }

        private bool MoreOrLess(int a, int v)
        {
            int b = Rando();
            while (v == b)
            {
                b = Rando();
            }
            if(a == -1)
            {
                if (b < v)
                {
                    return true;   
                }
                else
                {
                    return false;
                }                
            }
            else
            {
                if (b > v)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private int Rando()
        {
            Random random = new Random();
            return random.Next(1, 10);
        }

        public override void Play()
        {
            Console.WriteLine($@"
Меньше или больше
На экране будет показано число и вам нужно угадать следующиее число будет больше или меньше.
1. Меньше
2. Больше");
            Random random = new Random();
            int v = random.Next(1, 11);
            Console.WriteLine($"Число:{v}");
            var key = Console.ReadKey(true).Key;
            bool flag = false;
            switch (key)
            {
                case ConsoleKey.D1:
                    flag = MoreOrLess(-1,v);
                    break;
                case ConsoleKey.D2:
                    flag = MoreOrLess(100,v);
                    break;
                default:
                    Console.WriteLine("Введите число ещё раз.");
                    Play();
                    break;
            }
            if (flag)
            {
                Score += 30;
                Console.WriteLine($@"Вы выбрали правильный вариант! Вау!");
            }
            else
            {
                Score -= 10;
                Console.WriteLine($@"{Name} перехетрил вас! Вы проиграли!");
            }
        }
    }
}
