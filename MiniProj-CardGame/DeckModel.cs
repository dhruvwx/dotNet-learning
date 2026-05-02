using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _40MiniProj_CardGame
{
    public abstract class DeckModel
    {
        List<PlayingCards> fullDeck = new();
        List<PlayingCards> drawCards = new();
        protected List<PlayingCards> discardPile = new();


        protected void CreateDeck()
        {
            for (int suit = 0; suit < 4; suit++)
            {
                for (int rank = 0; rank < 13; rank++)
                {
                    fullDeck.Add(new PlayingCards { Suit = (CardSuit)suit, Rank = (CardRank)rank }); //EXPLICIT COVERT INT TO ENUM (DataType)value
                }
            }

        }

        public void ShuffleDeck()
        {
            var rand = new Random();
            drawCards = fullDeck.OrderBy(x => rand.Next()).ToList();
        }

        public abstract List<PlayingCards> DistributedCard(); //itll be diff. for diff games like Poker - 5 ,BlackJack - 2 etc so we'll write accordingly , and its of type list coz we need the entire set or hand not just one card.
        public PlayingCards RequestCard()
        {
            PlayingCards output = drawCards.Take(1).First(); //the Take() method returns a collection so use first() to get its first item.

            drawCards.Remove(output); //Removed so that same card cant be taken out again.

            return output;

        }
    }
}






