using System;
using Lesson4.RealClass;

namespace Lesson4
{
    class Program
    {
        static void Main()
        {
            var FirstReal = new Real(7, 5);
            var SecondReal = new Real(1, 3);
            FirstReal.PrintReal();
            SecondReal.PrintReal();
            FirstReal.SumReal(SecondReal);
            FirstReal.SubReal(SecondReal);
        }
    }
}
