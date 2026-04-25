using _35._0_BattleshipLibrary;
using _35._0_BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._1_BattleShipGame
{
   public  class GameUI
    {
        public static void EntireLogic()
        {
            WelcomeMsg();

            PlayerInfoModel activePlayer = PlayerInfo("PLAYER 1");

            PlayerInfoModel opponent = PlayerInfo("PLAYER 2");

            PlayerInfoModel winner = null; //either player will be placed at winner 

            //do loop to determine the winner
            do
            {
                //diplay grid
                DisplayGrid(activePlayer);


                
            }
            while (true);
        }

        private static void DisplayGrid(PlayerInfoModel activePlayer)
        {
            string currentGrid = activePlayer.AllLocations[0].SpotLetter;

            foreach (var gridSpot in activePlayer.AllLocations)
            {
                if(currentGrid != gridSpot.SpotLetter)
                {
                    Console.WriteLine();//move to next line when the spotLetter changes for grid view
                    currentGrid = gridSpot.SpotLetter;
                }
                if(gridSpot.Status == GridSpotStatus.Empty)
                {
                    Console.Write($"{gridSpot.SpotLetter} {gridSpot.SpotNumber}");
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
                if(valid == false)
                {
                    Console.WriteLine("ENTER A CORRECT LOCATION TO PLACE THE SHIP");
                }


            } while (shipLoc.ShipLocations.Count < 5);
        }
    }
}
