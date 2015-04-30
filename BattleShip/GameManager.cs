using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BattleShip
{
    // Singleton game manager, which will later be able to be saved and loaded with a Snapshot
    [Serializable()]
    public class GameManager
    {

        public GameState gamestate;
        [NonSerialized()]public Form gui;
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
            GameManager.getInstance().setGameState(GameState.start());
            GameManager.getInstance().gamestate.showGui();
        }

        
        // later will have methods to support saving a memento and loading from a memento
        public void saveMemento() { 
            // implement code for saving a copy of the onlyInstance
            // the gui is not saved, so upon returning it should probably start up the most recent gamestate
            String filename = @"..\..\gamesaves\SavedGame.bin";
            Stream TestFileStream = File.Create(filename);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, GameManager.getInstance());
        }
        public void setMemento(String FileName) {
            // NOTE EVEN A LITTLE BIT TESTED I HAVE NO IDEA IF THIS WILL WORK

            if (File.Exists(FileName))
            {
                Stream TestFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                GameManager.onlyInstance = (GameManager)deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();

                // since the gamestate.enter() is likely to run showGui() and try to hide the gamestate's gui
                GameManager.getInstance().gui = new Form1();
                GameManager.getInstance().gui.Show();
                GameManager.getInstance().gamestate.enter();
            }

        }
    }
}
