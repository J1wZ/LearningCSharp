namespace UTest
{
    public class Tests
    {

        [TestCase(0, -1, ExpectedResult = true)]
        [TestCase(0, 0, ExpectedResult = true)]
        public bool DotInCircle(int n, int b)
        {
            var dot = new Circle.Programm.MyCirc(n,b);
            return Circle.Programm.MyCirc.GoCircle(dot);
        }
        [TestCase(20, 5, ExpectedResult = false)]
        [TestCase(10, 0, ExpectedResult = false)]
        public bool DotNotInCircle(int n, int b)
        {
            var dot = new Circle.Programm.MyCirc(n, b);
             return Circle.Programm.MyCirc.GoCircle(dot);
        }
        [TestCase(0, -1.5, ExpectedResult = true)]
        [TestCase(10.5, 20.6, ExpectedResult = false)]
        public bool DotIsDouble(double n, double b)
        {
            var dot = new Circle.Programm.MyCirc(n, b);
            return Circle.Programm.MyCirc.GoCircle(dot);
        }
    }
}