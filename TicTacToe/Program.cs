using System;

namespace TicTacToe
{
    class Program
    {
        static void PrintGame(char[] a)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    int c = j * 3 + i;
                    Console.Write($"| {a[c]} |");
                }
                Console.WriteLine("");
            }
        }

        static Boolean IsOver(char[] a)
        {
            int cup = 0;
            for (int i = 0; i < 9; i++)
            {
                if (a[i] != ' ')
                    cup += 1;
            }
            if (cup == 9)
                return true;
            for (int i = 0; i < 3; i++)
            {
                if (a[i * 3] == a[i * 3 + 1] && a[i * 3 + 2] == a[i * 3] && (a[i * 3] == 'x' || a[i * 3] == 'o'))
                    return true;
                if (a[i] == a[(i + 3)] && a[(i + 6)] == a[i] && (a[i] == 'x' || a[i] == 'o'))
                    return true;
            }
            if (a[0] == a[4] && a[8] == a[0] && (a[0] == 'x' || a[0] == 'o'))
                return true;
            if (a[2] == a[4] && a[6] == a[2] && (a[2] == 'x' || a[2] == 'o'))
                return true;
            return false;
        }

        static Boolean IsItFree(int a1, int a2, char[] a)
        {
            if (a[(3 * a2 + a1)] != 'x' && a[(a2 * 3 + a1)] != 'o')
                return true;
            else
                return false;
        }

        static void MakeMove(char pl, char[] a)
        {
            Console.WriteLine("Введите номер столбика(0-2)");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер строчки(0-2)");
            int a2 = int.Parse(Console.ReadLine());
            if (a1 >= 0 && a1 < 3 && a2 >= 0 && a2 < 3 && IsItFree(a1, a2, a))
            {
                a[(a2 * 3 + a1)] = pl;
            }
            else
            {
                Console.WriteLine("Введите снова");
                MakeMove(pl, a);
            }
        }

        static Boolean WhoWon(char[] a, char pl)
        {
            for (int i = 0; i < 3; i++)
            {
                if (a[i * 3] == a[i * 3 + 1] && a[i * 3 + 2] == a[i * 3] && a[i * 3] == pl)
                    return true;

                if (a[i] == a[i + 3] && a[i + 6] == a[i] && a[i] == pl)
                    return true;
            }
            if (a[0] == a[4] && a[8] == a[0] && a[0] == pl)
                return true;

            if (a[2] == a[4] && a[6] == a[2] && a[2] == pl)
                return true;
            return false;


        }
        static void Main(string[] args)
        {
            var a = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            var rand = new Random();
            var choose = rand.Next(0, 2);
            char pl1, pl2;
            if (choose == 0)
            {
                Console.WriteLine("Первый игрок ходит крестиками(x)");
                pl1 = 'x';
                pl2 = 'o';
            }
            else
            {
                Console.WriteLine("Первый игрок ходит ноликами(o)");
                pl1 = 'o';
                pl2 = 'x';
            }
            PrintGame(a);
            while (!IsOver(a))
            {
                Console.WriteLine("Ход первого игрока:");
                MakeMove(pl1, a);
                PrintGame(a);
                if (!IsOver(a))
                {
                    Console.WriteLine("Ход второго игрока:");
                    MakeMove(pl2, a);
                    PrintGame(a);
                }
            }

            if (WhoWon(a, pl1))
                Console.WriteLine("Первый игрок победил!");
            else
                if (WhoWon(a, pl2))
            {
                Console.WriteLine("Второй игрок победил!");
            }
            else
                Console.WriteLine("Ничья!");
            Console.ReadLine();
        }
    }
}

