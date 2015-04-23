using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public abstract class GameState
    {

        public Form1 gui;

        // gonna need public const int eventName = 0 etc for every relevant game event
        // these events will be thrown by the gui

        // all subclasses (representing particular states) will implement these
        public abstract void enter();
        public abstract GameState nextState(int evt);
    }
}
