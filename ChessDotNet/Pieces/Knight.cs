using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ChessDotNet.Pieces
{
    public class Knight : Piece
    {
        public override Player Owner { get; set; }

        public Knight(Player owner) { Owner = owner; }

        public override char GetFenCharacter() => Owner == Player.White ? 'N' : 'n';

        public override bool IsValidMove(Move move, ChessGame game)
        {
            ChessUtilities.ThrowIfNull(move, nameof(move));
            ChessUtilities.ThrowIfNull(game, nameof(game));

            var origin = move.OriginalPosition;
            var destination = move.NewPosition;

            var posDelta = new PositionDistance(origin, destination);

            if((posDelta.DistanceX != 2 || posDelta.DistanceY != 1) && (posDelta.DistanceX != 1 || posDelta.DistanceY != 2))
                return false;

            return true;
        }

        public override ReadOnlyCollection<Move> GetValidMoves(Position from, bool returnIfAny, ChessGame game)
        {
            var validMoves = new List<Move>();
            var piece = game.GetPieceAt(from);
            var l0 = game.BoardHeight;
            var l1 = game.BoardWidth;
            int[][] directions = { new int[] { 2, 1 },
                                   new int[] { -2, -1 },
                                   new int[] { 1, 2 },
                                   new int[] { -1, -2 },
                                   new int[] { 1, -2 },
                                   new int[] { -1, 2 },
                                   new int[] { 2, -1 },
                                   new int[] { -2, 1 }
                                 };
            foreach(int[] dir in directions)
            {
                if((int)from.File + dir[0] < 0 || (int)from.File + dir[0] >= l1
                    || from.Rank + dir[1] < 1 || from.Rank + dir[1] > l0)
                    continue;

                var move = new Move(from, new Position(from.File + dir[0], from.Rank + dir[1]), piece.Owner);
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
