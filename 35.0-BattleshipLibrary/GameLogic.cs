using _35._0_BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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



        public static void Spots(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new();
            spot.SpotLetter = letter;
            spot.SpotNumber = number;
            spot.Status = GridSpotStatus.Empty;

            model.AllLocations.Add(spot);
        }

        public static bool ContinueGame(PlayerInfoModel player)
        {
            //continue game if even one ship is remaining
            bool continueGame = false;

            foreach (var ship in player.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk)
                {
                    continueGame = true;
                }
            }
            return continueGame;
        }

        public static int NumberOfShotsTaken(PlayerInfoModel player)
        {
            //look all the spots , and count all the spots that are not empty coz if its not empty there has been a shot taken.
            int shotCount = 0;
            foreach (var location in player.AllLocations)
            {
                //will go to each loc and look if shot has been taken (if its is not empty shot is taken) then add it to count
                if (location.Status != GridSpotStatus.Empty)
                {
                    shotCount += 1;
                }

            }
            return shotCount;
        }

        public static bool ShipPlacement(PlayerInfoModel shipLoc, string location)
        {
            bool addShip = false;
            ///split Grid(A1-B4 etc) then add it into the GridSpotModel into letter , number and update the status to ship

            (string row, int column) = SplitShotIntoRowsAndColumns(location);

            //add to ShipLoctions List [list is instantiated of type GridSpotModel and will add that entire object ( letter , number , status ) in the list]

            ///Ship will only be placed if the spot is valid (i.e from A1 to E5) and if that is still empty to take the ship.
            bool isValidSpot = CheckValidSpot(shipLoc, row, column);
            bool isLocEmpty = EmptyLocCheck(shipLoc, row, column);//for ship

            if (isValidSpot && isLocEmpty) //BOTH HAS TO BE TRUE
            {
                GridSpotModel newObject = new GridSpotModel();

                newObject.SpotLetter = row;
                newObject.SpotNumber = column;
                newObject.Status = GridSpotStatus.Ship;

                shipLoc.ShipLocations.Add(newObject);

                addShip = true; //spot is available and empty hence ship can be addded
            }
            return addShip;

        }

        private static bool EmptyLocCheck(PlayerInfoModel shipLoc, string row, int column)
        {
            //checks if loc has a ship or not - if not then ship can be added
            bool isLocEmpty = true;
            foreach (var location in shipLoc.ShipLocations)
            {
                if (location.SpotLetter == row.ToUpper() && location.SpotNumber == column)
                {
                    isLocEmpty = false; //if Row/Column matches w locations means there is a ship already there hence u cant put ship there so turn in false.
                }

            }
            return isLocEmpty;
        }

        private static bool CheckValidSpot(PlayerInfoModel shipLoc, string row, int column)
        {
            bool isValidSpot = false;
            //match each spot with row and column and if it matches the spot exists and is valid.

            foreach (var spot in shipLoc.AllLocations)
            {
                if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
                {
                    isValidSpot = true;
                }
            }
            return isValidSpot;

        }

        public static (string row, int column) SplitShotIntoRowsAndColumns(string shotTaken)
        {
            //use array to split -->>   .Split() - tells you to split at what char ||   ToArray() - splits each char (use this here)

            if (shotTaken.Length != 2)
            {
                throw new ArgumentException("YOUR SHOT IS NOT VALID. THE SHOT IS", "shotTaken"); //msg , parameter
            }
            char[] shot = shotTaken.ToArray();

            string row = shot[0].ToString();
            int column = int.Parse(shot[1].ToString());

            return (row, column);
        }

        public static bool IsShotValid(PlayerInfoModel player, string row, int column)
        {
            bool isValidShot = false;

            foreach (var spot in player.AllLocations)
            {
                if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
                {
                    if (spot.Status == GridSpotStatus.Empty)//not shot there before , so we can shot there
                    {
                        isValidShot = true;
                    }
                }
            }
            return isValidShot;
        }

        public static bool IsHit(PlayerInfoModel opponent, string row, int column)
        {
            bool isValidShot = false;

            foreach (var shipLoc in opponent.ShipLocations)
            {
                if (shipLoc.SpotLetter == row.ToUpper() && shipLoc.SpotNumber == column)
                {
                    isValidShot = true;
                }
            }
            return isValidShot;
        }

        public static void StoreResult(PlayerInfoModel player, string row, int column, bool isHit)
        {

            foreach (var spot in player.AllLocations)
            {
                if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
                {
                    if (isHit)//if is hit true that means ship is hit
                    {
                        spot.Status = GridSpotStatus.Hit;
                    }
                    else
                    {
                        spot.Status = GridSpotStatus.Miss;
                    }
                }
            }
        }
    }
}
