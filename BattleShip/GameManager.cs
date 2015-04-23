using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    // Singleton game manager, which will later be able to be saved and loaded with a Snapshot
    public class GameManager
    {
        private static GameManager onlyInstance;

        public static GameManager getInstance() {
            if (onlyInstance == null) {
                onlyInstance = new GameManager();
            }
            return onlyInstance;
        }

        public GameState gamestate;
        public Form1 gui;

        public Player player1;
        public Player player2;

        public void startup(Form1 g){
            onlyInstance.gui = g;
            onlyInstance.gamestate = new StartScreen(onlyInstance.gui);
            onlyInstance.gamestate.enter();
        
        }

        // later will have methods to support saving a memento and loading from a memento
    }
}
