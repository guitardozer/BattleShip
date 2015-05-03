using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class LoadGame:GameState
    {
        public override void enter()
        {
            this.showGui();


        }

        public override void exit()
        {
            //throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            //if (evt == loadFileSelectedPressed) { 
                
            //}
            //nextState is not used here. GameManager will set the GameState depending on the information in the bin file.
            return this;
        }

        public override void showGui()
        {
            GameManager.getInstance().gui.Hide();
            GameManager.getInstance().gui = new LoadMenu();
            GameManager.getInstance().gui.Show();
        }
    }
}
