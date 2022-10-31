using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Phonebook
{
    internal class Abonent
    {
        protected string ANumber;
        protected string AName;


        public string Name 
        { 
            get { return AName == "" ? "Имя не найдено" : AName; }
            set { AName = value; }
        }

        public string Number
        {
            get { return ANumber == "" ? "Номер телефона не найден" : ANumber; }
            set { ANumber = value; }
        }

        public Abonent(string Name, string Num)
        {
            this.AName = Name;
            this.ANumber = Num;
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
        }

        private static void WriteAbonentInFile(Abonent Dude)
        {
            string cup = "\n" + Dude.Name + " " + Dude.Number;
            string path = @"Phonebook.txt";
            File.AppendAllTextAsync(path, cup);
        }

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

        } */
    }
}
