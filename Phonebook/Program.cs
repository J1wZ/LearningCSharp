using System;
//using Phonebook.Abonent;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            
            
            Menu();

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
            
        }
    }
}