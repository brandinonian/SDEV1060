namespace MPGCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMPGInstance()
        {
            // arrange
            MPG first = new MPG(500, 50);
            MPG second = new MPG(500, 5);
            MPG third = new MPG(500, 25);
            MPG fourth = new MPG(500, 10);
            // act and assert
            Assert.AreEqual(500, first.getMiles(), .00);
            Assert.AreEqual(50, first.getGallons(), .00);
            Assert.AreEqual(10, first.getMPG(), .00);

            Assert.AreEqual(500, second.getMiles(), .00);
            Assert.AreEqual(5, second.getGallons(), .00);
            Assert.AreEqual(100, second.getMPG(), .00);

            Assert.AreEqual(500, third.getMiles(), .00);
            Assert.AreEqual(25, third.getGallons(), .00);
            Assert.AreEqual(20, third.getMPG(), .00);

            Assert.AreEqual(500, fourth.getMiles(), .00);
            Assert.AreEqual(10, fourth.getGallons(), .00);
            Assert.AreEqual(50, fourth.getMPG(), .00);

            Assert.AreEqual(2000, first.getTotalMiles(), .00);
            Assert.AreEqual(90, first.getTotalGallons(), .00);
            Assert.AreEqual(22.22, first.getTotalMPG(), .01);
            Assert.AreEqual(4, first.getNumTrips());
        }
    }
}