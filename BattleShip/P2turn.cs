using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class P2turn : GameState
    {
        public override void enter()
        {
            this.showGui();
            Form1 ff = (Form1)GameManager.getInstance().gui;

            List<Ship> shipLocsList = GameManager.getInstance().player2.getShipLocations();

            ff.showPlayerShips(shipLocsList);
        }

        public override void exit()
        {
            //throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            if (evt == endTurnPressed)
            {

                return GameState.getP1Turn();
            }
            return this;
        }

        public override void showGui()
        {
            GameManager.getInstance().gui.Hide();
            GameManager.getInstance().gui = new Form1();
            GameManager.getInstance().gui.Show();
        }
    }
}
