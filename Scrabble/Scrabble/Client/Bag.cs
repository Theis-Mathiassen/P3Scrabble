namespace Scrabble.Client
{
    public class Bag
    {
        public Bag()
        {
            
        }

        public List<CharTile> TilesInHand { get; }
        public List<CharTile> TilesInBag { get; }

        private MakeCharTiles(char character, int point, int numberOfTiles)
        {
            for (int i = 0; i < numberOfTiles; i++)
			{
                TilesInBag.Add(new CharTile(character, point));
			}
        }

        internal CharTile pickRandomTile()
        {
            throw new NotImplementedException();
        }
    }
}