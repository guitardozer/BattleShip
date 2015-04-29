using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public abstract class GameState
    {
        static StartScreen ss;
        static P1turn p1t;
        static P2turn p2t;
        static SaveGame sg;
        static P1PlaceShips p1p;

        public const int newGameButtonPressed = 0;
        
        public GameState processEvent(int evt) {
            GameState gm = this.nextState(evt);
            if (this != gm)
            {
                this.exit();
                gm.enter();
            }
            return gm;
        }
        // gonna need public const int eventName = 0 etc for every relevant game event
        // these events will be thrown by the gui

        // all subclasses (representing particular states) will implement these
        public abstract void enter();
        public abstract void exit();
        public abstract GameState nextState(int evt);
        public abstract void showGui();
        public static GameState start()
        {
            if (ss == null)
            {
                ss = new StartScreen();
                p1t = new P1turn();
                p2t = new P2turn();
                sg = new SaveGame();
                p1p = new P1PlaceShips();
                
                                            
            }

            ss.enter();
            return ss;
        }
        protected static GameState getP1Turn() {
            return p1t;
        }

        protected static GameState getP1PlaceShips() {
            return p1p;
        }
    }
}
