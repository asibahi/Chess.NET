using NUnit.Framework;

namespace ChessDotNet.Tests
{
    using Pieces;

    [TestFixture]
    public static class MoveTests
    {
        [TestCase("G4", "H5")]
        [TestCase("G3", "H5")]
        [TestCase("G4", "A4")]
        [TestCase("F4", "F1")]
        public static void TestEquality(string str1, string str2)
        {
            var square1 = new Square(str1);
            var square2 = new Square(str2);
            var square3 = new Square(str1);
            var square4 = new Square(str2);
            var move1 = new Move(square1, square2, Player.White);
            var move2 = new Move(square3, square4, Player.White);

            Assert.AreEqual(move1, move2);
            Assert.True(move1.Equals(move2));
            Assert.True(move2.Equals(move1));
            Assert.True(move1 == move2);
            Assert.True(move2 == move1);
            Assert.True(null == (Move)null); // seems redundant
            Assert.False(move1 != move2);
            Assert.False(move2 != move1);
            Assert.AreEqual(move1.GetHashCode(), move2.GetHashCode());
        }

        [TestCase(File.F, File.G, File.H, 4, 5)]
        [TestCase(File.G, File.F, File.H, 4, 5)]
        [TestCase(File.A, File.B, File.C, 1, 2)]
        [TestCase(File.A, File.D, File.C, 4, 5)]
        [TestCase(File.E, File.C, File.G, 8, 1)]
        public static void TestInequality_DifferentFile(File f1, File f2, File f3, int r1, int r2)
        {
            var square1 = new Square(f1, r1);
            var square2 = new Square(f3, r2);
            var square3 = new Square(f2, r1);
            var square4 = new Square(f3, r2);
            var move1 = new Move(square1, square2, Player.Black);
            var move2 = new Move(square3, square4, Player.Black);

            Assert.AreNotEqual(move1, move2);
            Assert.False(move1.Equals(move2));
            Assert.False(move2.Equals(move1));
            Assert.False(move1 == move2);
            Assert.False(move2 == move1);
            Assert.True(move1 != move2);
            Assert.True(move2 != move1);
            Assert.AreNotEqual(move1.GetHashCode(), move2.GetHashCode());
        }

        [TestCase("G4", "H5")]
        [TestCase("G3", "H5")]
        [TestCase("G4", "A4")]
        [TestCase("F4", "F1")]
        public static void TestInequality_DifferentPlayer(string str1, string str2)
        {
            var square1 = new Square(str1);
            var square2 = new Square(str2);
            var square3 = new Square(str1);
            var square4 = new Square(str2);
            var move1 = new Move(square1, square2, Player.White);
            var move2 = new Move(square3, square4, Player.Black);

            Assert.AreNotEqual(move1, move2);
            Assert.False(move1.Equals(move2));
            Assert.False(move2.Equals(move1));
            Assert.False(move1 == move2);
            Assert.False(move2 == move1);
            Assert.True(move1 != move2);
            Assert.True(move2 != move1);
            Assert.AreNotEqual(move1.GetHashCode(), move2.GetHashCode());
        }

        [Test]
        public static void TestInequality_DifferentPromotion()
        {
            var square1 = new Square(File.A, 7);
            var square2 = new Square(File.A, 8);
            var move1 = new Move(square1, square2, Player.White, new Queen(Player.White));
            var move2 = new Move(square1, square2, Player.White, new Knight(Player.White));

            Assert.AreNotEqual(move1, move2);
            Assert.False(move1.Equals(move2));
            Assert.False(move2.Equals(move1));
            Assert.False(move1 == move2);
            Assert.False(move2 == move1);
            Assert.True(move1 != move2);
            Assert.True(move2 != move1);
            Assert.AreNotEqual(move1.GetHashCode(), move2.GetHashCode());
        }

        [TestCase(File.G, File.H, 5, 6, 4)]
        public static void TestInequality_DifferentRank(File f1, File f2, int r1, int r2, int r3)
        {
            var square1 = new Square(f1, r3);
            var square2 = new Square(f2, r1);
            var square3 = new Square(f1, r3);
            var square4 = new Square(f2, r2);
            var move1 = new Move(square1, square2, Player.Black);
            var move2 = new Move(square3, square4, Player.Black);

            Assert.AreNotEqual(move1, move2);
            Assert.False(move1.Equals(move2));
            Assert.False(move2.Equals(move1));
            Assert.False(move1 == move2);
            Assert.False(move2 == move1);
            Assert.True(move1 != move2);
            Assert.True(move2 != move1);
            Assert.AreNotEqual(move1.GetHashCode(), move2.GetHashCode()); // this test is pretty hard to read
        }

        [Test]
        public static void TestInequality_DifferentRankAndFile()
        {
            var square1 = new Square(File.G, 4);
            var square2 = new Square(File.H, 5);
            var square3 = new Square(File.A, 1);
            var square4 = new Square(File.B, 2);
            var move1 = new Move(square1, square2, Player.White);
            var move2 = new Move(square3, square4, Player.White);

            Assert.AreNotEqual(move1, move2);
            Assert.False(move1.Equals(move2));
            Assert.False(move2.Equals(move1));
            Assert.False(move1 == move2);
            Assert.False(move2 == move1);
            Assert.True(move1 != move2);
            Assert.True(move2 != move1);
            Assert.AreNotEqual(move1.GetHashCode(), move2.GetHashCode());
        }

        [Test]
        public static void TestInequality_DifferentType()
        {
            var square1 = new Square(File.G, 4);
            var square2 = new Square(File.G, 8);
            var move1 = new Move(square1, square2, Player.Black);

            Assert.False(move1.Equals(square1));
        }

        [Test]
        public static void TestInequality_OneIsNull()
        {
            var square1 = new Square(File.G, 4);
            var square2 = new Square(File.G, 8);
            var move1 = new Move(square1, square2, Player.Black);

            Assert.False(move1 == null);

            var move4 = new Move(square1, square2, Player.Black);

            Assert.False(null == move4);
        }
    }
}