using System;

namespace UTest
{
    public class LeapTests
    {

        [TestCase(2020)]
        [TestCase(2024)]
        public void YearIsLeap(int a)
        {
            Assert.IsTrue(LeapYear.Programm.IsLeapYear(a));
        }
        [TestCase(2021)]
        [TestCase(2019)]
        public void YearNotLeap(int a)
        {
            Assert.IsFalse(LeapYear.Programm.IsLeapYear(a));
        }
        [TestCase(-2021)]
        [TestCase(-2020)]
        public void YearIsNeg(int a)
        {
            Assert.IsFalse(LeapYear.Programm.IsLeapYear(a));
        }
    }
}