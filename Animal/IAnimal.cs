using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal interface IAnimal
    {
        public int Score { get; set; }
        public string Name { get; set; }

        public string Voice { get; set; }

        public Food Meal { get; set; }

        void Eat(Food food);

        void Speak();

        void Sleep();

        void Play();

        void Drink();
    }
}
