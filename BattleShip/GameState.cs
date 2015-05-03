using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    [Serializable()]
    public abstract class GameState
    {
        static StartScreen ss;
        static P1turn p1t;
        static P2turn p2t;
        static P1PlaceShips p1p;
        static P2PlaceShips p2p;
        static LoadGame lg;
        static PlayerWins pw;

        public const int newGameButtonPressed = 0;
        public const int donePlacingPressed = 1;
        public const int endTurnPressed = 2;
        public const int firePressed = 3;
        public const int loadGameButtonPressed = 4;
        public const int saveGamePressed = 5;
        public const int loadFileSelectedPressed = 6;
        public const int threeShipSelected = 7;
        public const int fiveShipSelected = 8;

        
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
                p1p = new P1PlaceShips();
                p2p = new P2PlaceShips();
                lg = new LoadGame();
                pw = new PlayerWins();                        
            }

            ss.enter();
            return ss;
        }
        protected static GameState getP1Turn() {
            return p1t;
        }
        protected static GameState getP2Turn() {
            return p2t;
        }
        protected static GameState getP2PlaceShips() {
            return p2p;
        }
        protected static GameState getP1PlaceShips() {
            return p1p;
        }
        protected static GameState getLoadGame() {
            return lg;
        }
        protected static GameState getStartScreen()
        {
            return ss;
        }
        protected static GameState getPlayerWins()
        {
            return pw;
        }
    }
}
