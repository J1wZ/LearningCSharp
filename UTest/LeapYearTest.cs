using System;

namespace UTest
{
    public class LeapTests
    {

        [Test]
        public void YearIsLeap()
        {
            Assert.IsTrue(LeapYear.Programm.IsLeapYear(2020));
        }
        public void YearNotLeap()
        {
            Assert.IsFalse(LeapYear.Programm.IsLeapYear(2021));
        }
    }
}