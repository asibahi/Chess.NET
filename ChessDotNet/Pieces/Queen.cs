using System.Collections.ObjectModel;
using System.Linq;

namespace ChessDotNet.Pieces
{
    public class Queen : Piece
    {
        public override Player Owner { get; set; }

        public Queen(Player owner)
        {
            Owner = owner;
        }

        public override char GetFenCharacter() => Owner == Player.White ? 'Q' : 'q';

        public override bool IsValidMove(Move move, ChessGame game)
        {
            ChessUtilities.ThrowIfNull(move, nameof(move));
            ChessUtilities.ThrowIfNull(game, nameof(game));

            return new Bishop(Owner).IsValidMove(move, game) || new Rook(Owner).IsValidMove(move, game); // that's a weird way of doing things
        }

        public override ReadOnlyCollection<Move> GetValidMoves(Square from, bool returnIfAny, ChessGame game)
        {
            ChessUtilities.ThrowIfNull(from, nameof(from));

            var horizontalVerticalMoves = new Rook(Owner).GetValidMoves(from, returnIfAny, game);

            if(returnIfAny && horizontalVerticalMoves.Count > 0)
                return horizontalVerticalMoves;

            var diagonalMoves = new Bishop(Owner).GetValidMoves(from, returnIfAny, game);

            return new ReadOnlyCollection<Move>(horizontalVerticalMoves.Concat(diagonalMoves).ToList());
        }
    }
}