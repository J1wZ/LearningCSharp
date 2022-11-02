using System;

namespace Exception
{
    class Program
    {


        class IntDivByZero : System.DivideByZeroException
        {
            public IntDivByZero(string message)
        : base(message)
            { }
        }

        class IntNotThree : System.Exception
        {
            public IntNotThree(string message)
        : base(message)
            { }
        }

        public class MyInt
        {
            public int value { get; set; }
            public int Value
            {
                get { return value; }
                set
                {
                    if (value == 3)
                    {
                        throw new IntNotThree("Нельзя 3.");
                    }
                }
            }
            public void Divide(int a, int b)
            {
                if (b==0)
                {
                    throw new IntDivByZero("Нельзя делить на ноль"); 
                }
                this.Value = (a / b);
            }

            public MyInt()
            { 
                Value = 0;
            }
            public MyInt(int a)
            {
                Value = a;
            }
        }
        static void Main()
        {
            try
            {
                // Поставим условие, не может быть числа 3
                MyInt a1 = new MyInt(3);
                MyInt a2 = new MyInt(4);
                MyInt aa = new MyInt();
                a2.Divide(a2.Value,aa.Value);
            }
            catch(IntDivByZero e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            catch(IntNotThree w)
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
 