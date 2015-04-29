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
            return this;
        }

        public override void showGui() {
            GameManager.getInstance().gui = new StartMenu();
            Application.Run(GameManager.getInstance().gui);
        }
    }
}
