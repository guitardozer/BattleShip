using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class P1PlaceShips:GameState
    {
        ShipFactory sfactory = new ShipFactory();
        public override void enter()
        {
            this.showGui();
            GameManager.getInstance().player1 = new Player();
        }

        public override void exit()
        {
           // throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            if (evt == donePlacingPressed)
            {
                // this is just for testing it just puts a couple of ships on the board
                
                // GameManager.getInstance().player1.addShip(ShipFactory.getNewShip("twoHit", new Point(3,3), new Point(3,4)));
                
                PlacementMenu pm = (PlacementMenu)GameManager.getInstance().gui;
                List<Ship> ships = pm.completedShips;
                for (int i = 0; i < ships.Count; i++) {
                    GameManager.getInstance().player1.addShip(ships.ElementAt(i));
                }
                return GameState.getP2PlaceShips();
            }
            return this;
        }

        public override void showGui()
        {
            GameManager.getInstance().gui.Hide();
            GameManager.getInstance().gui = new PlacementMenu();
            GameManager.getInstance().gui.Show();
        }
    }
}
