using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Mouse : AbsAnimal
    {
        public Mouse(string n, Food f, string v) : base(n,f,v)
        {

        }

        private int BoxNum()
        {
            Random random = new Random();
            int v = random.Next(0,2);
            return v;
        }
        public override void Play()
        {
            Console.WriteLine($@"
Прятки
Выбирите одну из трех коробок и найдите свою мышь.
Напишите 1 , 2 или 3 :");
            int v = BoxNum();
            var key = Console.ReadKey(true).Key;
            bool flag = false;
            switch(key)
            {
                case ConsoleKey.D1:
                    if (v == 0)
                    {
                        flag = true;
                    }
                    break;
                case ConsoleKey.D2:
                    if (v == 1)
                    {
                        flag = true;
                    }
                    break;
                case ConsoleKey.D3:
                    if (v == 2)
                    {
                        flag = true;
                    }
                    break;
                default:
                    Console.WriteLine("Введите число ещё раз.");
                    Play();
                    break;
            }
            if (flag)
            {
                Console.WriteLine($@"
Вы открываете коробку. И оттуда на вас выпригывает {Name}!
Поздравляю! Вы выиграли и немного испугались.");
                Score += 30;
            }
            else
            {
                Console.WriteLine($@"
Вы открываете коробку. И там нет {Name}! Только пыль.
Поздравляю! Вы проиграли и потеряли 10 очков.");
                Score -= 10;
            }
        }
    }
}
