using System.Collections.Generic;
using System.Collections.ObjectModel;
using NUnit.Framework;

namespace ChessDotNet.Tests
{
    using Pieces;

    [TestFixture]
    public static class ChessGameTests
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
        public static void TestArrayGetting()
        {
            var board = new ChessGame().GetBoard();
            Assert.AreEqual(rw, board[7][(int)File.A]);
            Assert.AreEqual(nw, board[7][(int)File.B]);
            Assert.AreEqual(bw, board[7][(int)File.C]);
            Assert.AreEqual(qw, board[7][(int)File.D]);
            Assert.AreEqual(kw, board[7][(int)File.E]);
            Assert.AreEqual(bw, board[7][(int)File.F]);
            Assert.AreEqual(nw, board[7][(int)File.G]);
            Assert.AreEqual(rw, board[7][(int)File.H]);
            Assert.AreEqual(pw, board[6][(int)File.A]);
            Assert.AreEqual(pw, board[6][(int)File.B]);
            Assert.AreEqual(pw, board[6][(int)File.C]);
            Assert.AreEqual(pw, board[6][(int)File.D]);
            Assert.AreEqual(pw, board[6][(int)File.E]);
            Assert.AreEqual(pw, board[6][(int)File.F]);
            Assert.AreEqual(pw, board[6][(int)File.G]);
            Assert.AreEqual(pw, board[6][(int)File.H]);
            Assert.AreEqual(__, board[5][(int)File.A]);
            Assert.AreEqual(__, board[5][(int)File.B]);
            Assert.AreEqual(__, board[5][(int)File.C]);
            Assert.AreEqual(__, board[5][(int)File.D]);
            Assert.AreEqual(__, board[5][(int)File.E]);
            Assert.AreEqual(__, board[5][(int)File.F]);
            Assert.AreEqual(__, board[5][(int)File.G]);
            Assert.AreEqual(__, board[5][(int)File.H]);
            Assert.AreEqual(__, board[4][(int)File.A]);
            Assert.AreEqual(__, board[4][(int)File.B]);
            Assert.AreEqual(__, board[4][(int)File.C]);
            Assert.AreEqual(__, board[4][(int)File.D]);
            Assert.AreEqual(__, board[4][(int)File.E]);
            Assert.AreEqual(__, board[4][(int)File.F]);
            Assert.AreEqual(__, board[4][(int)File.G]);
            Assert.AreEqual(__, board[4][(int)File.H]);
            Assert.AreEqual(__, board[3][(int)File.A]);
            Assert.AreEqual(__, board[3][(int)File.B]);
            Assert.AreEqual(__, board[3][(int)File.C]);
            Assert.AreEqual(__, board[3][(int)File.D]);
            Assert.AreEqual(__, board[3][(int)File.E]);
            Assert.AreEqual(__, board[3][(int)File.F]);
            Assert.AreEqual(__, board[3][(int)File.G]);
            Assert.AreEqual(__, board[3][(int)File.H]);
            Assert.AreEqual(__, board[2][(int)File.A]);
            Assert.AreEqual(__, board[2][(int)File.B]);
            Assert.AreEqual(__, board[2][(int)File.C]);
            Assert.AreEqual(__, board[2][(int)File.D]);
            Assert.AreEqual(__, board[2][(int)File.E]);
            Assert.AreEqual(__, board[2][(int)File.F]);
            Assert.AreEqual(__, board[2][(int)File.G]);
            Assert.AreEqual(__, board[2][(int)File.H]);
            Assert.AreEqual(pb, board[1][(int)File.A]);
            Assert.AreEqual(pb, board[1][(int)File.B]);
            Assert.AreEqual(pb, board[1][(int)File.C]);
            Assert.AreEqual(pb, board[1][(int)File.D]);
            Assert.AreEqual(pb, board[1][(int)File.E]);
            Assert.AreEqual(pb, board[1][(int)File.F]);
            Assert.AreEqual(pb, board[1][(int)File.G]);
            Assert.AreEqual(pb, board[1][(int)File.H]);
            Assert.AreEqual(rb, board[0][(int)File.A]);
            Assert.AreEqual(nb, board[0][(int)File.B]);
            Assert.AreEqual(bb, board[0][(int)File.C]);
            Assert.AreEqual(qb, board[0][(int)File.D]);
            Assert.AreEqual(kb, board[0][(int)File.E]);
            Assert.AreEqual(bb, board[0][(int)File.F]);
            Assert.AreEqual(nb, board[0][(int)File.G]);
            Assert.AreEqual(rb, board[0][(int)File.H]);
        }

