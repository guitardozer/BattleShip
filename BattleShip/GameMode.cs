using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    public abstract class GameMode
    {
        public PlacementMenu pm;
        //public GameMode(PlacementMenu pmm) {
        //    this.pm = pmm;
        //}
        public abstract void go();
        public abstract void setPM(PlacementMenu pm);
    }
}
