namespace UTest
{
    public class Tests
    {

        [TestCase]
        public void DotInCircle()
        {
            var dot = new Circle.Programm.MyCirc(0,-1);
            Assert.IsTrue(Circle.Programm.MyCirc.GoCircle(dot));
        }
        [TestCase]
        public void DotNotInCircle()
        {
            var dot = new Circle.Programm.MyCirc(5, 10);
            Assert.IsFalse(Circle.Programm.MyCirc.GoCircle(dot));
        }
        [TestCase]
        public void DotIsDouble()
        {
            var dot = new Circle.Programm.MyCirc(6.5, 10.1);
            Assert.IsFalse(Circle.Programm.MyCirc.GoCircle(dot));
        }
    }
}