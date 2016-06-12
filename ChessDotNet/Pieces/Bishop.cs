using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChessDotNet.Pieces
{
    public class Bishop : Piece
    {
        public override Player Owner { get; set; }

        public Bishop(Player owner) { Owner = owner; }

        public override char GetFenCharacter() => Owner == Player.White ? 'B' : 'b';
        public override bool IsValidMove(Move move, ChessGame game)
        {
            ChessUtilities.ThrowIfNull(move, nameof(move));
            ChessUtilities.ThrowIfNull(game, nameof(game));

            var origin = move.OriginalPosition;
            var destination = move.NewPosition;

            var posDelta = new PositionDistance(origin, destination);

            if(posDelta.DistanceX != posDelta.DistanceY)
                return false;

            var increasingRank = destination.Rank > origin.Rank;
            var increasingFile = (int)destination.File > (int)origin.File;

            var f = (int)origin.File + (increasingFile ? 1 : -1);
            var r = origin.Rank + (increasingRank ? 1 : -1);

            while(increasingFile ? f < (int)destination.File : f > (int)destination.File)
            {
                if(game.GetPieceAt((File)f, r) != null)
                    return false;
                f += increasingFile ? 1 : -1;
                r += increasingRank ? 1 : -1;
            }

            return true;
        }

        public override ReadOnlyCollection<Move> GetValidMoves(Position from, bool returnIfAny, ChessGame game)
        {
            var validMoves = new List<Move>();
            var piece = game.GetPieceAt(from);

            for(int i = -7; i < 8; i++)
            {
                if(i == 0)
                    continue;

                if(from.Rank + i > 0 && from.Rank + i <= game.BoardHeight && (int)from.File + i > -1 && (int)from.File + i < game.BoardWidth)
                {
                    var move = new Move(from, new Position(from.File + i, from.Rank + i), piece.Owner);
                    if(game.IsValidMove(move))
                    {
                        validMoves.Add(move);
                        if(returnIfAny)
                            return new ReadOnlyCollection<Move>(validMoves);
                    }
                }
                if(from.Rank - i > 0 && from.Rank - i <= game.BoardHeight && (int)from.File + i > -1 && (int)from.File + i < game.BoardWidth)
                {
                    var move = new Move(from, new Position(from.File + i, from.Rank - i), piece.Owner);
                    if(game.IsValidMove(move))
                    {
                        validMoves.Add(move);
                        if(returnIfAny)
                            return new ReadOnlyCollection<Move>(validMoves);
                    }
                }
            }
            return new ReadOnlyCollection<Move>(validMoves);
        }
    }
}
