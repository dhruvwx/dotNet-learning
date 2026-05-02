namespace _40MiniProj_CardGame
{
    public class PockerGame : DeckModel
    {
        public PockerGame()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCards> DistributedCard()
        {
            List<PlayingCards> output = new List<PlayingCards>();
            for (int i = 0; i <5; i++)
            {
                output.Add(RequestCard());
            }
            return output;
        }

        public List<PlayingCards> ExchangeCards(List<PlayingCards> cardsToDiscard) //it will take set of cards that are being used in the game
        {
            List<PlayingCards> output = new();

            foreach(var card in cardsToDiscard)
            {
                output.Add(RequestCard());
                discardPile.Add(card); 
            }
            return output;

        }

    }
}






