using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._0_BattleshipLibrary.Models
{
    public class GridSpotModel
    {
        public string SpotLetter { get; set; }

        public int SpotNumber { get; set; }

        //0-Empty , 1=Ship , 2=Hit , 3=Miss , 4-Sunk
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty; //by default spot is empty.
    } 
}
