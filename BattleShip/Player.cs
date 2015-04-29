﻿using System;
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
        public void addShip(Ship s) {
            activeShips.Add(s);
        }
    }
}
