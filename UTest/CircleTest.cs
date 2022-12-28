namespace UTest
{
    public class Tests
    {

        [Test]
        public void DotInCircle()
        {
            var dot = new Circle.Programm.MyCirc(0,-1);
            Assert.IsTrue(Circle.Programm.MyCirc.GoCircle(dot));
        }
        public void DotNotInCircle()
        {
            var dot = new Circle.Programm.MyCirc(5, 10);
            Assert.IsFalse(Circle.Programm.MyCirc.GoCircle(dot));
        }
    }
}