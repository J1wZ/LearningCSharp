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
            Dudes.Notify += ShowMes;
            Phonebook.OnProgramLaunch(Dudes);

            Menu();

            void Menu()
            {
                Console.WriteLine("Книга Абонентов. Напишите,что вы хотете сделать:" + "\n" + "1 - Посмотреть книгу \n 2 - Добавить \n 3 - Удалить \n 4 - Выйти из программы");
                var key = Console.ReadKey(true).Key;
                
                bool Close = false;
                switch (key)
                {
                    //Тут можно так же сделать + и - Notify в каждом отдельном кейсе для разного цвета
                    // Получается такое же количество вызовов 
                    case ConsoleKey.D1:
                        
                        Phonebook.ReadAbonentFromPhonebook(Dudes);
                        
                        break;
                    case ConsoleKey.D2:
                        Dudes.Notify -= ShowMes;
                        Dudes.Notify += ShowMesGreen;
                        Phonebook.AddToPhonebook2(Dudes);
                        Dudes.Notify -= ShowMesGreen;
                        Dudes.Notify += ShowMes;
                        break;
                    case ConsoleKey.D3:
                        Dudes.Notify -= ShowMes;
                        Dudes.Notify += ShowMesRed;
                        Phonebook.DeleteAbonent2(Dudes);
                        Dudes.Notify -= ShowMesRed;
                        Dudes.Notify += ShowMes;
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
            void ShowMes(Phonebook sender, PhonebookArg e)
            {
                //if (e.Dude != null)
                //{
                //    Console.WriteLine($"Абонент:{e.Dude.Name} {e.Dude.Number}");
               // }
                Console.WriteLine(e.Message);
            }
            void ShowMesGreen(Phonebook sender, PhonebookArg e)
            {
                if (e.Dude != null)
                {
                    Console.WriteLine($"Абонент:{e.Dude.Name} {e.Dude.Number}");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
            void ShowMesRed(Phonebook sender, PhonebookArg e)
            {
                if (e.Dude != null)
                {
                    Console.WriteLine($"Абонент:{e.Dude.Name} {e.Dude.Number}");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
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