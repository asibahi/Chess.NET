﻿using NUnit.Framework;

namespace ChessDotNet.Tests
{
    using System;
    using Pieces;

    [TestFixture]
    public static class FenConvertTests
    {
        static readonly Piece kw = new King(Player.White);
        static readonly Piece kb = new King(Player.Black);
        static readonly Piece qw = new Queen(Player.White);
        static readonly Piece qb = new Queen(Player.Black);
        static readonly Piece rw = new Rook(Player.White);
        static readonly Piece rb = new Rook(Player.Black);
        static readonly Piece nw = new Knight(Player.White);
        static readonly Piece nb = new Knight(Player.Black);
        static readonly Piece bw = new Bishop(Player.White);
        static readonly Piece bb = new Bishop(Player.Black);
        static readonly Piece pw = new Pawn(Player.White);
        static readonly Piece pb = new Pawn(Player.Black);
        static readonly Piece __ = null;

        [Test]
        public static void TestStartPosition()
        {
            Assert.AreEqual("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1", new ChessGame().GetFen());
        }

        [Test]
        public static void TestAfter1e4()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);

            Assert.AreEqual("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1", game.GetFen());
        }

        [Test]
        public static void TestAfter1c5()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);
            game.ApplyMove(new Move("C7", "C5", Player.Black), true);

            Assert.AreEqual("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2", game.GetFen());
        }

        [Test]
        public static void TestAfter2Nf3()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);
            game.ApplyMove(new Move("C7", "C5", Player.Black), true);
            game.ApplyMove(new Move("G1", "F3", Player.White), true);

            Assert.AreEqual("rnbqkbnr/pp1ppppp/8/2p5/4P3/5N2/PPPP1PPP/RNBQKB1R b KQkq - 1 2", game.GetFen());
        }

        [Test]
        public static void TestMovingWhiteKingLosingCastlingRights()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);
            game.ApplyMove(new Move("C7", "C5", Player.Black), true);
            game.ApplyMove(new Move("E1", "E2", Player.White), true);

            Assert.AreEqual("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPPKPPP/RNBQ1BNR b kq - 1 2", game.GetFen());
        }

        [Test]
        public static void TestMovingBlackKingLosingCastlingRights()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);
            game.ApplyMove(new Move("E7", "E5", Player.Black), true);
            game.ApplyMove(new Move("G1", "F3", Player.White), true);
            game.ApplyMove(new Move("E8", "E7", Player.Black), true);

            Assert.AreEqual("rnbq1bnr/ppppkppp/8/4p3/4P3/5N2/PPPP1PPP/RNBQKB1R w KQ - 2 3", game.GetFen());
        }

        [Test]
        public static void TestMovingWhiteARookLosingCastlingRights()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("A2", "A3", Player.White), true);
            game.ApplyMove(new Move("E7", "E5", Player.Black), true);
            game.ApplyMove(new Move("A1", "A2", Player.White), true);

            Assert.AreEqual("rnbqkbnr/pppp1ppp/8/4p3/8/P7/RPPPPPPP/1NBQKBNR b Kkq - 1 2", game.GetFen());
        }

        [Test]
        public static void TestMovingWhiteHRookLosingCastlingRights()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("H2", "H3", Player.White), true);
            game.ApplyMove(new Move("E7", "E5", Player.Black), true);
            game.ApplyMove(new Move("H1", "H2", Player.White), true);

            Assert.AreEqual("rnbqkbnr/pppp1ppp/8/4p3/8/7P/PPPPPPPR/RNBQKBN1 b Qkq - 1 2", game.GetFen());
        }

        [Test]
        public static void TestMovingBlackARookLosingCastlingRights()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);
            game.ApplyMove(new Move("A7", "A6", Player.Black), true);
            game.ApplyMove(new Move("G1", "F3", Player.White), true);
            game.ApplyMove(new Move("A8", "A7", Player.Black), true);

            Assert.AreEqual("1nbqkbnr/rppppppp/p7/8/4P3/5N2/PPPP1PPP/RNBQKB1R w KQk - 2 3", game.GetFen());
        }

        [Test]
        public static void TestMovingBlackHRookLosingCastlingRights()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);
            game.ApplyMove(new Move("H7", "H6", Player.Black), true);
            game.ApplyMove(new Move("G1", "F3", Player.White), true);
            game.ApplyMove(new Move("H8", "H7", Player.Black), true);

            Assert.AreEqual("rnbqkbn1/pppppppr/7p/8/4P3/5N2/PPPP1PPP/RNBQKB1R w KQq - 2 3", game.GetFen());
        }

        [Test]
        public static void TestHalfmoveClockAndFullmoveNumber()
        {
            var game = new ChessGame();
            game.ApplyMove(new Move("E2", "E4", Player.White), true);
            game.ApplyMove(new Move("E7", "E5", Player.Black), true);
            game.ApplyMove(new Move("E1", "E2", Player.White), true);
            game.ApplyMove(new Move("E8", "E7", Player.Black), true);
            game.ApplyMove(new Move("E2", "D3", Player.White), true);
            game.ApplyMove(new Move("E7", "D6", Player.Black), true);
            game.ApplyMove(new Move("D3", "C3", Player.White), true);
            game.ApplyMove(new Move("D6", "C6", Player.Black), true);
            game.ApplyMove(new Move("C3", "B3", Player.White), true);
            game.ApplyMove(new Move("C6", "B6", Player.Black), true);
            game.ApplyMove(new Move("B3", "A4", Player.White), true);
            game.ApplyMove(new Move("B6", "C5", Player.Black), true);
            game.ApplyMove(new Move("F1", "C4", Player.White), true);

            Assert.AreEqual("rnbq1bnr/pppp1ppp/8/2k1p3/K1B1P3/8/PPPP1PPP/RNBQ2NR b - - 11 7", game.GetFen());

            game.ApplyMove(new Move("C5", "C4", Player.Black), true);

            Assert.AreEqual("rnbq1bnr/pppp1ppp/8/4p3/K1k1P3/8/PPPP1PPP/RNBQ2NR w - - 0 8", game.GetFen());

            game.ApplyMove(new Move("A4", "A5", Player.White), true);
            game.ApplyMove(new Move("H7", "H5", Player.Black), true);

            Assert.AreEqual("rnbq1bnr/pppp1pp1/8/K3p2p/2k1P3/8/PPPP1PPP/RNBQ2NR w - h6 0 9", game.GetFen());
        }

        [Test]
        public static void TestChessGameFenConstructorStartPosition()
        {
            var game = new ChessGame("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1");
            var expected = new Piece[8][]
            {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, pw, pw, pw, pw, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };

            Assert.AreEqual(expected, game.GetBoard());
            Assert.AreEqual(0, game.HalfMoveClock);
            Assert.AreEqual(1, game.FullMoveNumber);
            Assert.AreEqual(Player.White, game.WhoseTurn);
            Assert.False(game.BlackKingMoved);
            Assert.False(game.BlackRookAMoved);
            Assert.False(game.BlackRookHMoved);
            Assert.False(game.WhiteKingMoved);
            Assert.False(game.WhiteRookAMoved);
            Assert.False(game.WhiteRookHMoved);
        }

        [Test]
        public static void TestChessGameFenConstructorAfter1e4()
        {
            var game = new ChessGame("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e3 0 1");
            var expected = new Piece[8][]
                 {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, pw, pw, pw, __, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
                 };

            Assert.AreEqual(expected, game.GetBoard());
            Assert.AreEqual(0, game.HalfMoveClock);
            Assert.AreEqual(1, game.FullMoveNumber);
            Assert.AreEqual(new Square("E2"), game.Moves[game.Moves.Count - 1].OriginalPosition);
            Assert.AreEqual(new Square("E4"), game.Moves[game.Moves.Count - 1].NewPosition);
            Assert.AreEqual(Player.White, game.Moves[game.Moves.Count - 1].Player);
            Assert.AreEqual(Player.Black, game.WhoseTurn);
        }

        [Test]
        public static void TestChessGameFenConstructorAfter1e3()
        {
            var game = new ChessGame("rnbqkbnr/pppppppp/8/8/8/4P3/PPPP1PPP/RNBQKBNR w KQkq - 0 1");
            var expected = new Piece[8][]
                 {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { pw, pw, pw, pw, __, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
                 };

            Assert.AreEqual(expected, game.GetBoard());
            Assert.AreEqual(0, game.HalfMoveClock);
            Assert.AreEqual(1, game.FullMoveNumber);
            Assert.AreEqual(0, game.Moves.Count);
        }

        [Test]
        public static void TestChessGameFenConstructorPartialCastlingRights()
        {
            var game = new ChessGame("rnbqkbn1/pppppppr/7p/8/4P3/5N2/PPPP1PPP/RNBQKB1R w KQq - 2 3");
            var expected = new Piece[8][]
                 {
                new[] { rb, nb, bb, qb, kb, bb, nb, __ },
                new[] { pb, pb, pb, pb, pb, pb, pb, rb },
                new[] { __, __, __, __, __, __, __, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, nw, __, __ },
                new[] { pw, pw, pw, pw, __, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, __, rw }
                  };

            Assert.AreEqual(expected, game.GetBoard());
            Assert.AreEqual(2, game.HalfMoveClock);
            Assert.AreEqual(3, game.FullMoveNumber);
            Assert.True(game.BlackRookHMoved);
        }

        [Test]
        public static void TestChessGameFenConstructorNoCastlingRights()
        {
            var game = new ChessGame("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w - - 16 9");
            var expected = new Piece[8][]
                 {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, pw, pw, pw, pw, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
                 };

            Assert.AreEqual(expected, game.GetBoard());
            Assert.AreEqual(16, game.HalfMoveClock);
            Assert.AreEqual(9, game.FullMoveNumber);
            Assert.AreEqual(Player.White, game.WhoseTurn);
            Assert.False(game.BlackKingMoved);
            Assert.True(game.BlackRookAMoved);
            Assert.True(game.BlackRookHMoved);
            Assert.False(game.WhiteKingMoved);
            Assert.True(game.WhiteRookAMoved);
            Assert.True(game.WhiteRookHMoved);
        }

        [Test]
        public static void TestChessGameFenConstructorAfter1e4c5()
        {
            var game = new ChessGame("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2");
            var expected = new Piece[8][]
                 {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, __, pb, pb, pb, pb, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, pb, __, __, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, pw, pw, pw, __, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
                 };

            Assert.AreEqual(expected, game.GetBoard());
            Assert.AreEqual(0, game.HalfMoveClock);
            Assert.AreEqual(2, game.FullMoveNumber);
            Assert.AreEqual(Player.White, game.WhoseTurn);
            Assert.AreEqual(new Square("C7"), game.Moves[game.Moves.Count - 1].OriginalPosition);
            Assert.AreEqual(new Square("C5"), game.Moves[game.Moves.Count - 1].NewPosition);
            Assert.AreEqual(Player.Black, game.Moves[game.Moves.Count - 1].Player);
        }

        [TestCase("rnbqkbnr/pppppppp/8/8/8/4P3/PPPP1PPP/RNBQKBNR b KQkq e3 0 1")]
        [TestCase("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq e6 0 1")]
        [TestCase("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq")]
        [TestCase("rnbqkbnr/pp1ppppp/8/2p5/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c3 0 2")]
        [TestCase("rnbqkbnr/pp1ppppp/2p5/8/4P3/8/PPPP1PPP/RNBQKBNR w KQkq c6 0 2")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP w KQkq - 0 1")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNZ w KQkq - 0 1")]
        [TestCase("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBN w KQkq - 0 1")]
        public static void TestChessGameFenConstructorInvalid(string fen)
        {
            Assert.Throws<ArgumentException>(() => { var game = new ChessGame(fen); });
        }
    }
}