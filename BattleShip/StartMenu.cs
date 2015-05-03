using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class StartMenu : Form
    {
          public GameManager gm;
        public StartMenu()
        {
            InitializeComponent();        
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {              
       
            //GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.newGameButtonPressed);
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.threeShipSelected);
            //GameManager.getInstance().gamestate.showGui();
        
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.loadGameButtonPressed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.fiveShipSelected);
        }
    }
}
