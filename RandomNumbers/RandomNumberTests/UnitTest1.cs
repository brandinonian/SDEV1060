namespace RandomNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetRN()
        {
            for (int i = 0; i < 5000; i++)
            {
                int testValue = Program.getRN(20, 29);
                Assert.IsTrue(testValue >= 20 && testValue <= 29, $"Value out of range: {testValue}");
            }
        }
    }
}