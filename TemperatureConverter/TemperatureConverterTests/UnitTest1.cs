using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TemperatureConverter
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCtoF()
        {
            Assert.AreEqual(212, Program.CtoF(100), 0.00);
            Assert.AreEqual(98.6, Program.CtoF(37.0), 0.00);
            Assert.AreEqual(32, Program.CtoF(0), 0.00);
        }

        [TestMethod]
        public void TestFtoC()
        {
            Assert.AreEqual(100, Program.FtoC(212), 0.00);
            Assert.AreEqual(37.0, Program.FtoC(98.6), 0.00);
            Assert.AreEqual(0, Program.FtoC(32), 0.00);
        }
    }
}