using System;

namespace List
{
    class Program
    {
        static void Main()
        {
            MyList<int> ListInt = new MyList<int>();
            for (int i = 0; i < 5; i++)
            {
                ListInt.AddValue(i);

            }
            ListInt.PrintList();
            ListInt.Delete(1);
            ListInt.PrintList();
            int id = ListInt.FindIndexOf(2);
            int Len = ListInt.Count;
            int Cop = ListInt.Copacity;
            Console.WriteLine($"ID цифры 2:{id}, Количество элементов:{Len}, Длина Листа {Cop}");
            string[] Hello = new string[] {"Hello", "and", "Good morning," };
            MyList<string> ListStr = new MyList<string>(Hello);
            ListStr.AddValue("World!");
            ListStr.AddValue("How are you?");
            ListStr.PrintList();
            ListStr.Delete("World!");
            ListStr.AddValue("Teacher");
            ListStr.PrintList();
            id = ListStr.Count;
            Len = ListStr.FindIndexOf("Teacher");
            Cop = ListStr.Copacity;
            Console.WriteLine($@"До обрезки:
ID Teacher:{Len}, Количество элементов:{id}, Длина Листа {Cop}");
            ListStr.Trim();
            id = ListStr.Count;
            Len = ListStr.FindIndexOf("Teacher");
            Cop = ListStr.Copacity;
            Console.WriteLine($@"После обрезки:
ID Teacher:{Len}, Количество элементов:{id}, Длина Листа {Cop}");
        }
    }
}