﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    public abstract class Ship:ShipIF
    {
        public List<Point> location = new List<Point>();
        List<Point> hits = new List<Point>();

        public bool isHorizontal = true;
        protected List<Point> horizontalPosition = new List<Point>();
        protected List<Point> verticalPosition = new List<Point>();

        public bool isOverlapping(List<Ship> ships) {
            bool overlapping = false;
            for (int i = 0; i < ships.Count; i++) {
                for (int j = 0; j < ships.ElementAt(i).location.Count; j++) { 
                    if(this.hasThatPoint(ships.ElementAt(i).location.ElementAt(j))){
                        overlapping = true;
                    }
                }
            }
            return overlapping;
        }

        public Ship() { }
        public Ship(List<Point> locations) {
            this.location = locations;
        }
        public List<Point> showHit()
        {
            return hits;
        }
        public bool hasThatPoint(Point p) {
            bool hasPoint = false;
            for (int i = 0; i < this.location.Count; i++) {
                if (this.location.ElementAt(i).isSameAs(p)) {
                    hasPoint = true;
                }
            }
            return hasPoint;
        }
        public abstract void moveRight();
        public abstract void moveLeft();
        public abstract void moveUp();
        public abstract void moveDown();
        public abstract void rotate();
        public bool isSunk()
        {
            Boolean sunk = false;
            if (hits.Count == location.Count)
            {
                sunk = true;
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
