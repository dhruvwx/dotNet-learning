using _35._0_BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._0_BattleshipLibrary
{
    public class GameLogic
    {
        public static void InitializingSpots(PlayerInfoModel model)
        {
            List<string> letters = new List<string>();
            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            letters.Add("D");
            letters.Add("E");

            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
                4,
                5

            };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    Spots(model, letter, number);
                }            
            }
        }

        private static void Spots(PlayerInfoModel model , string letter , int number)
        {
            GridSpotModel spot = new();
            spot.SpotLetter = letter;
            spot.SpotNumber = number;
            spot.Status = GridSpotStatus.Empty;

            model.AllLocations.Add(spot);
        }
        



    }
}
