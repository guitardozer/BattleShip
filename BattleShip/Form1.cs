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
                    grid[pts.ElementAt(j).x, pts.ElementAt(j).y] = 'o';
                }
                for (int k = 0; k < hits.Count; k++) {
                    grid[hits.ElementAt(k).x, hits.ElementAt(k).y] = 'x';
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
        public void showEnemyShips(List<ShipIF> enemyShips) { 
            
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
    }
}
