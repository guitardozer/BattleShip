using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    class TwoHit:Ship
    {
        
       
        public TwoHit() {
            this.horizontalPosition.Add(new Point(0, 0));
            this.horizontalPosition.Add(new Point(1, 0));

            this.verticalPosition.Add(new Point(0, 0));
            this.verticalPosition.Add(new Point(0, 1));

            this.location = this.horizontalPosition;
        }

        public override void moveRight()
        {
            bool canMove = true;
            for (int i = 0; i < location.Count; i++) {
                if (this.location.ElementAt(i).x > 8) {
                    canMove = false;
                }
            }
            if (canMove) {
                for (int i = 0; i < location.Count; i++) {
                    this.location.ElementAt(i).x += 1;
                }
            }
        }

        public override void moveLeft()
        {
            bool canMove = true;
            for (int i = 0; i < location.Count; i++)
            {
                if (this.location.ElementAt(i).x < 1)
                {
                    canMove = false;
                }
            }
            if (canMove)
            {
                for (int i = 0; i < location.Count; i++)
                {
                    this.location.ElementAt(i).x -= 1;
                }
            }
        }

        public override void moveUp()
        {
            bool canMove = true;
            for (int i = 0; i < location.Count; i++)
            {
                if (this.location.ElementAt(i).y < 1)
                {
                    canMove = false;
                }
            }
            if (canMove)
            {
                for (int i = 0; i < location.Count; i++)
                {
                    this.location.ElementAt(i).y -= 1;
                }
            }
        }

        public override void moveDown()
        {
            bool canMove = true;
            for (int i = 0; i < location.Count; i++)
            {
                if (this.location.ElementAt(i).y > 8)
                {
                    canMove = false;
                }
            }
            if (canMove)
            {
                for (int i = 0; i < location.Count; i++)
                {
                    this.location.ElementAt(i).y += 1;
                }
            }
        }

        public override void rotate()
        {
            /*if (location.Count == 2) {
                if (location.ElementAt(0).y == location.ElementAt(1).y) {
                    if (location.ElementAt(0).x < location.ElementAt(1).x) {
                        if (location.ElementAt(0).x < 9 && location.ElementAt(0).y > 1)
                        {
                            location.ElementAt(0).x += 1;
                            location.ElementAt(0).y -= 1;
                        }
                    }
                    else if (location.ElementAt(1).x < location.ElementAt(0).x) {
                        if (location.ElementAt(1).x < 9 && location.ElementAt(1).y > 1)
                        {
                            location.ElementAt(1).x += 1;
                            location.ElementAt(1).y -= 1;
                        }
                    }
                }
                else if (location.ElementAt(0).x == location.ElementAt(1).x) { 
                    
                
                }
            }*/
            this.isHorizontal = !this.isHorizontal;
            if (this.isHorizontal)
            {
                this.location = this.horizontalPosition;
            }
            else
            {
                this.location = this.verticalPosition;
            }
        }
    }
}
