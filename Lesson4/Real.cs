using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson4
{
    public class Real : Number
    {
        protected int RTale;

        public int Tale
        {
            get { return RTale; }
            set { RTale = value; }  
        }
        public Real(int S, int B, int T) : base(S,B)
        {
            this.RTale = T;
        }

        public Real() : base()
        {
            this.RTale = 0;
        }

        ~Real()
        {

        }

        int TaleLen(int a)
        {
            int i = 0;
            while (a > 0)
            {
                a = a / 10;
                i++;
            }
            return i * 10;
        }

        public new void Sum(Real a, Real b)
        {
            Console.WriteLine($"Сумма {a.NSign*a.Body},{a.Tale} и {b.NSign*b.Body},{b.Tale}:");
            int cup = TaleLen(a.Tale);
            int a1 = a.NSign * a.Body * cup + a.Tale;
            int cup1 = TaleLen(b.Tale);
            int b1 = b.NSign * b.Body * cup1 + b.Tale;
            a1 = a1 + b1;
            if (cup < cup1)
            {
                cup = cup1;
            }
            if (a1 < 0)
            {
                this.NSign = -1;
            }
            else
            {
                this.NSign = 1;
            }
            this.NBody = a1 / cup;
            this.RTale = a1 % cup;
            this.PrintNum();
        }

        public new void PrintNum()
        {
            Console.WriteLine($"{this.NSign*this.NBody},{this.RTale}");
        }

        public new void Mult(Real a, Real b)
        {
            Console.WriteLine($"Произведение {a.NSign*a.Body},{a.Tale} и {b.NSign*b.Body},{b.Tale}:");
            int cup = TaleLen(a.Tale);
            int a1 = a.NSign * a.Body * cup + a.Tale;
            int cup1 = TaleLen(b.Tale);
            int b1 = b.NSign * b.Body * cup1 + b.Tale;
            a1 = a1 * b1;
            cup = cup*cup1;
            if (a1 < 0)
            {
                this.NSign = -1;
            }
            else
            {
                this.NSign = 1;
            }
            this.NBody = a1 / cup;
            this.RTale = a1 % cup;
            this.PrintNum();
        }
    }
}
