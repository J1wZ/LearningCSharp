using System;

namespace Animal
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Здраствуйте! 
С каким животным вы хотите поиграть?(У каждого животного своя игра)
1. Мышь
2. Обезьяна
3. Ворон
4. Ящерица");
            var key = Console.ReadKey(true).Key;
            Console.WriteLine("И как вы назовете своего питомца?");
            string name = Console.ReadLine();
            switch (key)
            {
                case ConsoleKey.D1:
                    Mouse pet = new Mouse(name,Food.Seeds, "Пип-Пииип!");
                    Menu(pet);
                    break;
                case ConsoleKey.D2:
                    Monkey pet1 = new Monkey(name, Food.Banana, "Уга-буга!");
                    Menu(pet1);
                    break;
                case ConsoleKey.D3:
                    Raven pet2 = new Raven(name, Food.Bugs, "Кааар!");
                    Menu(pet2);
                    break;
                case ConsoleKey.D4:
                    Lizard pet3 = new Lizard(name, Food.Bugs, "ААААААААА!");
                    Menu(pet3);
                    break;
                default:
                    Console.WriteLine("К сожалению пока не завезли новых животных.Выберете кого-нибудь другого");
                    break;
            }
            Console.ReadKey();
            void Menu(AbsAnimal pet)
            {
                Console.WriteLine(@$"Здраствуйте! 
Что вы хотите делать с {name}.
1. Есть
2. Спать
3. Пить
4. Играть
5. Посмотреть Счет
6. Выйти");
                var key = Console.ReadKey(true).Key;
                bool Exit = false;
                switch(key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine(@"Чем будете кормить?
1.Банан
2.Зерна
3.Жуки");
                        var key1 = Console.ReadKey(true).Key;
                        switch(key1)
                        {
                            case ConsoleKey.D1:
                                pet.Eat(Food.Banana);
                                break;
                            case ConsoleKey.D2:
                                pet.Eat(Food.Seeds);
                                break;
                            case ConsoleKey.D3:
                                pet.Eat(Food.Bugs);
                                break;

                        }
                        break;
                    case ConsoleKey.D2:
                        pet.Sleep();
                        break;
                    case ConsoleKey.D3:
                        pet.Drink();
                        break;
                    case ConsoleKey.D4:
                        pet.Play();
                        break;
                    case ConsoleKey.D5:
                        pet.Scoring();
                        break;
                    case ConsoleKey.D6:
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Введите ещё раз.");
                        break;
                }
                if (!Exit)
                {
                    Menu(pet);
                }
                else
                {
                    Console.WriteLine($"До свидания! Ваш Счет: {pet.Score}");
                }
            }
        }

       
    }
}