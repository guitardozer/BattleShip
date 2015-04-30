using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    public class Player
    {
        public string name;
        private List<Ship> activeShips = new List<Ship>();
        public List<Ship> sunkShips = new List<Ship>();
        public List<Point> shotsFired = new List<Point>();

        public List<ShipIF> getHitInfo() {
            List<ShipIF> hitInfo = new List<ShipIF>();
            for (int i = 0; i < activeShips.Count; i++) {
                hitInfo.Add((ShipIF)activeShips.ElementAt(i));
            }
            for (int i = 0; i < sunkShips.Count; i++) {
                hitInfo.Add((ShipIF)sunkShips.ElementAt(i));
            }
            return hitInfo;
        }
        public List<Ship> getShipLocations() {
            List<Ship> locs = new List<Ship>();
            // later this will have to draw sunkships too
            for (int i = 0; i < activeShips.Count; i++) {
                locs.Add(activeShips.ElementAt(i));
            }
            for (int i = 0; i < sunkShips.Count; i++) {
                locs.Add(sunkShips.ElementAt(i));
            }
            return locs;
        }
        public void getHit(Point p) {
            for (int i = 0; i < activeShips.Count; i++) {
                if (activeShips.ElementAt(i).containsPoint(p)) {
                    activeShips.ElementAt(i).hitPoint(p);
                }
            }
        
        }
        public void addShip(Ship s) {
            activeShips.Add(s);
        }
        public void addShotFired(Point p) {
            shotsFired.Add(p);
        }
    }
}
