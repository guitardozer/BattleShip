using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    class threeShip:GameMode
    {
        public threeShip() { }
        public threeShip(PlacementMenu pm) {
            this.pm = pm;
        }
        public override void setPM(PlacementMenu pm) {
            this.pm = pm;
        }
        public override void go()
        {
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("TwoHit"));
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("ThreeHit"));
            this.pm.shipsAvailable.Add((Ship)ShipFactory.getNewShip("FourHit"));
            //shipsAvailable.Add((Ship)ShipFactory.getNewShip("FourHit"));
            //shipsAvailable.Add((Ship)ShipFactory.getNewShip("FiveHit"));

            this.pm.showPlayerShips(new List<Ship>());
            this.pm.comboBox1.Items.AddRange(this.pm.shipsAvailable.ToArray());
        }
    }
}