        [Test]
        public static void TestGetPieceAt()
        {
            var cb = new ChessGame();
            Assert.AreEqual(rw, cb.GetPieceAt(File.A, 1));
            Assert.AreEqual(nw, cb.GetPieceAt(File.B, 1));
            Assert.AreEqual(bw, cb.GetPieceAt(File.C, 1));
            Assert.AreEqual(qw, cb.GetPieceAt(File.D, 1));
            Assert.AreEqual(kw, cb.GetPieceAt(File.E, 1));
            Assert.AreEqual(bw, cb.GetPieceAt(File.F, 1));
            Assert.AreEqual(nw, cb.GetPieceAt(File.G, 1));
            Assert.AreEqual(rw, cb.GetPieceAt(File.H, 1));
            Assert.AreEqual(pw, cb.GetPieceAt(File.A, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.B, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.C, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.D, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.E, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.F, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.G, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.H, 2));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.C, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.C, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.C, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.C, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 6));
            Assert.AreEqual(pb, cb.GetPieceAt(File.A, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.B, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.C, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.D, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.E, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.F, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.G, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.H, 7));
            Assert.AreEqual(rb, cb.GetPieceAt(File.A, 8));
            Assert.AreEqual(nb, cb.GetPieceAt(File.B, 8));
            Assert.AreEqual(bb, cb.GetPieceAt(File.C, 8));
            Assert.AreEqual(qb, cb.GetPieceAt(File.D, 8));
            Assert.AreEqual(kb, cb.GetPieceAt(File.E, 8));
            Assert.AreEqual(bb, cb.GetPieceAt(File.F, 8));
            Assert.AreEqual(nb, cb.GetPieceAt(File.G, 8));
            Assert.AreEqual(rb, cb.GetPieceAt(File.H, 8));
        }

        [Test]
        public static void TestCustomInitialize()
        {
            var board = new Piece[8][]{
                new[] { rb, __, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, pb, pb, pb, pb },
                new[] { __, __, nb, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, pw, pw, pw, __, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
            };

            var cb = new ChessGame(board, Player.White);
            Assert.AreEqual(rw, cb.GetPieceAt(File.A, 1));
            Assert.AreEqual(nw, cb.GetPieceAt(File.B, 1));
            Assert.AreEqual(bw, cb.GetPieceAt(File.C, 1));
            Assert.AreEqual(qw, cb.GetPieceAt(File.D, 1));
            Assert.AreEqual(kw, cb.GetPieceAt(File.E, 1));
            Assert.AreEqual(bw, cb.GetPieceAt(File.F, 1));
            Assert.AreEqual(nw, cb.GetPieceAt(File.G, 1));
            Assert.AreEqual(rw, cb.GetPieceAt(File.H, 1));
            Assert.AreEqual(pw, cb.GetPieceAt(File.A, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.B, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.C, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.D, 2));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.F, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.G, 2));
            Assert.AreEqual(pw, cb.GetPieceAt(File.H, 2));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.C, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 3));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.C, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 4));
            Assert.AreEqual(pw, cb.GetPieceAt(File.E, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 4));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.C, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 5));
            Assert.AreEqual(__, cb.GetPieceAt(File.A, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 6));
            Assert.AreEqual(nb, cb.GetPieceAt(File.C, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.D, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.E, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.F, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.G, 6));
            Assert.AreEqual(__, cb.GetPieceAt(File.H, 6));
            Assert.AreEqual(pb, cb.GetPieceAt(File.A, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.B, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.C, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.D, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.E, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.F, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.G, 7));
            Assert.AreEqual(pb, cb.GetPieceAt(File.H, 7));
            Assert.AreEqual(rb, cb.GetPieceAt(File.A, 8));
            Assert.AreEqual(__, cb.GetPieceAt(File.B, 8));
            Assert.AreEqual(bb, cb.GetPieceAt(File.C, 8));
            Assert.AreEqual(qb, cb.GetPieceAt(File.D, 8));
            Assert.AreEqual(kb, cb.GetPieceAt(File.E, 8));
            Assert.AreEqual(bb, cb.GetPieceAt(File.F, 8));
            Assert.AreEqual(nb, cb.GetPieceAt(File.G, 8));
            Assert.AreEqual(rb, cb.GetPieceAt(File.H, 8));
        }

        [Test]
        public static void TestValidMoveWhitePawn()
        {
            var cb = new ChessGame();

            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveWhitePawn_2Steps()
        {
            var cb = new ChessGame();

            var move1 = new Move(new Square(File.D, 2), new Square(File.D, 4), Player.White);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveWhitePawn_Capture()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 4), Player.White);
            var move2 = new Move(new Square(File.D, 7), new Square(File.D, 5), Player.Black);
            var move3 = new Move(new Square(File.E, 4), new Square(File.D, 5), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhitePawn_EnPassant()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 4), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 6), Player.Black);
            var move3 = new Move(new Square(File.E, 4), new Square(File.E, 5), Player.White);
            var move4 = new Move(new Square(File.D, 7), new Square(File.D, 5), Player.Black);
            var move5 = new Move(new Square(File.E, 5), new Square(File.D, 6), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.True(cb.IsValidMove(move5));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_EnPassant()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 4), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 6), Player.Black);
            var move3 = new Move(new Square(File.E, 4), new Square(File.E, 5), Player.White);
            var move4 = new Move(new Square(File.H, 7), new Square(File.H, 5), Player.Black);
            var move5 = new Move(new Square(File.E, 5), new Square(File.D, 6), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.False(cb.IsValidMove(move5));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_EnPassant_NoPawn()
        {
            var board = new Piece[8][]
            {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, rb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, pw, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
            };
            var game = new ChessGame(board, Player.Black);

            var move1 = new Move(new Square(File.E, 7), new Square(File.E, 5), Player.Black);
            var move2 = new Move(new Square(File.F, 5), new Square(File.E, 6), Player.White);
            game.ApplyMove(move1, true);

            Assert.False(game.IsValidMove(move2));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_NoCapture()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 4), Player.White);
            var move2 = new Move(new Square(File.D, 7), new Square(File.D, 6), Player.Black);
            var move3 = new Move(new Square(File.E, 4), new Square(File.D, 5), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_2StepsBlockingPiece()
        {
            var board = new Piece[8][]
            {
                new[] { kw, __, kb, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, pb, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
            };
            var cb = new ChessGame(board, Player.White);
            var move = new Move(new Square(File.E, 2), new Square(File.E, 4), Player.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveWhitePawn_2StepsNotOnRank2()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            var move2 = new Move(new Square(File.E, 3), new Square(File.E, 5), Player.White);

            cb.ApplyMove(move1, true);

            Assert.False(cb.IsValidMove(move2));
        }

        [Test]
        public static void TestValidMoveWhiteKnight()
        {
            var cb = new ChessGame();

            var move1 = new Move(new Square(File.B, 1), new Square(File.C, 3), Player.White);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveWhiteBishopC()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.D, 2), new Square(File.D, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.C, 1), new Square(File.F, 4), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteBishopF()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.F, 1), new Square(File.C, 4), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteRookA()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.A, 1), new Square(File.A, 2), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteRookH()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 1), new Square(File.H, 2), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteQueenDiagonal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.D, 1), new Square(File.H, 5), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteQueenVertical()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.D, 2), new Square(File.D, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.D, 1), new Square(File.D, 2), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteQueenHorizontal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.B, 1), new Square(File.C, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.D, 2), new Square(File.D, 3), Player.White);
            var move4 = new Move(new Square(File.B, 7), new Square(File.B, 6), Player.Black);
            var move5 = new Move(new Square(File.C, 1), new Square(File.D, 2), Player.White);
            var move6 = new Move(new Square(File.C, 7), new Square(File.C, 6), Player.Black);
            var move7 = new Move(new Square(File.D, 1), new Square(File.C, 1), Player.White);
            var move8 = new Move(new Square(File.D, 1), new Square(File.B, 1), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);
            cb.ApplyMove(move6, true);

            Assert.True(cb.IsValidMove(move7));
            Assert.True(cb.IsValidMove(move8));
        }

        [Test]
        public static void TestValidMoveWhiteKingDiagonal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.F, 2), new Square(File.F, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.E, 1), new Square(File.F, 2), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteKingHorizontal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.D, 2), new Square(File.D, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.D, 1), new Square(File.D, 2), Player.White);
            var move4 = new Move(new Square(File.H, 7), new Square(File.H, 6), Player.Black);
            var move5 = new Move(new Square(File.E, 1), new Square(File.D, 1), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);

            Assert.True(cb.IsValidMove(move5));
        }

        [Test]
        public static void TestValidMoveWhiteKingVertical()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            var move2 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);
            var move3 = new Move(new Square(File.E, 1), new Square(File.E, 2), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.True(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveWhiteKing_KingsideCastling()
        {
            var board = new Piece[8][]
            {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, rw }
            };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveWhiteKing_QueensideCastling()
        {
            var board = new Piece[8][]
             {
                new[] { __, __, __, kb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, kw, __, __, rw }
             };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_WouldPassThroughCheck()
        {
            var board = new Piece[8][]
            {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, rb, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, rw }
            };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_WouldPassThroughCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, rb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveWhiteKing_KingsideCastling_WouldNotPassThroughCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, kw, __, __, rw }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveWhiteKing_QueensideCastling_WouldNotPassThroughCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, rb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_BlockingPiece1()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, rw, rw }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_BlockingPiece1()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, kb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, rw, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_BlockingPiece2()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, rw, __, rw }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_BlockingPiece2()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, rw, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_BlockingPiece3()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, rw, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_NoRook()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_NoRook()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_RookMoved()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, rw }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.H, 1), new Square(File.H, 2), Player.White);
            var move2 = new Move(new Square(File.B, 8), new Square(File.B, 7), Player.Black);
            var move3 = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_RookMoved()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.A, 1), new Square(File.A, 2), Player.White);
            var move2 = new Move(new Square(File.B, 8), new Square(File.B, 7), Player.Black);
            var move3 = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_KingsideCastling_KingMoved()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, rw }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.D, 1), Player.White);
            var move2 = new Move(new Square(File.B, 8), new Square(File.B, 7), Player.Black);
            var move3 = new Move(new Square(File.D, 1), new Square(File.F, 1), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveWhiteKing_QueensideCastling_KingMoved()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move1 = new Move(new Square(File.E, 1), new Square(File.D, 1), Player.White);
            var move2 = new Move(new Square(File.B, 8), new Square(File.B, 7), Player.Black);
            var move3 = new Move(new Square(File.D, 1), new Square(File.B, 1), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestValidMoveBlackPawn()
        {
            var cb = new ChessGame();
            cb.ApplyMove(new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White), true);

            var move1 = new Move(new Square(File.A, 7), new Square(File.A, 6), Player.Black);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveBlackPawn_2Steps()
        {
            var cb = new ChessGame();
            cb.ApplyMove(new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White), true);

            var move1 = new Move(new Square(File.D, 7), new Square(File.D, 5), Player.Black);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveBlackPawn_Capture()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 5), Player.Black);
            var move3 = new Move(new Square(File.D, 2), new Square(File.D, 4), Player.White);
            var move4 = new Move(new Square(File.E, 5), new Square(File.D, 4), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackPawn_EnPassant()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.B, 1), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 5), Player.Black);
            var move3 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            var move4 = new Move(new Square(File.E, 5), new Square(File.E, 4), Player.Black);
            var move5 = new Move(new Square(File.D, 2), new Square(File.D, 4), Player.White);
            var move6 = new Move(new Square(File.E, 4), new Square(File.D, 3), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.True(cb.IsValidMove(move6));
        }

        [Test]
        public static void TestInvalidMoveBlackPawn_EnPassant()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.B, 1), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 5), Player.Black);
            var move3 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            var move4 = new Move(new Square(File.E, 5), new Square(File.E, 4), Player.Black);
            var move5 = new Move(new Square(File.H, 2), new Square(File.H, 4), Player.White);
            var move6 = new Move(new Square(File.E, 4), new Square(File.D, 3), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.False(cb.IsValidMove(move6));
        }

        [Test]
        public static void TestInvalidMoveBlackPawn_NoCapture()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 5), Player.Black);
            var move3 = new Move(new Square(File.D, 2), new Square(File.D, 3), Player.White);
            var move4 = new Move(new Square(File.E, 5), new Square(File.D, 4), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.False(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestInvalidMoveBlackPawn_2StepsBlockingPiece()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, pb, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kw, __, kb, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move = new Move(new Square(File.E, 7), new Square(File.E, 5), Player.Black);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveBlackPawn_2StepsNotOnRank7()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.E, 6), new Square(File.E, 4), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.False(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackKnight()
        {
            var cb = new ChessGame();
            cb.ApplyMove(new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White), true);

            var move1 = new Move(new Square(File.B, 8), new Square(File.C, 6), Player.Black);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveBlackBishopC()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.D, 7), new Square(File.D, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.C, 8), new Square(File.F, 5), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackBishopF()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.F, 8), new Square(File.C, 5), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackQueenDiagonal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.D, 8), new Square(File.H, 4), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackQueenVertical()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.D, 7), new Square(File.D, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.D, 8), new Square(File.D, 7), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackQueenHorizontal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.B, 8), new Square(File.C, 6), Player.Black);
            var move3 = new Move(new Square(File.B, 2), new Square(File.B, 3), Player.White);
            var move4 = new Move(new Square(File.D, 7), new Square(File.D, 6), Player.Black);
            var move5 = new Move(new Square(File.C, 2), new Square(File.C, 3), Player.White);
            var move6 = new Move(new Square(File.C, 8), new Square(File.D, 7), Player.Black);
            var move7 = new Move(new Square(File.D, 2), new Square(File.D, 3), Player.White);
            var move8 = new Move(new Square(File.D, 8), new Square(File.C, 8), Player.Black);
            var move9 = new Move(new Square(File.D, 8), new Square(File.B, 8), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);
            cb.ApplyMove(move6, true);
            cb.ApplyMove(move7, true);

            Assert.True(cb.IsValidMove(move8));
            Assert.True(cb.IsValidMove(move9));
        }

        [Test]
        public static void TestValidMoveBlackKingDiagonal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.F, 7), new Square(File.F, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.E, 8), new Square(File.F, 7), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackKingHorizontal()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.D, 7), new Square(File.D, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.D, 8), new Square(File.D, 7), Player.Black);
            var move5 = new Move(new Square(File.B, 2), new Square(File.B, 3), Player.White);
            var move6 = new Move(new Square(File.E, 8), new Square(File.D, 8), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            Assert.True(cb.IsValidMove(move6));
        }

        [Test]
        public static void TestValidMoveBlackKingVertical()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 6), Player.Black);
            var move3 = new Move(new Square(File.H, 2), new Square(File.H, 3), Player.White);
            var move4 = new Move(new Square(File.E, 8), new Square(File.E, 7), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);

            Assert.True(cb.IsValidMove(move4));
        }

        [Test]
        public static void TestValidMoveBlackKing_KingsideCastling()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveBlackKing_QueensideCastling()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_WouldPassThroughCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, rw, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_WouldPassThroughCheck()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, rw, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveBlackKing_KingsideCastling_WouldNotPassThroughCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, rw }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestValidMoveBlackKing_QueensideCastling_WouldNotPassThroughCheck()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, rw, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            Assert.True(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_BlockingPiece1()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, rb, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __}
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_BlockingPiece1()
        {
            var board = new Piece[8][]
                {
                new[] { rb, rb, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_BlockingPiece2()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, rb, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_BlockingPiece2()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, rb, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_BlockingPiece3()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, __, rb, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_NoRook()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_NoRook()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            Assert.False(cb.IsValidMove(move1));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_RookMoved()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, kw, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.H, 8), new Square(File.H, 7), Player.Black);
            var move2 = new Move(new Square(File.B, 1), new Square(File.B, 2), Player.White);
            var move3 = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_RookMoved()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, kw, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.A, 8), new Square(File.A, 7), Player.Black);
            var move2 = new Move(new Square(File.B, 1), new Square(File.B, 2), Player.White);
            var move3 = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_KingsideCastling_KingMoved()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, kw, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.D, 8), Player.Black);
            var move2 = new Move(new Square(File.B, 1), new Square(File.B, 2), Player.White);
            var move3 = new Move(new Square(File.D, 8), new Square(File.F, 8), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_QueensideCastling_KingMoved()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, kw, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.E, 8), new Square(File.D, 8), Player.Black);
            var move2 = new Move(new Square(File.B, 1), new Square(File.B, 2), Player.White);
            var move3 = new Move(new Square(File.D, 8), new Square(File.B, 8), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);

            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestInvalidMoveWhite_WouldBeInCheck()
        {
            var board = new Piece[8][]
                {
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, qb },
                new[] { pw, __, __, pb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move = new Move(new Square(File.A, 8), new Square(File.A, 7), Player.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveWhite_WouldBeCheckmated()
        {
            var board = new Piece[8][]
                {
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, rb },
                new[] { __, __, __, kw, nb, __, rb, __ }
                };

            var cb = new ChessGame(board, Player.White);
            var move = new Move(new Square(File.D, 1), new Square(File.E, 1), Player.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveWhiteRook_NoPassThrough()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, kw, __, kb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var move = new Move(new Square(File.A, 7), new Square(File.G, 7), Player.White);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveBlackKing_NoAdjacentKings()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kb, __, kw, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            var move1 = new Move(new Square(File.D, 6), new Square(File.E, 6), Player.Black);
            var move2 = new Move(new Square(File.D, 6), new Square(File.E, 7), Player.Black);
            var move3 = new Move(new Square(File.D, 6), new Square(File.E, 5), Player.Black);

            Assert.False(cb.IsValidMove(move1));
            Assert.False(cb.IsValidMove(move2));
            Assert.False(cb.IsValidMove(move3));
        }

        [Test]
        public static void TestApplyMoveWhitePawn()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            Assert.AreNotEqual(cb.ApplyMove(move1, false), MoveType.Invalid);
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
            Assert.AreEqual(expected, cb.GetBoard());

            var move2 = new Move(new Square(File.E, 3), new Square(File.E, 4), Player.White);

            Assert.AreNotEqual(cb.ApplyMove(move2, true), MoveType.Invalid);

            expected = new Piece[8][]
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

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveWhitePawn_EnPassant()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.E, 2), new Square(File.E, 4), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 6), Player.Black);
            var move3 = new Move(new Square(File.E, 4), new Square(File.E, 5), Player.White);
            var move4 = new Move(new Square(File.D, 7), new Square(File.D, 5), Player.Black);
            var move5 = new Move(new Square(File.E, 5), new Square(File.D, 6), Player.White);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);

            var board = new Piece[8][]
                {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, __, __, pb, pb, pb },
                new[] { __, __, __, pw, pb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, pw, pw, pw, __, pw, pw, pw },
                new[] { rw, nw, bw, qw, kw, bw, nw, rw }
                };

            Assert.AreEqual(board, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveWhitePawn_PromotionToQueen()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var move = new Move(new Square(File.A, 7), new Square(File.A, 8), Player.White, new Queen(Player.White));
            var cb = new ChessGame(board, Player.White);

            Assert.AreNotEqual(cb.ApplyMove(move, false), MoveType.Invalid);

            var expected = new Piece[8][]
                {
                new[] { qw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveBlackPawn_PromotionToQueen()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kw, __, kb, pb, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var move = new Move(new Square(File.G, 2), new Square(File.G, 1), Player.Black, new Queen(Player.Black));
            var cb = new ChessGame(board, Player.Black);
            Assert.AreNotEqual(cb.ApplyMove(move, false), MoveType.Invalid);

            var expected = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, qb, __ }
                };
            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestInvalidMoveWhitePawnPromotion_NoPieceSpecified()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var move = new Move(new Square(File.A, 7), new Square(File.A, 8), Player.White);
            var cb = new ChessGame(board, Player.White);
            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestInvalidMoveBlackPawnPromotion_NoPieceSpecified()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kw, __, kb, pb, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var move = new Move(new Square(File.G, 2), new Square(File.G, 1), Player.Black);
            var cb = new ChessGame(board, Player.Black);

            Assert.False(cb.IsValidMove(move));
        }

        [Test]
        public static void TestApplyMoveBlackPawn_EnPassant()
        {
            var cb = new ChessGame();
            var move1 = new Move(new Square(File.B, 1), new Square(File.A, 3), Player.White);
            var move2 = new Move(new Square(File.E, 7), new Square(File.E, 5), Player.Black);
            var move3 = new Move(new Square(File.E, 2), new Square(File.E, 3), Player.White);
            var move4 = new Move(new Square(File.E, 5), new Square(File.E, 4), Player.Black);
            var move5 = new Move(new Square(File.D, 2), new Square(File.D, 4), Player.White);
            var move6 = new Move(new Square(File.E, 4), new Square(File.D, 3), Player.Black);

            cb.ApplyMove(move1, true);
            cb.ApplyMove(move2, true);
            cb.ApplyMove(move3, true);
            cb.ApplyMove(move4, true);
            cb.ApplyMove(move5, true);
            cb.ApplyMove(move6, true);

            var board = new Piece[8][]
                {
                new[] { rb, nb, bb, qb, kb, bb, nb, rb },
                new[] { pb, pb, pb, pb, __, pb, pb, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { nw, __, __, pb, pw, __, __, __ },
                new[] { pw, pw, pw, __, __, pw, pw, pw },
                new[] { rw, __, bw, qw, kw, bw, nw, rw }
                };

            Assert.AreEqual(board, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveWhiteKing_KingsideCastling()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, rw }
                };
            var move = new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White);
            var cb = new ChessGame(board, Player.White);
            cb.ApplyMove(move, true);

            var expected = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, rw, kw, __ }
                };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveWhiteKing_QueensideCastling()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { rw, __, __, __, kw, __, __, __ }
                };
            var move = new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White);
            var cb = new ChessGame(board, Player.White);
            cb.ApplyMove(move, true);

            var expected = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, kw, rw, __, __, __, __ }
                };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveBlackKing_KingsideCastling()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, rb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var move = new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black);
            var cb = new ChessGame(board, Player.Black);
            cb.ApplyMove(move, true);

            var expected = new Piece[8][]
                {
                new[] { __, __, __, __, __, rb, kb, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestApplyMoveBlackKing_QueensideCastling()
        {
            var board = new Piece[8][]
                {
                new[] { rb, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };
            var move = new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black);
            var cb = new ChessGame(board, Player.Black);
            cb.ApplyMove(move, true);

            var expected = new Piece[8][]
                {
                new[] { __, __, kb, rb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ }
                };

            Assert.AreEqual(expected, cb.GetBoard());
        }

        [Test]
        public static void TestGetValidMovesWhiteStartingPosition()
        {
            var cb = new ChessGame();
            var actual = cb.GetValidMoves(Player.White);

            var expected = new List<Move>
            {
                new Move("A2", "A3", Player.White),
                new Move("A2", "A4", Player.White),
                new Move("B2", "B3", Player.White),
                new Move("B2", "B4", Player.White),
                new Move("C2", "C3", Player.White),
                new Move("C2", "C4", Player.White),
                new Move("D2", "D3", Player.White),
                new Move("D2", "D4", Player.White),
                new Move("E2", "E3", Player.White),
                new Move("E2", "E4", Player.White),
                new Move("F2", "F3", Player.White),
                new Move("F2", "F4", Player.White),
                new Move("G2", "G3", Player.White),
                new Move("G2", "G4", Player.White),
                new Move("H2", "H3", Player.White),
                new Move("H2", "H4", Player.White),
                new Move("B1", "A3", Player.White),
                new Move("B1", "C3", Player.White),
                new Move("G1", "F3", Player.White),
                new Move("G1", "H3", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);

            foreach(var move in expected)
                Assert.True(actual.Contains(move));
        }

        [Test]
        public static void TestGetValidMovesBlackStartingPosition()
        {
            var cb = new ChessGame();
            cb.ApplyMove(new Move(new Square(File.A, 2), new Square(File.A, 3), Player.White), true);
            var actual = cb.GetValidMoves(Player.Black);
            var expected = new List<Move>
            {
                new Move("A7", "A6", Player.Black),
                new Move("A7", "A5", Player.Black),
                new Move("B7", "B6", Player.Black),
                new Move("B7", "B5", Player.Black),
                new Move("C7", "C6", Player.Black),
                new Move("C7", "C5", Player.Black),
                new Move("D7", "D6", Player.Black),
                new Move("D7", "D5", Player.Black),
                new Move("E7", "E6", Player.Black),
                new Move("E7", "E5", Player.Black),
                new Move("F7", "F6", Player.Black),
                new Move("F7", "F5", Player.Black),
                new Move("G7", "G6", Player.Black),
                new Move("G7", "G5", Player.Black),
                new Move("H7", "H6", Player.Black),
                new Move("H7", "H5", Player.Black),
                new Move("B8", "A6", Player.Black),
                new Move("B8", "C6", Player.Black),
                new Move("G8", "F6", Player.Black),
                new Move("G8", "H6", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);

            foreach(var move in expected)
                Assert.True(actual.Contains(move));
        }

        [Test]
        public static void TestGetValidMovesWhiteKing()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, kb, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kw, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var actual = cb.GetValidMoves(new Square(File.D, 4));

            var expected = new List<Move>
            {
                new Move("D4", "C3", Player.White),
                new Move("D4", "C4", Player.White),
                new Move("D4", "C5", Player.White),
                new Move("D4", "D3", Player.White),
                new Move("D4", "D5", Player.White),
                new Move("D4", "E3", Player.White),
                new Move("D4", "E4", Player.White),
                new Move("D4", "E5", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);

            foreach(var move in expected)
                Assert.True(actual.Contains(move));
        }

        [Test]
        public static void TestGetValidMovesWhiteKnight()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, nw, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "C2", Player.White),
                new Move("D4", "B3", Player.White),
                new Move("D4", "C6", Player.White),
                new Move("D4", "B5", Player.White),
                new Move("D4", "E2", Player.White),
                new Move("D4", "E6", Player.White),
                new Move("D4", "F3", Player.White),
                new Move("D4", "F5", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);

            foreach(var move in expected)
                Assert.True(actual.Contains(move));
        }

        [Test]
        public static void TestGetValidMovesWhiteBishop()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, bw, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "A1", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "H8", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "A1", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);

            foreach(var move in expected)
                Assert.True(actual.Contains(move));
        }

        [Test]
        public static void TestGetValidMovesWhiteRook()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kw, __, kb, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, rw, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "D1", Player.White),
                new Move("D4", "D2", Player.White),
                new Move("D4", "D3", Player.White),
                new Move("D4", "D5", Player.White),
                new Move("D4", "D6", Player.White),
                new Move("D4", "D7", Player.White),
                new Move("D4", "D8", Player.White),
                new Move("D4", "A4", Player.White),
                new Move("D4", "B4", Player.White),
                new Move("D4", "C4", Player.White),
                new Move("D4", "E4", Player.White),
                new Move("D4", "F4", Player.White),
                new Move("D4", "G4", Player.White),
                new Move("D4", "H4", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
                Assert.True(actual.Contains(move));
        }

        [Test]
        public static void TestGetValidMovesWhiteQueen()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kw, __, kb, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, qw, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "D1", Player.White),
                new Move("D4", "D2", Player.White),
                new Move("D4", "D3", Player.White),
                new Move("D4", "D5", Player.White),
                new Move("D4", "D6", Player.White),
                new Move("D4", "D7", Player.White),
                new Move("D4", "D8", Player.White),
                new Move("D4", "A4", Player.White),
                new Move("D4", "B4", Player.White),
                new Move("D4", "C4", Player.White),
                new Move("D4", "E4", Player.White),
                new Move("D4", "F4", Player.White),
                new Move("D4", "G4", Player.White),
                new Move("D4", "H4", Player.White),
                new Move("D4", "A1", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "H8", Player.White),
                new Move("D4", "G7", Player.White),
                new Move("D4", "F6", Player.White),
                new Move("D4", "E5", Player.White),
                new Move("D4", "C3", Player.White),
                new Move("D4", "B2", Player.White),
                new Move("D4", "A1", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesWhitePawn()
        {
            var board = new Piece[8][]
                {
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kb, __, __, __, __ },
                new[] { pb, __, pb, __, __, __, __, __ },
                new[] { __, pw, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            var actual = cb.GetValidMoves(new Square(File.B, 2));
            var expected = new List<Move>
            {
                new Move("B2", "B3", Player.White),
                new Move("B2", "B4", Player.White),
                new Move("B2", "A3", Player.White),
                new Move("B2", "C3", Player.White)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesWhitePawnPromotion()
        {
            var board = new Piece[8][]
                {
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, pw },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.H, 7));
            var expected = new List<Move>
            {
                new Move("H7", "H8", Player.White, new Queen(Player.White)),
                new Move("H7", "H8", Player.White, new Rook(Player.White)),
                new Move("H7", "H8", Player.White, new Bishop(Player.White)),
                new Move("H7", "H8", Player.White, new Knight(Player.White))
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesBlackKing()
        {
            var board = new Piece[8][]
                {
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "C3", Player.Black),
                new Move("D4", "C4", Player.Black),
                new Move("D4", "C5", Player.Black),
                new Move("D4", "D3", Player.Black),
                new Move("D4", "D5", Player.Black),
                new Move("D4", "E3", Player.Black),
                new Move("D4", "E4", Player.Black),
                new Move("D4", "E5", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesBlackKnight()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, nb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "C2", Player.Black),
                new Move("D4", "B3", Player.Black),
                new Move("D4", "C6", Player.Black),
                new Move("D4", "B5", Player.Black),
                new Move("D4", "E2", Player.Black),
                new Move("D4", "E6", Player.Black),
                new Move("D4", "F3", Player.Black),
                new Move("D4", "F5", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesBlackBishop()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, kw, __, kb, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, bb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "A1", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "H8", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "A1", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesBlackRook()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kw, __, kb, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, rb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "D1", Player.Black),
                new Move("D4", "D2", Player.Black),
                new Move("D4", "D3", Player.Black),
                new Move("D4", "D5", Player.Black),
                new Move("D4", "D6", Player.Black),
                new Move("D4", "D7", Player.Black),
                new Move("D4", "D8", Player.Black),
                new Move("D4", "A4", Player.Black),
                new Move("D4", "B4", Player.Black),
                new Move("D4", "C4", Player.Black),
                new Move("D4", "E4", Player.Black),
                new Move("D4", "F4", Player.Black),
                new Move("D4", "G4", Player.Black),
                new Move("D4", "H4", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesBlackQueen()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kw, __, kb, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, qb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.D, 4));
            var expected = new List<Move>
            {
                new Move("D4", "D1", Player.Black),
                new Move("D4", "D2", Player.Black),
                new Move("D4", "D3", Player.Black),
                new Move("D4", "D5", Player.Black),
                new Move("D4", "D6", Player.Black),
                new Move("D4", "D7", Player.Black),
                new Move("D4", "D8", Player.Black),
                new Move("D4", "A4", Player.Black),
                new Move("D4", "B4", Player.Black),
                new Move("D4", "C4", Player.Black),
                new Move("D4", "E4", Player.Black),
                new Move("D4", "F4", Player.Black),
                new Move("D4", "G4", Player.Black),
                new Move("D4", "H4", Player.Black),
                new Move("D4", "A1", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "H8", Player.Black),
                new Move("D4", "G7", Player.Black),
                new Move("D4", "F6", Player.Black),
                new Move("D4", "E5", Player.Black),
                new Move("D4", "C3", Player.Black),
                new Move("D4", "B2", Player.Black),
                new Move("D4", "A1", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesBlackPawn()
        {
            var board = new Piece[8][]
                {
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kb, __, __, __, __ },
                new[] { __, pb, __, __, __, __, __, __ },
                new[] { pw, __, pw, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.B, 3));
            var expected = new List<Move>
            {
                new Move("B3", "B2", Player.Black),
                new Move("B3", "A2", Player.Black),
                new Move("B3", "C2", Player.Black)
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestGetValidMovesBlackPawnPromotion()
        {
            var board = new Piece[8][]
                {
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, kb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, pb },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);
            ReadOnlyCollection<Move> actual = cb.GetValidMoves(new Square(File.H, 2));
            var expected = new List<Move>
            {
                new Move("H2", "H1", Player.Black, new Queen(Player.Black)),
                new Move("H2", "H1", Player.Black, new Rook(Player.Black)),
                new Move("H2", "H1", Player.Black, new Knight(Player.Black)),
                new Move("H2", "H1", Player.Black, new Bishop(Player.Black))
            };

            Assert.AreEqual(expected.Count, actual.Count);
            foreach(var move in expected)
            {
                Assert.True(actual.Contains(move));
            }
        }

        [Test]
        public static void TestIsWhiteInCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kw, __, __, __, __, __, __, qb },
                new[] { pw, __, __, pb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kb, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);

            Assert.AreEqual(GameEvent.Check, cb.Status.Event);
            Assert.AreEqual(Player.Black, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("White is in check", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestIsWhiteInCheck_OnRank1()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, pb, __ },
                new[] { kb, __, __, __, __, __, __, kw }
                };
            var cb = new ChessGame(board, Player.White);

            Assert.AreEqual(GameEvent.Check, cb.Status.Event);
            Assert.AreEqual(Player.Black, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("White is in check", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestIsWhiteNotInCheck()
        {
            var board = new Piece[8][]
                {
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, qb },
                new[] { pw, __, __, pb, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
        }

        [Test]
        public static void TestIsWhiteNotInCheck_PawnsCanOnlyCheckDiagonally()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, __ },
                new[] { __, __, __, __, pb, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kb, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
        }

        [Test]
        public static void TestIsBlackInCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, nw, __, __, __, __ },
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.Check, cb.Status.Event);
            Assert.AreEqual(Player.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Black is in check", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestIsBlackInCheck_OnRank8()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, pw, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kw, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.Check, cb.Status.Event);
            Assert.AreEqual(Player.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Black is in check", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestIsBlackNotInCheck()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, nb, __, __, __, __ },
                new[] { __, kb, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kw, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, pb },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
        }

        [Test]
        public static void TestIsBlackNotInCheck_PawnsCanOnlyCheckDiagonally()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kb, __, __, __ },
                new[] { __, __, __, __, pw, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { kw, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
        }

        [Test]
        public static void TestBlackCheckmated()
        {
            var cb = new ChessGame();
            cb.ApplyMove(new Move("E2", "E4", Player.White), true);
            cb.ApplyMove(new Move("E7", "E5", Player.Black), true);
            cb.ApplyMove(new Move("F1", "C4", Player.White), true);
            cb.ApplyMove(new Move("D7", "D6", Player.Black), true);
            cb.ApplyMove(new Move("D1", "F3", Player.White), true);
            cb.ApplyMove(new Move("H7", "H6", Player.Black), true);
            Assert.AreNotEqual(cb.ApplyMove(new Move("F3", "F7", Player.White), false), MoveType.Invalid);

            Assert.AreEqual(GameEvent.Checkmate, cb.Status.Event);
            Assert.AreEqual(Player.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Black is checkmated", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestBlackStalemated()
        {
            var board = new Piece[8][]
                {
                new[] { kb, __, kw, __, __, __, __, __ },
                new[] { __, __, qw, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);

            Assert.AreEqual(GameEvent.Stalemate, cb.Status.Event);
            Assert.AreEqual(Player.White, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("Stalemate", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestBlackNotStalemated()
        {
            var board = new Piece[8][]
                {
                new[] { kb, __, kw, __, __, __, __, __ },
                new[] { __, __, qw, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.White);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
            Assert.AreEqual(Player.None, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("No special event", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestBlackNotStalematedAfterApplyMove()
        {
            var board = new Piece[8][]
                {
                new[] { __, __, kw, __, __, __, __, __ },
                new[] { kb, __, qw, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ }
                };
            var cb = new ChessGame(board, Player.Black);

            Assert.AreNotEqual(cb.ApplyMove(new Move("A7", "A8", Player.Black), false), MoveType.Invalid);

            Assert.AreEqual(GameEvent.None, cb.Status.Event);
            Assert.AreEqual(Player.None, cb.Status.PlayerWhoCausedEvent);
            Assert.AreEqual("No special event", cb.Status.EventExplanation);
        }

        [Test]
        public static void TestApplyMove_ReturnedMoveType()
        {
            var game = new ChessGame();
            MoveType type = game.ApplyMove(new Move("E2", "E4", Player.White), true);
            Assert.AreEqual(type, MoveType.Move);
            type = game.ApplyMove(new Move("D7", "D5", Player.Black), true);
            Assert.AreEqual(type, MoveType.Move);
            type = game.ApplyMove(new Move("E4", "D5", Player.White), true);
            Assert.AreEqual(type, MoveType.Move | MoveType.Capture);
            type = game.ApplyMove(new Move("A5", "A4", Player.White), false);
            Assert.AreEqual(type, MoveType.Invalid);

            var board = new Piece[8][]
                {
                new[] { rb, __, __, kb, __, __, __, __ },
                new[] { __, pw, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, __, __, __, __ },
                new[] { pb, __, __, __, __, __, __, __ },
                new[] { __, __, __, __, kw, __, __, rw }
                };
            game = new ChessGame(board, Player.White);
            type = game.ApplyMove(new Move("E1", "G1", Player.White), true);
            Assert.AreEqual(type, MoveType.Move | MoveType.Castling);
            type = game.ApplyMove(new Move("A2", "A1", Player.Black), true);
            Assert.AreEqual(type, MoveType.Move | MoveType.Promotion);
            type = game.ApplyMove(new Move("B7", "A8", Player.White), true);
            Assert.AreEqual(type, MoveType.Move | MoveType.Capture | MoveType.Promotion);
        }
    }
}