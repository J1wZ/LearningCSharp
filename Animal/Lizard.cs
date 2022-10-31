using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Lizard : AbsAnimal
    {
        public Lizard(string n, Food f, string v) : base(n, f, v)
        {

        }

        private int Rando()
        {
            Random random = new Random();
            return random.Next(1, 5);
        }

        private bool Stuff(int a)
        {
            bool cup = false; 
            switch(a)
            {
                case 1:
                    Console.WriteLine($@"Ящерицы живут на всех материках и островах мира, за иключением Антарктиды.");
                    cup = true;
                    break;
                case 2:
                    Console.WriteLine($@"Только три вида ящериц являются ядовитыми.");
                    cup = false;
                    break;
                case 3:
                    Console.WriteLine($@"У ящериц есть третий глаз.");
                    cup = true;
                    break;
                case 4:
                    Console.WriteLine($@"Ящерицы могут дастигать до 5 метров в длину.");
                    cup = false;
                    break;
                default:
                    Console.WriteLine("Произошла ощибка");
                    break;
            }
            return cup;
        }

        public override void Play()
        {
            Console.WriteLine($@"
Правда или Чушь?
Вам будет представлен факт о ящерицах и вам нужно выбрать Правда ли это.
1. Правда
2. Чушь");
            int a = Rando();
            bool flag = Stuff(a);
            var key = Console.ReadKey(true).Key;
            bool flag1 = false;
            switch (key)
            {
                case ConsoleKey.D1:
                    flag1 = true;
                    break;
                case ConsoleKey.D2:
                    flag1 = false;
                    break;
                default:
                    Console.WriteLine("Введите число ещё раз.");
                    Play();
                    break;
            }
            if (flag1 == flag)
            {
                Console.WriteLine($@"
Вы угадали! Ваш IQ почти сравним с {Name}!");
                Score += 30;
            }
            else
            {
                Console.WriteLine($@"
Вы ощиблись!{Name} не удивлен!");
                Score -= 10;
            }
        }

    }
}
