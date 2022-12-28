using System;

namespace UTest
{
    public class PrimeNumTests
    {

        [TestCase]
        public void NumIsPrime()
        {
            Assert.IsTrue(PrimaryNum.Programm.IsPrimeNum(1));
        }
        [TestCase]
        public void NumIsNotPrime()
        {
            Assert.IsFalse(PrimaryNum.Programm.IsPrimeNum(4));
        }
        [TestCase]
        public void NumIsNeg()
        {
            Assert.IsFalse(PrimaryNum.Programm.IsPrimeNum(-7));
        }

    }
}