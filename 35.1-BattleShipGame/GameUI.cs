using _35._0_BattleshipLibrary;
using _35._0_BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._1_BattleShipGame
{
    public class GameUI
    {

        public static void RecordShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isShotValid;
            string row; int column;
            do
            {
                string shotTaken = AskForShot();

                //divide shotTaken into rows and columns to know where is shot taken , two values use tuple
                (row, column) = GameLogic.SplitShotIntoRowsAndColumns(shotTaken);

                isShotValid = GameLogic.IsShotValid(activePlayer, row, column); //activePlayer is as parameter to know where he has already shot.
                if (!isShotValid)
                {
                    Console.WriteLine("Please try again , this shot does not exist! ");
                }
            } while (!isShotValid);

            //if valid now we will se if its hit or miss.

            bool isHit = GameLogic.IsHit(opponent, row, column);

            GameLogic.StoreResult(activePlayer, row, column, isHit);


        }

        private static string AskForShot()
        {
            Console.Write("Where do u want to shoot: ");
            string output = Console.ReadLine();
            return output;
        }

        public static void DisplayGrid(PlayerInfoModel activePlayer)
        {
            string currentGrid = activePlayer.AllLocations[0].SpotLetter;

            foreach (var gridSpot in activePlayer.AllLocations)
            {
                if (currentGrid != gridSpot.SpotLetter)
                {
                    Console.WriteLine();//move to next line when the spotLetter changes for grid view
                    currentGrid = gridSpot.SpotLetter;
                }
                if (gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($"{ gridSpot.SpotLetter }{ gridSpot.SpotNumber } ");
                }
                else if (gridSpot.Status == GridSpotStatus.Miss)
                {
                    Console.Write(" O ");
                }
                else if (gridSpot.Status == GridSpotStatus.Hit)
                {
                    Console.Write(" X ");
                }
                else
                {
                    Console.Write(" ? ");
                }
            }
        }

        public static PlayerInfoModel PlayerInfo(string players)
        {
            PlayerInfoModel player = new();

            Console.WriteLine($"CREATING {players}");
            //Player name
            player.Name = EnterName();

            //add all locations
            GameLogic.InitializingSpots(player);

            //add 5 ships
            PlaceShips(player);

            Console.Clear(); 

            return player;

           


        }

        public static void WelcomeMsg()
        {
            Console.WriteLine("~~~~~WELCOME TO THE BATTLESHIP LITE GAME~~~~~");
            Console.WriteLine("made by : DHRUV SHARMA");
            Console.WriteLine();
        }

        public static string EnterName()
        {
            Console.Write("Enter your name: ");
            string output = Console.ReadLine();
            return output;
        }

        public static void PlaceShips(PlayerInfoModel shipLoc)
        {
            do
            {
                Console.Write($"Where do you want to place your ship number {shipLoc.ShipLocations.Count + 1}:  ");
                string location = Console.ReadLine();

                //if wrong loc 
                bool valid = GameLogic.ShipPlacement(shipLoc, location);
                if (valid == false)
                {
                    Console.WriteLine("ENTER A CORRECT LOCATION TO PLACE THE SHIP");
                }



            } while (shipLoc.ShipLocations.Count < 5);
        }

        internal static void DisplayWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"~~~CONGRATULATIONS {winner.Name.ToUpper()}~~~");
            Console.WriteLine(value: $"{winner.Name} IS THE WINNER WITH {GameLogic.NumberOfShotsTaken(winner)} NUMBER OF SHOTS");
        }
    }
}
