using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract internal class AbsAnimal : IAnimal
    {
        public int Score { get; set; }
        public string Name { get; set; }

        public string Voice { get; set; }

        public Food Meal { get; set; }

        public virtual void Play()
        {

        }
        public bool RightFood(Food food)
        {
            if (food == Meal)
                return true;
            else
                return false;
        }
        public void Scoring()
        {
            Console.WriteLine($"Ваш Счет: {Score}");
        }
        public void Eat(Food food)
        {
            if (RightFood(food))
            {
                Console.WriteLine($"{Name} хорошо поел.");
                Score += 10;
                
            }
            else
            {
                Console.WriteLine("Не та еда.");
            }
        }

        public void Speak()
        {
            Score += 10;
            Console.WriteLine($@"===============================
          {Voice}               
===============================");
        }


        public void Sleep()
        {
            Score += 10;
            Console.WriteLine($"{Name} поспал.");
        }


        public void Drink()
        {
            Score += 10;
            Console.WriteLine($"{Name} попил.");
        }

        public AbsAnimal(string name, Food food, string voice)
        {
            this.Name = name;
            this.Meal = food;
            this.Voice = voice;
            this.Score = 0;
        }
    }
}
