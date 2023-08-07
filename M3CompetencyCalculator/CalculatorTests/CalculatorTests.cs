using System.Transactions;

namespace M2CompetencyCalculator
{
    [TestClass]
    public class CalculatorTests
    {
        [DataRow(1,1)]
        [DataRow(7.7,7.7)]
        [DataRow(-99.99,-99.99)]
        [DataRow(99.99,99.99)]
        [DataRow(-99.99,-1)]
        [DataRow(-1,-99.99)]
        [DataRow(99.99,1)]
        [DataRow(1,99.99)]
        [DataRow(-10.1,10.1)]
        [DataRow(10.1,-10.1)]
        [DataRow(5.5,6.5)]
        [DataTestMethod]
        public void TestAddNumbers(double num1, double num2)
        {
            double result = num1 + num2;
            double actual = Calculator.AddNumbers(num1, num2);
            Assert.AreEqual(result, actual, 0.00);
        }
        [DataRow(1, 1)]
        [DataRow(7.7, 7.7)]
        [DataRow(-99.99, -99.99)]
        [DataRow(99.99, 99.99)]
        [DataRow(-99.99, -1)]
        [DataRow(-1, -99.99)]
        [DataRow(99.99, 1)]
        [DataRow(1, 99.99)]
        [DataRow(-10.1, 10.1)]
        [DataRow(10.1, -10.1)]
        [DataRow(5.5, 6.5)]
        [DataTestMethod]
        public void TestSubtractNumbers(double num1, double num2)
        {
            double result = num1 - num2;
            double actual = Calculator.SubtractNumbers(num1, num2);
            Assert.AreEqual(result, actual, 0.00);
        }
        [DataRow(1, 1)]
        [DataRow(7.7, 7.7)]
        [DataRow(-99.99, -99.99)]
        [DataRow(99.99, 99.99)]
        [DataRow(-99.99, -1)]
        [DataRow(-1, -99.99)]
        [DataRow(99.99, 1)]
        [DataRow(1, 99.99)]
        [DataRow(-10.1, 10.1)]
        [DataRow(10.1, -10.1)]
        [DataRow(5.5, 6.5)]
        [DataTestMethod]
        public void TestMultiplyNumbers(double num1, double num2)
        {
            double result = num1 * num2;
            double actual = Calculator.MultiplyNumbers(num1, num2);
            Assert.AreEqual(result, actual, 0.00);

        }
        [DataRow(1, 1)]
        [DataRow(7.7, 7.7)]
        [DataRow(-99.99, -99.99)]
        [DataRow(99.99, 99.99)]
        [DataRow(-99.99, -1)]
        [DataRow(-1, -99.99)]
        [DataRow(99.99, 1)]
        [DataRow(1, 99.99)]
        [DataRow(-10.1, 10.1)]
        [DataRow(10.1, -10.1)]
        [DataRow(5.5, 6.5)]
        [DataTestMethod]
        public void TestDivideNumbers(double num1, double num2)
        {
            double result = num1 / num2;
            double actual = Calculator.DivideNumbers(num1, num2);
            Assert.AreEqual(result, actual, 0.00);

        }
    }
}