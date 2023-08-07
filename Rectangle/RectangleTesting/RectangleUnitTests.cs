using Rectangle;

namespace RectangleTesting
{
    [TestClass]
    public class RectangleUnitTests
    {
        // to copy/paste box values
        // (12, 8, 10)
        // (3, 3, 3)
        // (5, 5, 5)
        // (5, 10, 10)
        // (3, 5, 5)
        // (6, 9, 3)


        [TestMethod]
        public void TestPerimeter()
        {
            //Box testObj = new Box(6, 9, 3);
            //int expectedResult = 30;
            //int actualResult = testObj.calcPerimeter();
            //Assert.AreEqual(expectedResult, actualResult);

            Assert.AreEqual(28, new Box(7, 7, 7).calcPerimeter());
            Assert.AreEqual(40, new Box(10, 10, 10).calcPerimeter());
            Assert.AreEqual(24, new Box(3, 9, 9).calcPerimeter());
            Assert.AreEqual(12, new Box(3, 3, 9).calcPerimeter());
            Assert.AreEqual(36, new Box(9, 9, 3).calcPerimeter());
        }

        [TestMethod]
        public void TestArea()
        {
            //Box testObj = new Box(6, 9, 3);
            //int expectedResult = 54;
            //int actualResult = testObj.calcArea();
            //Assert.AreEqual(expectedResult, actualResult);

            Assert.AreEqual(49, new Box(7, 7, 7).calcArea());
            Assert.AreEqual(100, new Box(10, 10, 10).calcArea());
            Assert.AreEqual(27, new Box(3, 9, 9).calcArea());
            Assert.AreEqual(9, new Box(3, 3, 9).calcArea());
            Assert.AreEqual(81, new Box(9, 9, 3).calcArea());
        }

        [TestMethod]
        public void TestVolume()
        {
            //Box testObj = new Box(6, 9, 3);
            //int expectedResult = 162;
            //int actualResult = testObj.calcVolume();
            //Assert.AreEqual(expectedResult, actualResult);

            Assert.AreEqual(343, new Box(7, 7, 7).calcVolume());
            Assert.AreEqual(1000, new Box(10, 10, 10).calcVolume());
            Assert.AreEqual(243, new Box(3, 9, 9).calcVolume());
            Assert.AreEqual(81, new Box(3, 3, 9).calcVolume());
            Assert.AreEqual(243, new Box(9, 9, 3).calcVolume());
        }
    }
}