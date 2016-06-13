using System;

namespace ChessDotNet
{
    public struct SquareDistance
    {
        int _distanceX;
        public int DistanceX => _distanceX;

        int _distanceY;
        public int DistanceY => _distanceY;

        public SquareDistance(Square position1, Square position2)
        {
            if(position1 == null)
                throw new ArgumentNullException(nameof(position1));
            if(position2 == null)
                throw new ArgumentNullException(nameof(position2));

            _distanceX = Math.Abs((int)position1.File - (int)position2.File);
            _distanceY = Math.Abs(position1.Rank - position2.Rank);
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
                return false;

            var distance2 = (SquareDistance)obj;
            return DistanceX == distance2.DistanceX && DistanceY == distance2.DistanceY;
        }

        public override int GetHashCode() => new { DistanceX, DistanceY }.GetHashCode();

        public static bool operator ==(SquareDistance distance1, SquareDistance distance2)
        {
            return distance1.Equals(distance2);
        }

        public static bool operator !=(SquareDistance distance1, SquareDistance distance2)
        {
            return !distance1.Equals(distance2);
        }
    }
}