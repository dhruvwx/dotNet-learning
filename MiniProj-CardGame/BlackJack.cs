namespace _40MiniProj_CardGame
{
    public class BlackJack : DeckModel
    {

        public BlackJack()
        {
            CreateDeck();
            ShuffleDeck();
        }
        public override List<PlayingCards> DistributedCard()
        {
            List<PlayingCards> output = new List<PlayingCards>();
            for (int i = 0; i < 2; i++)
            {
                output.Add(RequestCard());
            }
            return output;
        }

        public PlayingCards GetCard()
        {
            return RequestCard();
        }
    }
}






