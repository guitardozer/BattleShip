using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleShip
{
    class P1turn : GameState
    {
        public override void enter()
        {
            
            //Form1 f = new Form1();
           // Application.Run(f);
            
        }

        public override GameState nextState(int evt)
        {
            return this;
        }

        public override void showGui()
        {
            Form1 fff = new Form1();
            fff.ShowDialog();
           // throw new NotImplementedException();
        }
    }
}
