namespace Scrabble.Client
{
    public class Player
    {
        public Player(int id, int score, int maxTilesInHand, Bag bag)
        {
            Id = id;
            Score = score;
            Hand = new(maxTilesInHand);

            Hand.FillHand(bag);
        } 

        public int Id { get; set; }
        public int Score { get; private set; }
        public Hand Hand { get; set; }

        public void StartTurn()
        {

        }

        public void AttemptEndTurn(string word)
        {
            TurnEvent(word); // returner true/false + score

            try
            {
                private int tScore = Turn.PlayTiles(Hand.PlacedTiles);
                score += tScore;
                yourTurn = false;
            }
            catch (Exception)
            {
                // throw() <- til game.
                // HOV DET KUNNE DU IKKE
            }
        }
        public string PlaceTiles()
        {
            private string word = "";
            return word;
        }
    }
}
