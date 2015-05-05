using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class PlayerWins : GameState
    {
        public override void enter()
        {
            this.showGui();
            if (GameManager.getInstance().player1.hasLost())
            {
                WinGUI wing = (WinGUI)GameManager.getInstance().gui;
                wing.setWinner(GameManager.getInstance().player2.name);
            }
            else
            {
                WinGUI wing = (WinGUI)GameManager.getInstance().gui;
                wing.setWinner(GameManager.getInstance().player1.name);
            }
        }

        public override void exit()
        {
            //throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            if (evt == newGameButtonPressed)
            {
                return GameState.getStartScreen();
            }
            return this;
        }

        public override void showGui()
        {
            GameManager.getInstance().gui.Hide();
            GameManager.getInstance().gui = new WinGUI();
            GameManager.getInstance().gui.Show();
        }
    }
}
