﻿namespace ChessDotNet
{
    public class Move
    {
        public Square OriginalPosition { get; private set; }

        public Square NewPosition { get; private set; }

        public Player Player { get; private set; }

        public Piece Promotion { get; private set; }

        public Move(Square originalPosition, Square newPosition, Player player)
            : this(originalPosition, newPosition, player, null)
        { }

        public Move(string originalPosition, string newPosition, Player player)
            : this(originalPosition, newPosition, player, null)
        { }

        public Move(Square originalPosition, Square newPosition, Player player, Piece promotion)
        {
            OriginalPosition = originalPosition;
            NewPosition = newPosition;
            Player = player;
            Promotion = promotion;
        }

        public Move(string originalPosition, string newPosition, Player player, Piece promotion)
        {
            OriginalPosition = new Square(originalPosition);
            NewPosition = new Square(newPosition);
            Player = player;
            Promotion = promotion;
        }

        public override bool Equals(object obj)
        {
            if(obj == null || GetType() != obj.GetType())
                return false;
            if(ReferenceEquals(this, obj))
                return true;
            Move move1 = this;
            Move move2 = (Move)obj;
            return move1.OriginalPosition.Equals(move2.OriginalPosition)
                && move1.NewPosition.Equals(move2.NewPosition)
                && move1.Player == move2.Player
                && move1.Promotion == move2.Promotion;
        }

        public override int GetHashCode() => new { OriginalPosition, NewPosition, Player, Promotion }.GetHashCode();

        public static bool operator ==(Move move1, Move move2)
        {
            if(ReferenceEquals(move1, move2))
                return true;
            if((object)move1 == null || (object)move2 == null)
                return false;
            return move1.Equals(move2);
        }

        public static bool operator !=(Move move1, Move move2)
        {
            return !(move1 == move2);
        }

        public override string ToString() => OriginalPosition + "-" + NewPosition;
    }
}