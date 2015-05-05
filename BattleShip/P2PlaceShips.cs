using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class P2PlaceShips:GameState
    {
        public override void enter()
        {
            GameManager.getInstance().player2 = new Player();
            this.showGui();
        }

        public override void exit()
        {
           // throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            if (evt == donePlacingPressed)
            {
                PlacementMenu pm = (PlacementMenu)GameManager.getInstance().gui;
                List<Ship> ships = pm.completedShips;
                for (int i = 0; i < ships.Count; i++)
                {
                    GameManager.getInstance().player2.addShip(ships.ElementAt(i));
                }
                GameManager.getInstance().player2.name = pm.getName();

                return GameState.getP1Turn();
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
