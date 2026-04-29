using _35._0_BattleshipLibrary;
using _35._0_BattleshipLibrary.Models;
using _35._1_BattleShipGame;

//add playerinfomodel (library) reference 


PlayerInfoModel players = new();


//GameUI.EntireLogic();


GameUI.WelcomeMsg();

PlayerInfoModel activePlayer = GameUI.PlayerInfo("PLAYER 1");

PlayerInfoModel opponent = GameUI.PlayerInfo("PLAYER 2");

PlayerInfoModel winner = null; //either player will be placed at winner 

//do loop to determine the winner
do
{
    //diplay grid
    GameUI.DisplayGrid(activePlayer);

    //ask for shot from active player - check opponent - check if shot is valid and record it if valid , if not repeat
    GameUI.RecordShot(activePlayer, opponent);

    //check winner , if opponents all ships are hit/sunk , active player wins - continue the game till no ships left.

    bool continueGame = GameLogic.ContinueGame(opponent); // checks if opponents ships are finished
                                                          //if ships are remaining  , swap players and make opp. active to take shot and make active to opponent.
    if (continueGame)
    {

        //(use same data type)- PlayerInfoModel tempVariable = opponent;   ---this is coverting
        //opponent = activePlayer;                    ---opp. into active player , this way was better before C# 7.O
        //activePlayer = tempVariable;                 ---now use tuple

        (activePlayer, opponent) = (opponent, activePlayer); //it swaps the players

    }
    else
    {
        winner = activePlayer;
    }

}
while (winner == null); //loop runs untill winner is decided. 

GameUI.DisplayWinner(winner);


