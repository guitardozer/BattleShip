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
        public static ShipIF getNewShip(String boatType, List<Point> points){

            // later, check if the points are valid, and if not, just extend past p2 to where
            // the ship would need to be based off of the boatType
            // reflection to figure out what the object should be
            // Type type = blahwhatever;
            // Ship ship = (Ship)Activator.CreateInstance(type);                       
            Type type = Type.GetType("BattleShip." + boatType);
            Ship s = (Ship)Activator.CreateInstance(type);
            s.location = points;          
            return s;
        } 
        public static ShipIF getNewShip(String boatType) {
            Type type = Type.GetType("BattleShip." + boatType);
            Ship s = (Ship)Activator.CreateInstance(type);            
            return s;
        }
    }
}
