using System;

namespace UTest
{
    public class PrimeNumTests
    {

        [Test]
        public void NumIsPrime()
        {
            Assert.IsTrue(PrimaryNum.Programm.IsPrimeNum(1));
        }
        public void NumIsNotPrime()
        {
            Assert.IsFalse(PrimaryNum.Programm.IsPrimeNum(4));
        }
    }
}