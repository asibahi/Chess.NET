using NUnit.Framework;

namespace ChessDotNet.Tests
{
    using Pieces;

    [TestFixture]
    public static class ChessPieceTests
    {
        [Test]
        public static void TestEquality()
        {
            var piece1 = new King(Player.White);
            var piece2 = new King(Player.White);

            Assert.AreEqual(piece1, piece2);
            Assert.True(piece1.Equals(piece2));
            Assert.True(piece2.Equals(piece1));
            Assert.True(piece1 == piece2);
            Assert.True(piece2 == piece1);
            Assert.False(piece1 != piece2);
            Assert.False(piece2 != piece1);
            Assert.AreEqual(piece1.GetHashCode(), piece2.GetHashCode());
        }

        [Test]
        public static void TestInequality_DifferentPiece()
        {
            var piece1 = new King(Player.Black);
            var piece2 = new Queen(Player.Black);

            Assert.AreNotEqual(piece1, piece2);
            Assert.False(piece1.Equals(piece2));
            Assert.False(piece2.Equals(piece1));
            Assert.False(piece1 == piece2);
            Assert.False(piece2 == piece1);
            Assert.True(piece1 != piece2);
            Assert.True(piece2 != piece1);
            Assert.AreNotEqual(piece1.GetHashCode(), piece2.GetHashCode());
        }

        [Test]
        public static void TestInequality_DifferentPieceAndPlayer()
        {
            var piece1 = new King(Player.White);
            var piece2 = new Queen(Player.Black);

            Assert.AreNotEqual(piece1, piece2);
            Assert.False(piece1.Equals(piece2));
            Assert.False(piece2.Equals(piece1));
            Assert.False(piece1 == piece2);
            Assert.False(piece2 == piece1);
            Assert.True(piece1 != piece2);
            Assert.True(piece2 != piece1);
            Assert.AreNotEqual(piece1.GetHashCode(), piece2.GetHashCode());
        }

        [Test]
        public static void TestInequality_DifferentPlayer()
        {
            var piece1 = new King(Player.White);
            var piece2 = new King(Player.Black);

            Assert.AreNotEqual(piece1, piece2);
            Assert.False(piece1.Equals(piece2));
            Assert.False(piece2.Equals(piece1));
            Assert.False(piece1 == piece2);
            Assert.False(piece2 == piece1);
            Assert.True(piece1 != piece2);
            Assert.True(piece2 != piece1);
            Assert.AreNotEqual(piece1.GetHashCode(), piece2.GetHashCode());
        }

        [Test]
        public static void TestInEquality_OneIsNull()
        {
            var piece1 = new Rook(Player.White);
            Piece piece2 = null;

            Assert.AreNotEqual(piece1, piece2);
            Assert.False(piece1.Equals(piece2));
            Assert.False(piece1 == piece2);
            Assert.False(piece2 == piece1);
            Assert.True(piece1 != piece2);
            Assert.True(piece2 != piece1);

            piece1 = null;
            piece2 = new Bishop(Player.Black);

            Assert.AreNotEqual(piece1, piece2);
            Assert.False(piece2.Equals(piece1));
            Assert.False(piece1 == piece2);
            Assert.False(piece2 == piece1);
            Assert.True(piece1 != piece2);
            Assert.True(piece2 != piece1);
        }
    }
}