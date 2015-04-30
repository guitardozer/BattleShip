using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    // I DONT THINK WE EVEN NEED THIS STATE
    class SaveGame : GameState
    {
        public override void enter()
        {
            this.showGui();
            String filename = @"..\..\gamesaves\SavedGame.bin";
            Stream TestFileStream = File.Create(filename);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, GameManager.getInstance());
            GameManager.getInstance().gamestate = GameState.getP1Turn();
            // later, will this be a file chooser or is this gonna be it's own gui?

        }

        public override void exit()
        {
           // throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            //throw new NotImplementedException();
            return this;
        }

        public override void showGui()
        {
            ////GameManager.getInstance().gui.Hide();
            ////GameManager.getInstance().gui = new SaveMenu();
            ////GameManager.getInstance().gui.Show();
        }
    }
}
