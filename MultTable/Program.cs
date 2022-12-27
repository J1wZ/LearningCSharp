using System;

namespace MultTable
{
    class Programm
    {
        static void GoTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + "\t"); 
                for (int j = 1; j <= 10; j++)
                {
                    if(i>1)
                    {
                        Console.Write(i*j + "\t");
                    }
                    else
                    {
                        Console.Write(j + "\t");

                    }
                }
                Console.Write("\n");
            }
        }

        static void Main()
        {
            GoTable();

        }
    }
}
