using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Compl : Number
    {
        protected int CTail;


        public Compl(int S, int B, int T): base(S, B)
        {
            this.CTail = T; 
        }

        public Compl() : base()
        {
            this.CTail = 0;
        }

        ~Compl()
        {

        }

        public new void Sum(Compl a, Compl b) 
        {
            this.NBody = a.NSign*a.NBody + b.NSign*b.NBody;
            this.CTail = a.CTail + b.CTail;
            if (this.NBody > 0)
            {
                this.NSign = 1;
            }
            else
            {
                this.NBody = -this.NBody;
                this.NSign = -1;
            }
            Console.WriteLine("Сумма чисел:");
            this.PrintNum();
        }

        public new void Mult(Compl a, Compl b)
        {
            this.NSign = a.NSign * b.NSign;
            this.NBody = a.NBody * b.NBody - a.CTail * b.CTail;
            this.CTail = a.NBody * b.CTail + b.NBody * a.CTail;
            Console.WriteLine("Произведение чисел:");
            this.PrintNum();
        }

        public new void PrintNum()
        {
            if (this.CTail < 0)
            {
                this.CTail = -this.CTail;
                Console.WriteLine($"{this.NSign*this.NBody}-{this.CTail}");
            }
            Console.WriteLine($"{this.NSign*this.NBody}+{this.CTail}");
        }

    }
}
