using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Project8TipCalculator
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext textContextInstance;
        public TestContext TestContext
        {
            get { return textContextInstance; }
            set { textContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\CalculatorTests.csv", "CalculatorTests#csv", DataAccessMethod.Sequential), DeploymentItem("CalculatorTests.csv"), TestMethod]
        public void TestcalcTip()
        {
            double cost = Convert.ToDouble(TestContext.DataRow["Cost"]);
            double tipPct = Convert.ToDouble(TestContext.DataRow["TipRate"]);
            double result = cost * (tipPct / 100);
            double actual = Program.calcTip(cost, tipPct);
            Assert.AreEqual(result, actual, 0.000);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\CalculatorTests.csv", "CalculatorTests#csv", DataAccessMethod.Sequential), DeploymentItem("CalculatorTests.csv"), TestMethod]
        public void TestcalcTotal()
        {
            double cost = Convert.ToDouble(TestContext.DataRow["Cost"]);
            double tipAmt = Convert.ToDouble(TestContext.DataRow["TipAmt"]);
            double result = cost + tipAmt;
            double actual = Program.calcTotal(cost, tipAmt);
            Assert.AreEqual(result, actual, 0.000);
        }
    }
}
