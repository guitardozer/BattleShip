using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    class fiveShip:GameMode
    {
        
        public fiveShip() { }
        public fiveShip(PlacementMenu pm) {
            this.pm = pm;
        }
        public override void go()
        {
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("TwoHit"));
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("TwoHit"));
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("ThreeHit"));
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("FourHit"));
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("FiveHit"));
            this.pm.showPlayerShips(new List<Ship>());
            this.pm.comboBox1.Items.AddRange(this.pm.shipsAvailable.ToArray());
        }

        public override void setPM(PlacementMenu pm)
        {
            this.pm = pm;
        }
    }
}
