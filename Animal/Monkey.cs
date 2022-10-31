using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Monkey : AbsAnimal
    {
        public Monkey(string n, Food f, string v) : base(n, f, v)
        {

        }

        private int RPS(int a)
        {
            Random random = new Random();
            int v = random.Next(1, 4);
            if (v == a)
            {
                return 1;
            }
            else
            {
                if(v + a == 4)
                {
                    if (v == 3 && a == 1)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else if (v < a)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }

            }
        }
        public override void Play()
        {
            Console.WriteLine($@"
Камень, ножницы, бумага
Выбирите Камень, Ножницы или Бумагу.
1. Камень
2. Ножницы
3. Бумага");
            var key = Console.ReadKey(true).Key;
            int Res = -1;
            switch (key)
            {
                case ConsoleKey.D1:
                     Res= RPS(1);
                    break;
                case ConsoleKey.D2:
                    Res = RPS(2);
                    break;
                case ConsoleKey.D3:
                    Res = RPS(3);
                    break;
                default:
                    Console.WriteLine("Введите число ещё раз.");
                    Play();
                    break;
            }
            switch(Res)
            {
                case 1:
                    Score += 10;
                    Console.WriteLine($"Вы и {Name} выбрали одинаковые ответы. Ничья!");
                    break;
                case 0:
                    Score -= 10;
                    Console.WriteLine($"Вы проиграли {Name}!");
                    break;
                case 2:
                    Score += 30;
                    Console.WriteLine($"Вы победили {Name}!");
                    break;
                default:
                    Console.WriteLine("Что-то пошло не так.");
                    break;
            }
        }
    }
}
