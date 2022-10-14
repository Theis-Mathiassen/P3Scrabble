namespace Scrabble.Client
{
    public class Game
    {
        public Bag GameBag { get; set; }
        public int MaxTilesInHand { get; set; }
        private List<Player> players = new();

        public Game()
        {
            GameBag = new Bag();
            players.Add(new Player(0, 0, MaxTilesInHand, GameBag));
            players.Add(new Player(1, 0, MaxTilesInHand, GameBag));
        }


    }
}
