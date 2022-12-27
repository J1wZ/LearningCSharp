using System;

namespace SortList
{
    class Program
    {
        public static string[] SD = { };
        public static void OnProgramLaunch()
        {

            try
            {
                using (StreamReader sr = new StreamReader("SortList.txt"))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                        if (i >= SD.Length)
                        {
                            Array.Resize(ref SD, SD.Length +5 );
                        }
                        SD[i] = line;
                        i++;
                    }
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Не возможно прочитать файл: ");
                Console.WriteLine(e.Message);
            }
        }

        public static int CountList(string[] SD)
        {
            int c = 0;
            foreach(string line in SD)
            {
                if(line != null)
                {
                    c++;
                }
            }
            return c;
        }

        public static void SortThatList(int c)
        {
            string cup;
            for (int i = 0; i < c-1; i++)
            {
                
                    for (int j = i+1; j < c; j++)
                    {
                    

                        if (SD[i] != null && SD[j] != null)
                        {
                            if (SD[i].Length >SD[j].Length)
                            {
                                cup = SD[i];
                                SD[i] = SD[j];
                                SD[j] = cup;
                            }
                        }
                    }
                    
                
            }
        }

        static void PrintList(string[] SD)
        {
            for (int i=0; i<SD.Length; i++)
            {
                if (SD[i] != null)
                {
                    Console.WriteLine(SD[i]);
                }
                
            }
        }
        static void Main()
        {
            Console.WriteLine(@$"Писать строчки в файле SortList.txt
Сортировка производится пузырьковым методом(от самой короткой строчки к самой длинной)
Изменения в файл через терминал не сохроняются
До сортировки:");
            
            OnProgramLaunch();
            PrintList(SD);
            SortThatList(CountList(SD));
            Console.WriteLine("После сортировки:");
            PrintList(SD);
        }
    }
}