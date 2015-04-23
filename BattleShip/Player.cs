using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Player
    {
        public string name;
        private List<Ship> activeShips = new List<Ship>();
        public List<Ship> sunkShips = new List<Ship>();
        
    }
}
