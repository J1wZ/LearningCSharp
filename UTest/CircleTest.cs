namespace UTest
{
    public class Tests
    {

        [TestCase(0, -1)]
        [TestCase(0, 0)]
        public void DotInCircle(int n, int b)
        {
            var dot = new Circle.Programm.MyCirc(n,b);
            Assert.IsTrue(Circle.Programm.MyCirc.GoCircle(dot));
        }
        [TestCase(20, 5)]
        [TestCase(10, 0)]
        public void DotNotInCircle(int n, int b)
        {
             var dot = new Circle.Programm.MyCirc(n, b);
             Assert.IsFalse(Circle.Programm.MyCirc.GoCircle(dot));
        }
        [TestCase(0, -1.5)]
        [TestCase(10.5, 20.6)]
        public void DotIsDouble(double n, double b)
        {
            var dot = new Circle.Programm.MyCirc(n, b);
            Assert.IsTrue(Circle.Programm.MyCirc.GoCircle(dot));
        }
    }
}