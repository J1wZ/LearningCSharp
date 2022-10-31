using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Phonebook
    {
        protected Abonent[] PhoneList;

        public Abonent[] SomeDudes
        {
            get { return PhoneList; }
            set { PhoneList = value; }
        }

        public Phonebook()
        {
            this.PhoneList = new Abonent[1];
        }

        public Phonebook(Abonent a)
        {
            this.PhoneList = new Abonent[0];
            this.PhoneList[0] = a;  
        }


        private static bool FindAbonent2(Phonebook SD, Abonent a)
        {
            int b = 0;
            foreach(Abonent cup in SD.PhoneList)
            {
                if (cup != null)
                {
                    if (cup.Name == a.Name && cup.Number == a.Number)
                    {
                        b++ ;
                    }
                }   
            }
            if (b > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /*
        private static bool FindAbonent(string a)
        {
            StreamReader sr = File.OpenText("Phonebook.txt");
            string str;
            int cup = 0;
            while ((str = sr.ReadLine()) != null)
            {
                if (str.Contains(a))
                {
                    cup++;
                }
            }
            sr.Close();
            if (cup > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddToPhonebook()
        {
            Console.WriteLine("Введите Имя: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите номер телефона: ");
            string Num = Console.ReadLine();
            string cup = Name + " " + Num;
            bool flag = FindAbonent(cup);
            if (flag)
            {
                Console.WriteLine("Такой абонент уже существует.");
            }
            else
            {
                Abonent Dude = new Abonent(Name, Num);
                WriteAbonentInFile(Dude);
                Console.WriteLine("Абонент добавлен.");
            }
        } */

        public static void AddToPhonebook2(Phonebook SD)
        {
            try
            {
                Console.WriteLine("Введите Имя: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Введите номер телефона: ");
                string Num = Console.ReadLine();
                Abonent Dude = new Abonent(Name, Num);
                bool flag = FindAbonent2(SD, Dude);
                if (flag)
                {
                    Console.WriteLine("Такой абонент уже существует.");
                }
                else
                {
                    Array.Resize(ref SD.PhoneList, SD.PhoneList.Length + 1);
                    SD.PhoneList[SD.PhoneList.Length-1] = Dude;
                    Console.WriteLine("Абонент добавлен.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Не возможно добавить в файл: ");
                Console.WriteLine(e.Message);
            }
        }

        public static void OnProgramExit(Phonebook SD)
        {
            try
            {
                    File.Create("Phonebook.txt").Dispose();
                    File.Create("Phonebook.txt").Close();
                    foreach (Abonent a in SD.PhoneList)
                    {
                        if (a != null)
                        {
                            Console.WriteLine($"{a.Name} {a.Number}");
                            WriteAbonentInFile(a);
                        }
                    }
                Console.WriteLine("Файл обнавлен.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Не возможно записать в файл: ");
                Console.WriteLine(e.Message);
            }
        }

        private static void WriteAbonentInFile(Abonent Dude)
        {
            string cup = Dude.Name + " " + Dude.Number + "\n";
            string path = @"Phonebook.txt";
            File.AppendAllText(path, cup);
        }

        public static void DeleteAbonent2(Phonebook SD)
        {
            try
            {
                Console.WriteLine("Напишите имя абонента:");
                string Name = Console.ReadLine();
                Console.WriteLine("Напишите номер абонента:");
                string Num = Console.ReadLine();
                Abonent Dude = new Abonent(Name, Num);
                bool flag = FindAbonent2(SD, Dude);
                if (flag)
                {
                    Phonebook Smth = new Phonebook();
                    foreach(Abonent a in SD.PhoneList)
                    {
                        if (a != null)
                        {
                            if (a.Name != Dude.Name && a.Number != Dude.Number)
                            {
                                Array.Resize(ref Smth.PhoneList, Smth.PhoneList.Length + 1);
                                Smth.PhoneList[Smth.PhoneList.Length - 1] = a;
                            }
                        }
                    }
                    ReadAbonentFromPhonebook(Smth);
                    Array.Resize(ref SD.PhoneList, Smth.PhoneList.Length);
                    Array.Copy(Smth.PhoneList,SD.PhoneList,SD.PhoneList.Length);
                    Console.WriteLine("Абонент удален.");
                }
                else
                {
                    Console.WriteLine("Такой абонент не найден.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Не возможно удалить из файла файл: ");
                Console.WriteLine(e.Message);
            }
        }
        /*
        public static void DeleteAbonent()
        {
            Console.WriteLine("Напишите имя номер телефона абонента(через пробел), которого хотите удалить: ");
            string cup = Console.ReadLine();
            if (FindAbonent(cup))
            {
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines("Phonebook.txt").Where(l => l != cup);

                File.WriteAllLines(tempFile, linesToKeep);

                File.Delete("Phonebook.txt");
                File.Move(tempFile, "Phonebook.txt");
            }
            else
            {
                Console.WriteLine("Не найден абонент.");
            }
        }

        public static void OnProgramLaunch(Phonebook SD)
        {

            try
            {
                using (StreamReader sr = new StreamReader("Phonebook.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        int index = line.IndexOf(" ");
                        string Name = line.Substring(0, index );
                        string Number = line.Substring(index +1 );
                        Abonent Dude = new Abonent(Name, Number);
                        Array.Resize(ref SD.PhoneList, SD.PhoneList.Length + 1);
                        SD.PhoneList[SD.PhoneList.Length -1] = Dude;
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Не возможно прочитать файл: ");
                Console.WriteLine(e.Message);
            }
        } */

        public static void ReadAbonentFromPhonebook(Phonebook SD)
        {
            
            foreach(Abonent a in SD.PhoneList)
            {
                if (a != null)
                {
                    Console.WriteLine($"{a.Name} {a.Number}");
                }
            }
        }
        /*
        public static void ReadAbonentFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Phonebook.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Не возможно прочитать файл: ");
                Console.WriteLine(e.Message);
            }

        }*/
    }
}
