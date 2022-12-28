using System;

namespace UTest
{
    public class LeapTests
    {

        [TestCase(2020,ExpectedResult = true)]
        [TestCase(2024, ExpectedResult = true)]
        public bool YearIsLeap(int a)
        {
            return LeapYear.Programm.IsLeapYear(a);
        }
        [TestCase(2021, ExpectedResult = false)]
        [TestCase(2019, ExpectedResult = false)]
        public bool YearNotLeap(int a)
        {
            return LeapYear.Programm.IsLeapYear(a);
        }
        [TestCase(-2021, ExpectedResult = false)]
        [TestCase(-2020, ExpectedResult = false)]
        public bool YearIsNeg(int a)
        {
            return LeapYear.Programm.IsLeapYear(a);
        }
    }
}