using NUnit.Framework;

namespace ChessDotNet.Tests
{
    [TestFixture]
    public static class SquareDistanceTests
    {
        [Test]
        public static void TestPositionDistance()
        {
            var square1 = new Square(File.A, 2);
            var square2 = new Square(File.A, 3);
            var distance1 = new SquareDistance(square1, square2);

            Assert.AreEqual(0, distance1.DistanceX);
            Assert.AreEqual(1, distance1.DistanceY);

            var distance2 = new SquareDistance(square2, square1);

            Assert.AreEqual(0, distance2.DistanceX);
            Assert.AreEqual(1, distance2.DistanceY);
        }
    }
}