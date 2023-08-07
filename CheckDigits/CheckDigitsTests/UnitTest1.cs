using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 

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
            double num2 = Convert.ToDouble(TestContext.DataRow["num2"]);
            double num3 = Convert.ToDouble(TestContext.DataRow["num3"]);
            double num4 = Convert.ToDouble(TestContext.DataRow["num4"]);
            double result = num1 + num2 + num3 + num4;
            double actual = Program.CalcTotal(num1, num2, num3, num4);
            Assert.AreEqual(result, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void TestCalcAvg()
        {
            double num1 = Convert.ToDouble(TestContext.DataRow["num1"]);
            double num2 = Convert.ToDouble(TestContext.DataRow["num2"]);
            double num3 = Convert.ToDouble(TestContext.DataRow["num3"]);
            double num4 = Convert.ToDouble(TestContext.DataRow["num4"]);
            double result = (num1 + num2 + num3 + num4) / 4;
            double actual = Program.CalcAvg(num1, num2, num3, num4);
            Assert.AreEqual(result, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void TestFindLargest()
        {
            double num1 = Convert.ToDouble(TestContext.DataRow["num1"]);
            double num2 = Convert.ToDouble(TestContext.DataRow["num2"]);
            double num3 = Convert.ToDouble(TestContext.DataRow["num3"]);
            double num4 = Convert.ToDouble(TestContext.DataRow["num4"]);
            double largest = Convert.ToDouble(TestContext.DataRow["largest"]);
            double result = largest;
            double actual = Program.FindLargest(num1, num2, num3, num4, largest);
            Assert.AreEqual(result, actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void TestFindSmallest()
        {
            double num1 = Convert.ToDouble(TestContext.DataRow["num1"]);
            double num2 = Convert.ToDouble(TestContext.DataRow["num2"]);
            double num3 = Convert.ToDouble(TestContext.DataRow["num3"]);
            double num4 = Convert.ToDouble(TestContext.DataRow["num4"]);
            double smallest = Convert.ToDouble(TestContext.DataRow["smallest"]);
            double result = smallest;
            double actual = Program.FindSmallest(num1, num2, num3, num4, smallest);
            Assert.AreEqual(result, actual);
        }
    }
}
