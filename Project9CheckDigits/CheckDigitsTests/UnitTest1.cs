using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CheckDigits
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void TestCalcTotal()
        {
            double num1 = Convert.ToDouble(TestContext.DataRow["num1"]);
            double num2 = ;
            double num3 = ;
            double num4 = ;
            double result = num1 + num2 + num3 + num4;
            double actual = Program.CalcTotal(num1, num2, num3, num4);
            Assert.AreEqual(result, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void TestCalcAvg()
        {

        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void TestFindLargest()
        {

        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void TestFindSmallest()
        {

        }
    }
}