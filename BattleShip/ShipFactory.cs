using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class ShipFactory
    {
        public static ShipIF getShipIF(Ship shipToGetIF) {
            ShipIF sif = (ShipIF)shipToGetIF;
            return sif;
        }
        public static Ship getNewShip(String boatType, Point p1, Point p2){

            // later, check if the points are valid, and if not, just extend past p2 to where
            // the ship would need to be based off of the boatType
            // reflection to figure out what the object should be
            List<Point> pts = new List<Point>();
            pts.Add(p1);
            pts.Add(p2);
            Ship s = new TwoHit(pts);
            s.hitPoint(p1);
            return s;
        }
        public static Ship getNewShip(String boatType) {
            Ship s = new TwoHit();
            return s;
        }
    }
}
