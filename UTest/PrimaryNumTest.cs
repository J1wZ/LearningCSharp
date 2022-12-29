using System;

namespace UTest
{
    public class PrimeNumTests
    {

        [TestCase(1)]
        [TestCase(2)]
        public void NumIsPrime(int a)
        {
            Assert.IsTrue(PrimaryNum.Programm.IsPrimeNum(a));
        }
        [TestCase(4)]
        [TestCase(20)]
        public void NumIsNotPrime(int a)
        {
            Assert.IsFalse(PrimaryNum.Programm.IsPrimeNum(a));
        }
        [TestCase(-1)]
        [TestCase(-2)]
        public void NumIsNeg(int a)
        {
            Assert.IsFalse(PrimaryNum.Programm.IsPrimeNum(a));
        }

    }
}