using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShippingCosts
{
    [TestClass]
    public class ShippingCostTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void TestCalculateWeightFactor()
        {
            double weight = Convert.ToDouble(TestContext.DataRow["weight"]);
            double result = Convert.ToDouble(TestContext.DataRow["weightFactor"]);
            Assert.AreEqual(result, Program.CalculateWeightFactor(weight), 0.00);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void TestCalculateDistanceFactor()
        {
            double distance = Convert.ToDouble(TestContext.DataRow["distance"]);
            double result = Convert.ToDouble(TestContext.DataRow["distanceFactor"]);
            Assert.AreEqual(result, Program.CalculateDistanceFactor(distance), 0.00);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]
        public void TestCalculateShippingCost()
        {
            double weight = Convert.ToDouble(TestContext.DataRow["weight"]);
            double weightFactor = Convert.ToDouble(TestContext.DataRow["weightFactor"]);
            double distance = Convert.ToDouble(TestContext.DataRow["distance"]);
            double distanceFactor = Convert.ToDouble(TestContext.DataRow["distanceFactor"]);
            Assert.AreEqual((weightFactor * distanceFactor), Program.CalculateShippingCost(weight, distance), 0.00);
        }
    }
}
