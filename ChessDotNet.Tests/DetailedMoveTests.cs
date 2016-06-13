using NUnit.Framework;

namespace ChessDotNet.Tests
{
    using Pieces;

    [TestFixture]
    public static class DetailedMoveTests
    {
        [Test]
        public static void TestEquality()
        {
            var move1 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Pawn(Player.White), false, CastlingType.None);
            var move2 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Pawn(Player.White), false, CastlingType.None);

            Assert.AreEqual(move1, move2);
            Assert.True(move1.Equals(move2));
            Assert.True(move2.Equals(move1));
            Assert.True(move1 == move2);
            Assert.True(move2 == move1);
            Assert.True(null == (DetailedMove)null);
            Assert.False(move1 != move2);
            Assert.False(move2 != move1);
            Assert.AreEqual(move1.GetHashCode(), move2.GetHashCode());
        }

        [Test]
        public static void TestInequality_DifferentCastlingType()
        {
            var move1 = new DetailedMove(new Square(File.E, 1), new Square(File.C, 1), Player.White, null, new King(Player.White), true, CastlingType.QueenSide);
            var move2 = new DetailedMove(new Square(File.E, 1), new Square(File.G, 1), Player.White, null, new King(Player.White), false, CastlingType.KingSide);

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
        public static void TestInequality_DifferentIsCapture()
        {
            var move1 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Queen(Player.White), true, CastlingType.None);
            var move2 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Queen(Player.White), false, CastlingType.None);

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
        public static void TestInequality_DifferentPiece()
        {
            var move1 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Pawn(Player.White), false, CastlingType.None);
            var move2 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Queen(Player.White), false, CastlingType.None);

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
        public static void TestInequality_DifferentPlayer()
        {
            var move1 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Pawn(Player.White), false, CastlingType.None);
            var move2 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.Black, null, new Pawn(Player.Black), false, CastlingType.None);

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
            var move1 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Pawn(Player.White), false, CastlingType.None);
            var move2 = new DetailedMove(new Square(File.E, 2), new Square(File.E, 4), Player.White, null, new Queen(Player.White), false, CastlingType.None);

            Assert.AreNotEqual(move1, move2);
            Assert.False(move1.Equals(move2));
            Assert.False(move2.Equals(move1));
            Assert.False(move1 == move2);
            Assert.False(move2 == move1);
            Assert.True(move1 != move2);
            Assert.True(move2 != move1);
            Assert.AreNotEqual(move1.GetHashCode(), move2.GetHashCode());
        }
    }
}