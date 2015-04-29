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
    public partial class PlacementMenu : Form
    {
        public PlacementMenu()
        {
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.donePlacingPressed);
        }
    }
}
