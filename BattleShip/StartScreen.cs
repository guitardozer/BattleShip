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
            
        }

        public override GameState nextState(int evt)
        {
            if (evt == newGameButtonPressed) {
                return GameState.getP1Turn();
            }
            return this;
        }

        public override void showGui() {
            StartMenu sm = new StartMenu();
            Application.Run(sm);
        }
    }
}
