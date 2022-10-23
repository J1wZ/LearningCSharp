using System;

namespace Lesson4
{
    class Program
    {
        static void Main()
        {
            var a = new Real(1,7, 5);
            var b = new Real(1, 3,4);
            a.PrintNum();
            b.PrintNum();
            Real cup = new Real();
            cup.Sum(a,b);
            cup.Mult(a,b);
            Number cup1 = new Number();
            var a1 = new Number(1,7);
            var b1 = new Number(-1,8);
            a1.PrintNum();
            b1.PrintNum();
            cup1.Sum(a1,b1);   
            cup1.Mult(a1,b1);
            var a2 = new Compl(1,2,3);
            var b2 = new Compl(-1,3,3);
            a2.PrintNum();
            b2.PrintNum();
            Compl cup2 = new Compl();
            cup2.Sum(a2, b2);
            cup2.Mult(a2, b2);
        }
    }
}
