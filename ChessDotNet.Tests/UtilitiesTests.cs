using System;
using NUnit.Framework;

namespace ChessDotNet.Tests
{
    using Pieces;

    [TestFixture]
    public static class UtilitiesTests
    {
        [Test]
        public static void TestGetOpponentOf()
        {
            Assert.AreEqual(Player.Black, ChessUtilities.GetOpponentOf(Player.White));
            Assert.AreEqual(Player.White, ChessUtilities.GetOpponentOf(Player.Black));
            Assert.Throws<ArgumentException>(() => ChessUtilities.GetOpponentOf(Player.None));
        }

        [Test]
        public static void TestThrowIfNull()
        {
            Assert.Throws<ArgumentNullException>(()
                => ChessUtilities.ThrowIfNull(null, "value"));

            Assert.DoesNotThrow(()
                => ChessUtilities.ThrowIfNull(new Bishop(Player.White), "peice"));
        }
    }
}