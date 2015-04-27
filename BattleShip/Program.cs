using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameManager gm = GameManager.getInstance();
            gm.startTheGame();
          
           // gm.startTheGame();
           // GameManager.getInstance().gamestate = GameState.start();
            //gm.setGameState(GameState.start());
          //  Application.Run(new StartMenu());
            
        }
    }
}
