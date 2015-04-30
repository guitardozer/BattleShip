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
            List<ShipIF> enemyShips = GameManager.getInstance().player1.getHitInfo();
            ff.showPlayerShips(shipLocsList);
            ff.showEnemyShips(enemyShips);
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
            if (evt == firePressed)
            {

                Form1 ff = (Form1)GameManager.getInstance().gui;
                ff.label13.Text = ff.getShotX().ToString() + " " + ff.getShotY().ToString();
                
                //Point p = new Point(ff.getShotX(), ff.getShotY());
                Point p = new Point(ff.getShotX(), ff.getShotY());
                GameManager.getInstance().player1.getHit(p);
                ff.showEnemyShips(GameManager.getInstance().player1.getHitInfo());
                return this;
            }
            if (evt == saveGamePressed)
            {
                GameManager.getInstance().saveMemento();
                return this;
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
