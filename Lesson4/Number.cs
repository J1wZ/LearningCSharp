using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Number
    {
        protected int NSign;
        protected int NBody;


        public int Sign
        {
            get { return NSign == 0 ? 1 : NSign; }
            set { NSign = value; }
        }

        public int Body
        {
            get { return NBody == 0 ? 0 : NBody; }
            set { NBody = value; }
        }

        public Number()
        {
            this.NSign = 1;
            this.NBody = 0;
        }

        public Number(int a, int b)
        {
            this.NSign = a;
            this.NBody = b;
        }

        ~Number()
        {

        }

        public virtual void Sum(Number a, Number b)
        {
            Console.WriteLine("Сумма чисел ");
            a.PrintNum();
            Console.WriteLine("и");
            b.PrintNum();
            Console.WriteLine("=");
            if (a.NSign == b.NSign)
            {
                this.NSign = a.NSign;
                this.NBody = a.NBody + b.NBody;
            }
            else
            {
                if(a.NSign > b.NSign)
                {
                    if(a.NBody >= b.NBody)
                    {
                        this.NSign = a.NSign;
                        this.NBody = a.NBody - b.NBody; 
                    }
                    else
                    {
                        this.NSign = -a.NSign;
                        this.NBody = b.NBody - a.NBody;
                    }
                }
                else
                {
                    if (b.NBody >= a.NBody)
                    {
                        this.NSign = b.NSign;
                        this.NBody = b.NBody - a.NBody;
                    }
                    else
                    {
                        this.NSign = -b.NSign;
                        this.NBody = a.NBody - b.NBody;
                    }
                }
            }
            this.PrintNum();
        }

        public virtual void Mult(Number a, Number b)
        {
            Console.WriteLine("Произведение:");
            this.NSign = a.NSign * b.NSign;
            this.NBody = a.NBody * b.NBody;
            this.PrintNum();
        }

        public virtual void PrintNum()
        {
            Console.WriteLine($"{this.NSign*this.NBody}");
        }
    }
}
