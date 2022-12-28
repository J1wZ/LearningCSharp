using System;

namespace UTest
{
    public class LeapTests
    {

        [TestCase]
        public void YearIsLeap()
        {
            Assert.IsTrue(LeapYear.Programm.IsLeapYear(2020));
        }
        [TestCase]
        public void YearNotLeap()
        {
            Assert.IsFalse(LeapYear.Programm.IsLeapYear(2021));
        }
        [TestCase]
        public void YearIsNeg()
        {
            Assert.IsFalse(LeapYear.Programm.IsLeapYear(-2020));
        }
    }
}