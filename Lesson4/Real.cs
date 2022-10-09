using System;


namespace Lesson4.RealClass
{
    public struct Real
    {
        public int Body;
        public int Tale;

        public Real()
        {
            this.Body = 0;
            this.Tale = 0;
        }

        public Real(int a, int b)
        {
            this.Body = a;
            this.Tale = b;
        }

        public void PrintReal()
        {
            Console.WriteLine($"{this.Body},{this.Tale}");
        }

        public void SumReal(Real b)
        {
            var a = new Real(this.Body, this.Tale);
            Console.WriteLine($"Сумма {a.Body},{a.Tale} и {b.Body},{b.Tale}:");
            int cup = TaleLen(a.Tale);
            int a1 = a.Body*cup + a.Tale;
            int cup1 = TaleLen(b.Tale);
            int b1 = b.Body*cup1 + b.Tale;
            a1 = a1 + b1;
            if (cup < cup1)
            {
                cup = cup1;
            }
            Real res = new Real(a1 / cup, a1 % cup);
            res.PrintReal();
        }

        public void SubReal(Real b)
        {
            var a = new Real(this.Body, this.Tale);
            Console.WriteLine($"Разница {a.Body},{a.Tale} и {b.Body},{b.Tale}:");
            int cup = TaleLen(a.Tale);
            int a1 = a.Body*cup + a.Tale;
            int cup1 = TaleLen(b.Tale);
            int b1 = b.Body*cup1 + b.Tale;
            a1 = a1 - b1;
            
            if (cup < cup1)
            {
                cup = cup1;
            }
            Real res = new Real(a1 / cup, a1 % cup);
            res.PrintReal();
        }

        int TaleLen(int a)
        {
            int i = 0;
            while (a > 0)
            {
                a = a / 10;
                i++;
            }
            return i*10;
        }
    }
}
