using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    class FiveHit:Ship
    {
        public FiveHit() {
            this.location.Add(new Point(0, 0));
            this.location.Add(new Point(1, 0));
            this.location.Add(new Point(2, 0));
            this.location.Add(new Point(3, 0));
            this.location.Add(new Point(4, 0));
        }
        public override void moveRight()
        {
            bool canMove = true;
            for (int i = 0; i < location.Count; i++)
            {
                if (this.location.ElementAt(i).x > 8)
                {
                    canMove = false;
                }
            }
            if (canMove)
            {
                for (int i = 0; i < location.Count; i++)
                {
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

        public override void rotateLeft()
        {
            throw new NotImplementedException();
        }

        public override void rotateRight()
        {
            throw new NotImplementedException();
        }
    }
}
