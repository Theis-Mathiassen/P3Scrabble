namespace Scrabble.Client
{
    public class Bag
    {
        public Bag()
        {
            
        }

        public List<CharTile> TilesInHand { get; }


        internal CharTile pickRandomTile()
        {
            throw new NotImplementedException();
        }
    }
}