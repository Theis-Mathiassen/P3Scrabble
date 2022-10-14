namespace Scrabble.Client
{
    public class Hand
    {
        public List<CharTile> TilesInHand { get; }
        public int MaxTilesInHand { get; private set; }

        public Hand(int maxTilesInHand)
        {
            TilesInHand = new();
            MaxTilesInHand = maxTilesInHand;
        }

        public void FillHand (Bag bag)
        {
            while (TilesInHand.Count < MaxTilesInHand)
            {
                try
                {
                    GrabTileFromBag(bag);
                }
                catch
                {
                    //break;
                    //exception bag empty
                    return;
                }
            }
        }
        public void GrabTileFromBag (Bag bag)
        {
            TilesInHand.Add(bag.pickRandomTile());
        }
        public void PlaceTile ()
        {
            
        }
    }
}