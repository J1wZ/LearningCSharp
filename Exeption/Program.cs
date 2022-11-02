using System;

namespace Exception
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Поставим условие, что в первом массиве не может быть числа 3, 
                var Arr1 = new int[5];
                var Arr2 = new string[1];
                for (int i = 0; i < Arr1.Length -1; i++)
                {
                    if (i == 3)
                    {
                        throw new System.Exception("Нельзя 3.");
                    }
                    else {
                        Arr1[i] = i;
                    }
                   
                }
                Arr2.CopyTo(Arr1, 0);
                
                for (int i = 4; i < 10; i++)
                {
                    Arr1[i] = i;
                }
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch(System.Exception w)
            {
                Console.WriteLine($"Ошибка: {w.Message}");
            }
            finally
            {
                Console.WriteLine("Финальный блок.");
            }
        }
    }
}
 