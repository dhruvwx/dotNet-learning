using _40MiniProj_CardGame;
using static _40MiniProj_CardGame.PockerGame;


PockerGame poker = new PockerGame();
var hand = poker.DistributedCard();

foreach  (var card in hand)
{
    Console.WriteLine($"{card.Rank} of {card.Suit.ToString()}");
}

Console.WriteLine();


BlackJack blackJack = new BlackJack();
var set = blackJack.DistributedCard();

foreach (var card in set)
{
    Console.WriteLine($"{card.Rank} of {card.Suit.ToString()}");
}