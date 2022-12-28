using System;

namespace UTest
{
    public class PrimeNumTests
    {

        [TestCase(1, ExpectedResult = true)]
        [TestCase(2, ExpectedResult = true)]
        public bool NumIsPrime(int a)
        {
            return PrimaryNum.Programm.IsPrimeNum(a);
        }
        [TestCase(4, ExpectedResult = false)]
        [TestCase(20, ExpectedResult = false)]
        public bool NumIsNotPrime(int a)
        {
            return PrimaryNum.Programm.IsPrimeNum(a);
        }
        [TestCase(-1, ExpectedResult = false)]
        [TestCase(-2, ExpectedResult = false)]
        public bool NumIsNeg(int a)
        {
            return PrimaryNum.Programm.IsPrimeNum(a);
        }

    }
}