using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BattleShip
{
    class P1turn : GameState
    {
        public override void enter()
        {
            this.showGui();
            Form1 ff = (Form1)GameManager.getInstance().gui;
           
            List<Ship> shipLocsList = GameManager.getInstance().player1.getShipLocations();

            ff.showPlayerShips(shipLocsList);
            //Form1 f = new Form1();
           // Application.Run(f);
            
        }

        public override void exit()
        {
            //throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            if (evt == endTurnPressed)
            {
                
                return GameState.getP2Turn();
            }
            if (evt == firePressed) {                
                
                Form1 ff = (Form1)GameManager.getInstance().gui;
                ff.label13.Text = ff.getShotX().ToString() + " " + ff.getShotY().ToString();
                //Point p = new Point(ff.getShotX(), ff.getShotY());
                Point p = new Point(ff.getShotX(), ff.getShotY());
                GameManager.getInstance().player2.getHit(p);
                return this;
            }
            return this;
        }

        public override void showGui()
        {

            GameManager.getInstance().gui.Hide();            
            GameManager.getInstance().gui = new Form1();
            GameManager.getInstance().gui.Show();
            
            
           // throw new NotImplementedException();
        }
    }
}
