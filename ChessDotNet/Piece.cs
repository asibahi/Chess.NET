using System.Collections.ObjectModel;

namespace ChessDotNet
{
    public abstract class Piece
    {
        public abstract Player Owner { get; set; }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(this, obj))
                return true;

            if(obj == null || GetType() != obj.GetType())
                return false;

            return Owner == ((Piece)obj).Owner;
        }

        public override int GetHashCode() => new { Piece = GetFenCharacter(), Owner }.GetHashCode(); // I am not sure if this is a good idea

        public static bool operator ==(Piece piece1, Piece piece2)
        {
            if(ReferenceEquals(piece1, piece2))
                return true;

            if((object)piece1 == null || (object)piece2 == null)
                return false;

            return piece1.Equals(piece2);
        }

        public static bool operator !=(Piece piece1, Piece piece2)
        {
            return !(piece1 == piece2);
        }

        public abstract char GetFenCharacter();

        public abstract bool IsValidMove(Move move, ChessGame game);

        public abstract ReadOnlyCollection<Move> GetValidMoves(Square from, bool returnIfAny, ChessGame game);
    }
}