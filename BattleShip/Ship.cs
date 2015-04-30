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
        public List<Point> showHit()
        {
            return hits;
        }
        public abstract void moveRight();
        public abstract void moveLeft();
        public abstract void moveUp();
        public abstract void moveDown();
        public abstract void rotateLeft();
        public abstract void rotateRight();
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
        public bool containsPoint(Point p) {
            for (int i = 0; i < location.Count; i++) {
                if (location.ElementAt(i).isSameAs(p)) {
                    return true;
                }            
            }
            return false;
        }
        public void hitPoint(Point p) {
            bool alreadyHit = false;
            for (int i = 0; i < hits.Count; i++) {
                if (hits.ElementAt(i).isSameAs(p)) {
                    alreadyHit = true;
                }
            }
            if (!alreadyHit) {
                hits.Add(p);
            }
            
        }
        public String show() {
            String s = "";
            for (int i = 0; i < this.location.Count; i++) {
                s += "(";
                s += this.location.ElementAt(i).x;
                s += ", ";
                s += this.location.ElementAt(i).y;

            }
            return s;
        }
        public List<Point> getPoints() {
            return this.location;
        }
        
    }
}
