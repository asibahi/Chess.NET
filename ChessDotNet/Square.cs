using System;
using System.Globalization;

namespace ChessDotNet
{
    public enum File
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6,
        H = 7,
        None = -1
    }

    public class Square
    {
        File _file;
        public File File => _file;

        int _rank;
        public int Rank => _rank;

        public Square(File file, int rank)
        {
            _file = file;
            _rank = rank;
        }

        public Square(string position)
        {
            if(position == null)
                throw new ArgumentNullException(nameof(position));

            if(position.Length != 2)
                throw new ArgumentException("Length of `pos` is not 2.");

            position = position.ToUpperInvariant();

            switch(position[0])
            {
                case 'A':
                    _file = File.A;
                    break;

                case 'B':
                    _file = File.B;
                    break;

                case 'C':
                    _file = File.C;
                    break;

                case 'D':
                    _file = File.D;
                    break;

                case 'E':
                    _file = File.E;
                    break;

                case 'F':
                    _file = File.F;
                    break;

                case 'G':
                    _file = File.G;
                    break;

                case 'H':
                    _file = File.H;
                    break;

                default:
                    throw new ArgumentException("First char of `pos` not in range A-F.");
            }

            if(int.TryParse(position[1].ToString(), out _rank))
            {
                if(_rank < 1 || _rank > 8)
                    throw new ArgumentException("Second char of `pos` not in range 1-8.");
            }
            else
            {
                throw new ArgumentException("Second char of `pos` not in range 1-8.");
            }
        }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(this, obj))
                return true;

            if(obj == null || GetType() != obj.GetType())
                return false;

            var pos2 = (Square)obj;

            return File == pos2.File && Rank == pos2.Rank;
        }

        public override int GetHashCode() => new { File, Rank }.GetHashCode();

        public static bool operator ==(Square position1, Square position2)
        {
            if(ReferenceEquals(position1, position2))
                return true;

            if((object)position1 == null || (object)position2 == null)
                return false;

            return position1.Equals(position2);
        }

        public static bool operator !=(Square position1, Square position2)
        {
            return !(position1 == position2);
        }

        public override string ToString() => File + Rank.ToString(CultureInfo.InvariantCulture);
    }
}