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
    [Serializable()]
    public partial class Form1 : Form
    {
        public GameManager gamemanager;
        public Form1()
        {
            InitializeComponent();
            
            gamemanager = GameManager.getInstance();
            //gamemanager.startup(this);            
        }

        public void setGameBoard(String s){
            this.enemyBoard.Text = s;
        }

        public void setMessageBox(String s) {
            this.playerBoard.Text = s;            
        }

        public void showEnemyShips(List<ShipIF> ships) {
            List<Point> pts = new List<Point>();
            char[,] grid = new char[10, 10];
            // put x through whole grid
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    grid[i, j] = '~';
                }
            }
            for (int i = 0; i < ships.Count; i++)
            {
                pts = ships.ElementAt(i).showHit();
                
                for (int j = 0; j < pts.Count; j++)
                {
                    grid[pts.ElementAt(j).y, pts.ElementAt(j).x] = 'x';
                }
                
            }
            // draw array to the text box
            String toDraw = "";
            for (int i = 0; i < 10; i++)
            {
                toDraw += " ";
                for (int j = 0; j < 10; j++)
                {
                    toDraw += grid[i, j];
                    toDraw += "  ";
                }
                toDraw += "\n";
            }
            this.enemyBoard.Text = toDraw;

        }
        public void showPlayerShips(List<Ship> ships) {
            List<Point> pts = new List<Point>();
            List<Point> hits = new List<Point>();
            char[,] grid = new char[10, 10];
            // put x through whole grid
            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    grid[i, j] = '~';
                }
            }
            // put o for ship spots
            for (int i = 0; i < ships.Count; i++)
            {
                pts = ships.ElementAt(i).getPoints();
                hits = ships.ElementAt(i).showHit();
                for (int j = 0; j < pts.Count; j++)
                {
                    grid[pts.ElementAt(j).y, pts.ElementAt(j).x] = 'o';
                }
                for (int k = 0; k < hits.Count; k++) {
                    grid[hits.ElementAt(k).y, hits.ElementAt(k).x] = 'x';
                }
            }
            
            // draw array to the text box
            String toDraw = "";
            for (int i = 0; i < 10; i++) {
                toDraw += " ";
                for (int j = 0; j < 10; j++) {
                    toDraw += grid[i, j];
                    toDraw += "  ";
                }
                toDraw += "\n";
            }
            this.playerBoard.Text = toDraw;
        }
        
        public void dispInOutputBox(String s) {
         //   this.outputBox.Text += "\n" + s;
            this.outputBox.AppendText(s + "\n");
        }
        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.endTurnPressed);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // FIREEE
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.firePressed);
        }
        public int getShotX() {
            return comboBox2.SelectedIndex;
        }
        public int getShotY() {
            return comboBox1.SelectedIndex;
        }

        private void saveGameButton_Click(object sender, EventArgs e)
        {
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.saveGamePressed);
        }
    }
}
