using System;
//using Phonebook.Abonent;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Изменения в самом файле появяться только после закрытия программы с помощью специальной команды(4).");
            Phonebook Dudes = new Phonebook();
            Phonebook.OnProgramLaunch(Dudes);

            Menu();

            void Menu()
            {
                Console.WriteLine("Книга Абонентов. Напишите,что вы хотете сделать:" + "\n" + "1 - Посмотреть книгу \n 2 - Добавить \n 3 - Удалить \n 4 - Выйти из программы");
                var key = Console.ReadKey(true).Key;
                
                bool Close = false;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Phonebook.ReadAbonentFromPhonebook(Dudes);
                        break;
                    case ConsoleKey.D2:
                        Phonebook.AddToPhonebook2(Dudes);
                        break;
                    case ConsoleKey.D3:
                        Phonebook.DeleteAbonent2(Dudes);
                        break;
                    case ConsoleKey.D4:
                        Phonebook.OnProgramExit(Dudes);
                        Close = true;
                        break;
                    default:
                        Console.WriteLine("Мы не можен понять что вам нужно. \nПопытайтесь ввести значение снова.");
                        break;
                }
                if (!Close)
                {
                    Menu();
                }
            }
/*
            void Menu()
            {
                Console.WriteLine("Книга Абонентов. Напишите,что вы хотете сделать:" + "/n" + "1 - Посмотреть книгу /n 2 - Добавить /n 3 - Удалить");
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        Abonent.ReadAbonentFromFile();
                        break;
                    case ConsoleKey.D2:
                        Abonent.AddToPhonebook();
                        break;
                    case ConsoleKey.D3:
                        Abonent.DeleteAbonent();
                        break;
                    default:
                        Console.WriteLine("Не можем понять что вам надо.");
                        Menu();
                        break;
                }
                Menu();
            }
         */   
        }
    }
}