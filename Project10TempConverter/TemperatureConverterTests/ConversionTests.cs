using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TemperatureConverter
{

    [TestClass]
    public class ConversionTests
    {
        [DataRow(0,32)]
        [DataRow(100,212)]
        [DataRow(37,98.6)]
        [DataRow(50,122)]
        [DataRow(5,41)]
        [DataRow(15,59)]
        [DataRow(25,77)]
        [DataRow(-1,30.2)]
        [DataRow(-10,14)]
        [DataRow(-20,-4)]
        [DataRow(-30,-22)]
        [DataTestMethod]
        public void TestCtoF(double Ctemp, double Ftemp)
        {
            Assert.AreEqual(Ftemp, Program.CtoF(Ctemp), 0.0000001);
        }

        [DataRow(0, 32)]
        [DataRow(100, 212)]
        [DataRow(37, 98.6)]
        [DataRow(50, 122)]
        [DataRow(5, 41)]
        [DataRow(15, 59)]
        [DataRow(25, 77)]
        [DataRow(-1, 30.2)]
        [DataRow(-10, 14)]
        [DataRow(-20, -4)]
        [DataRow(-30, -22)]
        [DataTestMethod]
        public void TestFtoC(double Ctemp, double Ftemp)
        {
            Assert.AreEqual(Ctemp, Program.FtoC(Ftemp), 0.0000001); // 30.2 converts to -1.0000000000000004 which fails without the delta
        }
    }
}