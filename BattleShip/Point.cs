using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Point
    {

        public int x;

        public int y;

        public Point(int xval, int yval) {
            this.x = xval;
            this.y = yval;
        }
        public bool isSameAs(Point pp) {
            if (pp.x == this.x && pp.y == this.y)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
