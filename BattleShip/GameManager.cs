﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    // Singleton game manager, which will later be able to be saved and loaded with a Snapshot
    public class GameManager
    {

        public GameState gamestate;
        public Form1 gui;
        public Player player1;
        public Player player2;
        private static GameManager onlyInstance;

        private GameManager() { 
           // this.gamestate = GameState.start();
        }

        public void setGameState(GameState gs) {
            onlyInstance.gamestate = gs;
        }

        public static GameManager getInstance() {
            if (onlyInstance == null) {
                onlyInstance = new GameManager();                
            }
            return onlyInstance;
        }

        public void startTheGame() {
           // onlyInstance.gamestate = GameState.start();
            GameManager.getInstance().setGameState(GameState.start());
            GameManager.getInstance().gamestate.showGui();
            //StartMenu sm = new StartMenu();
            //Application.Run(sm);

        }
        /*public void startup(Form g){
            onlyInstance.gui = new Form1();
        
        }*/

        // later will have methods to support saving a memento and loading from a memento
    }
}
