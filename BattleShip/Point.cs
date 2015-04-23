using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Point
    {
        private int xpos;
        private int ypos;
        public int x
        {
            get
            {
                return xpos;
            }           
        }
        public int y
        {
            get 
            {
                return ypos;
            }
        }

        public Point(int xval, int yval) {
            this.xpos = xval;
            this.ypos = yval;
        }
    }
}
