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
    public partial class WinGUI : Form
    {
        public WinGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.newGameButtonPressed);
            GameManager.getInstance().startTheGame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
