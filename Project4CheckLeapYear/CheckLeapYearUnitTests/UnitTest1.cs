using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Project4CheckLeapYear
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDaysInFeb()
        {
            Assert.AreEqual(29, Program.DaysInFeb(2000));
            Assert.AreEqual(28, Program.DaysInFeb(2001));
            Assert.AreEqual(29, Program.DaysInFeb(1904));
            Assert.AreEqual(28, Program.DaysInFeb(1900));
            Assert.AreEqual(29, Program.DaysInFeb(2020));
            Assert.AreEqual(28, Program.DaysInFeb(2015));
            Assert.AreEqual(29, Program.DaysInFeb(2012));
            Assert.AreEqual(28, Program.DaysInFeb(1950));
            Assert.AreEqual(29, Program.DaysInFeb(2004));
            Assert.AreEqual(28, Program.DaysInFeb(2100));
            // Failure case, 2032 = 29
            Assert.AreEqual(28, Program.DaysInFeb(2032), "testing 2032, it IS a leap year");
        }

        [TestMethod]
        public void TestCheckLeapYear()
        {
            Assert.IsTrue(Program.CheckLeapYear(2000));
            Assert.IsFalse(Program.CheckLeapYear(2001));
            Assert.IsTrue(Program.CheckLeapYear(1904));
            Assert.IsFalse(Program.CheckLeapYear(1900));
            Assert.IsTrue(Program.CheckLeapYear(2020));
            Assert.IsFalse(Program.CheckLeapYear(2015));
            Assert.IsTrue(Program.CheckLeapYear(2012));
            Assert.IsFalse(Program.CheckLeapYear(1950));
            Assert.IsTrue(Program.CheckLeapYear(2004));
            Assert.IsFalse(Program.CheckLeapYear(2100));
            // Failure case, 2032 = true
            Assert.IsFalse(Program.CheckLeapYear(2032), "testing 2032, it IS a leap year");
        }
    }
}