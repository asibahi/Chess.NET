using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChessDotNet.Pieces
{
    public class King : Piece
    {
        public override Player Owner { get; set; }

        public bool HasCastlingAbility { get; set; }

        public King(Player owner) : this(owner, true)
        {
        }

        public King(Player owner, bool hasCastlingAbility)
        {
            Owner = owner;
            HasCastlingAbility = hasCastlingAbility;
        }

        public override char GetFenCharacter() => Owner == Player.White ? 'K' : 'k';

        public override bool IsValidMove(Move move, ChessGame game)
        {
            ChessUtilities.ThrowIfNull(move, nameof(move));
            var origin = move.OriginalPosition;
            var destination = move.NewPosition;
            var distance = new SquareDistance(origin, destination);

            if((distance.DistanceX != 1 || distance.DistanceY != 1)
                        && (distance.DistanceX != 0 || distance.DistanceY != 1)
                        && (distance.DistanceX != 1 || distance.DistanceY != 0)
                        && (distance.DistanceX != 2 || distance.DistanceY != 0))
                return false;

            if(distance.DistanceX != 2)
                return true;

            return CanCastle(origin, destination, game);
        }

        protected virtual bool CanCastle(Square origin, Square destination, ChessGame game)
        {
            if(!HasCastlingAbility)
                return false;

            if(Owner == Player.White)
            {
                if(origin.File != File.E || origin.Rank != 1)
                    return false;
                if(game.WhiteKingMoved || (game.Status.Event == GameEvent.Check && game.Status.PlayerWhoCausedEvent == Player.Black))
                    return false;
                if(destination.File == File.C)
                {
                    if(game.WhiteRookAMoved || game.GetPieceAt(File.D, 1) != null
                        || game.GetPieceAt(File.C, 1) != null
                        || game.GetPieceAt(File.B, 1) != null
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 1), new Square(File.D, 1), Player.White), Player.White)
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 1), new Square(File.C, 1), Player.White), Player.White))
                        return false;
                }
                else
                {
                    if(game.WhiteRookHMoved || game.GetPieceAt(File.F, 1) != null
                        || game.GetPieceAt(File.G, 1) != null
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 1), new Square(File.F, 1), Player.White), Player.White)
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 1), new Square(File.G, 1), Player.White), Player.White))
                        return false;
                }
            }
            else
            {
                if(origin.File != File.E || origin.Rank != 8)
                    return false;
                if(game.BlackKingMoved || (game.Status.Event == GameEvent.Check && game.Status.PlayerWhoCausedEvent == Player.White))
                    return false;
                if(destination.File == File.C)
                {
                    if(game.BlackRookAMoved || game.GetPieceAt(File.D, 8) != null
                        || game.GetPieceAt(File.C, 8) != null
                        || game.GetPieceAt(File.B, 8) != null
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 8), new Square(File.D, 8), Player.Black), Player.Black)
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 8), new Square(File.C, 8), Player.Black), Player.Black))
                        return false;
                }
                else
                {
                    if(game.BlackRookHMoved || game.GetPieceAt(File.F, 8) != null
                        || game.GetPieceAt(File.G, 8) != null
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 8), new Square(File.F, 8), Player.Black), Player.Black)
                        || game.WouldBeInCheckAfter(new Move(new Square(File.E, 8), new Square(File.G, 8), Player.Black), Player.Black))
                        return false;
                }
            }
            return true;
        }

        public override ReadOnlyCollection<Move> GetValidMoves(Square from, bool returnIfAny, ChessGame game)
        {
            ChessUtilities.ThrowIfNull(from, nameof(from));
            var validMoves = new List<Move>();
            var piece = game.GetPieceAt(from);

            int[][] directions = { new int[] { 0, 1 },
                                   new int[] { 1, 0 },
                                   new int[] { 0, -1 },
                                   new int[] { -1, 0 },
                                   new int[] { 1, 1 },
                                   new int[] { 1, -1 },
                                   new int[] { -1, 1 },
                                   new int[] { -1, -1 },
                                   new int[] { 2, 0 },
                                   new int[] { -2, 0 }
                                  };

            foreach(int[] dir in directions)
            {
                if((int)from.File + dir[0] < 0 || (int)from.File + dir[0] >= game.BoardWidth || from.Rank + dir[1] < 1 || from.Rank + dir[1] > game.BoardHeight)
                    continue;
                var move = new Move(from, new Square(from.File + dir[0], from.Rank + dir[1]), piece.Owner);
                if(game.IsValidMove(move))
                {
                    validMoves.Add(move);
                    if(returnIfAny)
                        return new ReadOnlyCollection<Move>(validMoves);
                }
            }
            return new ReadOnlyCollection<Move>(validMoves);
        }
    }
}