using NUnit.Framework;

namespace ChessDotNet.Tests
{
    [TestFixture]
    public static class SquareTests
    {
        [TestCase(File.A, 1, "A1")]
        [TestCase(File.B, 2, "B2")]
        [TestCase(File.C, 3, "C3")]
        [TestCase(File.D, 4, "D4")]
        [TestCase(File.E, 4, "E4")]
        [TestCase(File.E, 5, "E5")]
        [TestCase(File.F, 6, "F6")]
        [TestCase(File.G, 7, "G7")]
        [TestCase(File.H, 8, "H8")]
        public static void TestConstructors(File file, int rank, string address)
        {
            Assert.AreEqual(new Square(file, rank), new Square(address));
        }

        [Test]
        public static void TestEquality()
        {
            var square1 = new Square(File.C, 6);
            var square2 = new Square(File.C, 6);

            Assert.AreEqual(square1, square2);
            Assert.True(square1.Equals(square2));
            Assert.True(square2.Equals(square1));
            Assert.True(square1 == square2);
            Assert.True(square2 == square1);
            Assert.False(square1 != square2);
            Assert.False(square2 != square1);
            Assert.AreEqual(square1.GetHashCode(), square2.GetHashCode());
        }

        [TestCase(File.E, 2, File.B, 5)]
        [TestCase(File.E, 2, File.E, 5)]
        [TestCase(File.E, 2, File.B, 2)]
        public static void TestInequality(File file1, int rank1, File file2, int rank2)
        {
            var square1 = new Square(file1, rank1);
            var square2 = new Square(file2, rank2);

            Assert.AreNotEqual(square1, square2);
            Assert.False(square1.Equals(square2));
            Assert.False(square2.Equals(square1));
            Assert.True(square1 != square2);
            Assert.True(square2 != square1);
            Assert.False(square1 == square2);
            Assert.False(square2 == square1);
            Assert.AreNotEqual(square1.GetHashCode(), square2.GetHashCode());
        }

        [Test]
        public static void TestInequalityDifferentType()
        {
            var square1 = new Square(File.D, 3);
            var str = "abc";

            Assert.False(square1.Equals(str));
        }

        [Test]
        public static void TestInequalityNull()
        {
            var square1 = new Square(File.E, 1);

            Assert.AreNotEqual(square1, null);
            Assert.False(square1.Equals(null));
            Assert.True(square1 != null);
            Assert.True(null != square1);
            Assert.False(square1 == null);
            Assert.False(null == square1);
        }

        [TestCase(File.A, 1, "A1")]
        [TestCase(File.B, 2, "B2")]
        [TestCase(File.C, 3, "C3")]
        [TestCase(File.D, 4, "D4")]
        [TestCase(File.E, 4, "E4")]
        [TestCase(File.E, 5, "E5")]
        [TestCase(File.F, 6, "F6")]
        [TestCase(File.G, 7, "G7")]
        [TestCase(File.H, 8, "H8")]
        [TestCase(File.H, 5, "H5")]
        public static void TestToString(File file, int rank, string address)
        {
            Assert.AreEqual(address, new Square(file, rank).ToString());
            Assert.AreEqual(address, new Square(address).ToString());
        }
    }
}