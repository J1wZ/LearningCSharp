using System;

namespace Circle
{
    public class Programm
    {
        //Это для того чтобы я могла составить тесты
        public class MyCirc
        {
            
            public double X { get; set; }
            public double Y { get; set; }
            public MyCirc()
             {
                X = 0;
                Y = 0;
             }
            public MyCirc(double x, double y)
            {
                X=x;
                Y=y;
            }
            ~MyCirc()
            {

            }

            public static void MakeDot()
            {
                Console.WriteLine("Введите Х координаты точки:");
                double ax = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите Y координаты точки:");
                double ay = int.Parse(Console.ReadLine());
                MyCirc a = new MyCirc(ax, ay);
                if (GoCircle(a))
                {
                    Console.WriteLine("Точка лежит в круге");
                }
                else
                {
                    Console.WriteLine("Точка не лежит в круге");
                }

            }
        public static bool GoCircle(MyCirc a)
            {
                double axy = Math.Sqrt(Math.Pow(a.X, 2) + Math.Pow(-1 - a.Y, 2));
                if (axy <= 2)
                {
                    return true;
                   
                }
                else
                {
                    return false;
                    
                }
            }
        }
           

            static void Main()
            {
                MyCirc.MakeDot();
            }
        
    }
}
