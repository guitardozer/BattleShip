using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class P1PlaceShips:GameState
    {
        public override void enter()
        {
            this.showGui();
            GameManager.getInstance().player1 = new Player();
        }

        public override void exit()
        {
            throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            throw new NotImplementedException();
        }

        public override void showGui()
        {
            GameManager.getInstance().gui.Hide();
            GameManager.getInstance().gui = new PlacementMenu();
            GameManager.getInstance().gui.Show();
        }
    }
}
