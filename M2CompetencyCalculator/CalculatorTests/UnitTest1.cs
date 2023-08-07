namespace M2CompetencyCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddNumbers()
        {
            Assert.AreEqual(2, Calculator.AddNumbers(1, 1));
            Assert.AreEqual(14, Calculator.AddNumbers(7, 7));
            Assert.AreEqual(-198, Calculator.AddNumbers(-99, -99));
            Assert.AreEqual(198, Calculator.AddNumbers(99, 99));
            Assert.AreEqual(-100, Calculator.AddNumbers(-99, -1));
            Assert.AreEqual(-100, Calculator.AddNumbers(-1, -99));
            Assert.AreEqual(100, Calculator.AddNumbers(99, 1));
            Assert.AreEqual(100, Calculator.AddNumbers(1, 99));
            Assert.AreEqual(0, Calculator.AddNumbers(-10, 10));
            Assert.AreEqual(0, Calculator.AddNumbers(10, -10));
            Assert.AreEqual(11, Calculator.AddNumbers(5, 6));
        }
        [TestMethod]
        public void TestSubtractNumbers()
        {
            Assert.AreEqual(0, Calculator.SubtractNumbers(1, 1));
            Assert.AreEqual(0, Calculator.SubtractNumbers(7, 7));
            Assert.AreEqual(0, Calculator.SubtractNumbers(-99, -99));
            Assert.AreEqual(0, Calculator.SubtractNumbers(99, 99));
            Assert.AreEqual(-98, Calculator.SubtractNumbers(-99, -1));
            Assert.AreEqual(98, Calculator.SubtractNumbers(-1, -99));
            Assert.AreEqual(98, Calculator.SubtractNumbers(99, 1));
            Assert.AreEqual(-98, Calculator.SubtractNumbers(1, 99));
            Assert.AreEqual(-20, Calculator.SubtractNumbers(-10, 10));
            Assert.AreEqual(20, Calculator.SubtractNumbers(10, -10));
            Assert.AreEqual(-1, Calculator.SubtractNumbers(5, 6));
        }
        [TestMethod]
        public void TestMultiplyNumbers()
        {
            Assert.AreEqual(1, Calculator.MultiplyNumbers(1, 1));
            Assert.AreEqual(49, Calculator.MultiplyNumbers(7, 7));
            Assert.AreEqual(9801, Calculator.MultiplyNumbers(-99, -99));
            Assert.AreEqual(9801, Calculator.MultiplyNumbers(99, 99));
            Assert.AreEqual(99, Calculator.MultiplyNumbers(-99, -1));
            Assert.AreEqual(99, Calculator.MultiplyNumbers(-1, -99));
            Assert.AreEqual(99, Calculator.MultiplyNumbers(99, 1));
            Assert.AreEqual(99, Calculator.MultiplyNumbers(1, 99));
            Assert.AreEqual(-100, Calculator.MultiplyNumbers(-10, 10));
            Assert.AreEqual(-100, Calculator.MultiplyNumbers(10, -10));
            Assert.AreEqual(30, Calculator.MultiplyNumbers(5, 6));

        }
        [TestMethod]
        public void TestDivideNumbers()
        {
            Assert.AreEqual(1, Calculator.DivideNumbers(1, 1));
            Assert.AreEqual(1, Calculator.DivideNumbers(7, 7));
            Assert.AreEqual(1, Calculator.DivideNumbers(-99, -99));
            Assert.AreEqual(1, Calculator.DivideNumbers(99, 99));
            Assert.AreEqual(99, Calculator.DivideNumbers(-99, -1));
            Assert.AreEqual(0, Calculator.DivideNumbers(-1, -99));
            Assert.AreEqual(99, Calculator.DivideNumbers(99, 1));
            Assert.AreEqual(0, Calculator.DivideNumbers(1, 99));
            Assert.AreEqual(-1, Calculator.DivideNumbers(-10, 10));
            Assert.AreEqual(-1, Calculator.DivideNumbers(10, -10));
            Assert.AreEqual(0, Calculator.DivideNumbers(5, 6));

        }
    }
}