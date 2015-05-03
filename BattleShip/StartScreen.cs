using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    class StartScreen : GameState
    {
       
        public StartScreen() {
            
        }
        public override void enter()
        {
            //this.showGui();
        }

        public override void exit()
        {
            
        }

        public override GameState nextState(int evt)
        {
            if (evt == newGameButtonPressed) {
                return GameState.getP1PlaceShips();
            }
            if (evt == loadGameButtonPressed) {
                return GameState.getLoadGame();
            }
            if (evt == threeShipSelected) {
                GameManager.getInstance().gmm = new threeShip();
                return GameState.getP1PlaceShips();
            }
            if (evt == fiveShipSelected) {
                GameManager.getInstance().gmm = new fiveShip();
                return GameState.getP1PlaceShips();
            }
            return this;
        }

        public override void showGui() {
            if (GameManager.getInstance().gui == null)
            {
                GameManager.getInstance().gui = new StartMenu();
                Application.Run(GameManager.getInstance().gui);
            }
            else
            {
                GameManager.getInstance().gui.Hide();
                GameManager.getInstance().gui = new StartMenu();
                GameManager.getInstance().gui.Show();
            }
            
        }
    }
}
