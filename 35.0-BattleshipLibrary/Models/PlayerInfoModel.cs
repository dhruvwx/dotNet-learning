using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._0_BattleshipLibrary.Models
{
    public    class PlayerInfoModel
    {
        public string Name { get; set; }

        public List<GridSpotModel> ShipLocations { get; set; } //will have loc of 5 ships 

        public List<GridSpotModel> AllLocations { get; set; } //all loc of grid , at start all empty 


    }
}
