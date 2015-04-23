using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleShip
{
    class StartScreen : GameState
    {

        public StartScreen(Form1 g) {
            this.gui = g;
        }
        public override void enter()
        {
            gui.setGameBoard("START SCREEN BOARD");
            gui.setMessageBox("START SCREEN MESSAGE");
            String s = "   o    o    o    o    o    o    o    o    o    o\n";
            String t = "";
            for (int i = 0; i < 10; i++) {
                t += s;                
            }
                gui.setGameBoard(t);
                gui.setMessageBox(t);
            //gui.setGameBoard("    1   2   3   4   5   6   7   8   9   10  \n A\n B\n C\n D\n E\n F\n G\n H\n I\n J\n");
        }

        public override GameState nextState(int evt)
        {
            throw new NotImplementedException();
        }
    }
}
