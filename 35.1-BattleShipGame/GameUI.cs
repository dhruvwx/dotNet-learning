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
        public static PlayerInfoModel PlayerInfo()
        {
            PlayerInfoModel player = new();

            //wlcome player
            WelcomeMsg();

            //Player name
            player.Name = EnterName();

            //add all locations
            GameLogic.InitializingSpots(player);
           

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
    }
}
