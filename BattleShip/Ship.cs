using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public abstract class Ship:ShipIF
    {
        public List<Point> location = new List<Point>();
        List<Point> hits = new List<Point>();
        public Ship() { }
        public void showHit()
        {
            throw new NotImplementedException();
        }

        public bool isSunk()
        {
            Boolean sunk = true;
            foreach (Point element in location) {
                if (!hits.Contains(element)) {
                    sunk = false;
                }
            }
            return sunk;
        }
        public void hitPoint(Point p) {
            hits.Add(p);
        }
        public void show() { 
            
        }
    }
}
