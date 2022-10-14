namespace Scrabble.Client
{
    public class CharTile
    {
        public char Character { get; }
        public int PointValue { get; }

        public CharTile(char character, int pointValue)
        {
            Character = character;
            PointValue = pointValue;
        }

    }
}