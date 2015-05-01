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
        List<Ship> shipsAvailable = new List<Ship>();
        public List<Ship> completedShips = new List<Ship>();
        public PlacementMenu()
        {
            InitializeComponent();

            // this is where which ships the player has access to is set
            // for now only three twoHit ships are available
          
            shipsAvailable.Add(ShipFactory.getNewShip("TwoHit"));
            shipsAvailable.Add(ShipFactory.getNewShip("TwoHit"));
            shipsAvailable.Add(ShipFactory.getNewShip("ThreeHit"));
            shipsAvailable.Add(ShipFactory.getNewShip("FourHit"));
            shipsAvailable.Add(ShipFactory.getNewShip("FiveHit"));
            
            showPlayerShips(new List<Ship>());
            comboBox1.Items.AddRange(shipsAvailable.ToArray());
           
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
           // completedShips = shipsAvailable;
            GameManager.getInstance().gamestate = GameManager.getInstance().gamestate.processEvent(GameState.donePlacingPressed);
        }

        public void showPlayerShips(List<Ship> ships)
        {
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
            // put o for ship spots
            for (int i = 0; i < ships.Count; i++)
            {
                pts = ships.ElementAt(i).getPoints();
               
                for (int j = 0; j < pts.Count; j++)
                {
                    grid[pts.ElementAt(j).y, pts.ElementAt(j).x] = 'o';
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
            this.richTextBox1.Text = toDraw;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ship> selected = new List<Ship>();
           // selected.Add((Ship)comboBox1.SelectedItem);

            selected.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            for (int i = 0; i < completedShips.Count; i++) {
                selected.Add(completedShips.ElementAt(i));
            }
            showPlayerShips(selected);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shipsAvailable.ElementAt(comboBox1.SelectedIndex).moveRight();
            List<Ship> sel = new List<Ship>();
            sel.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            for (int i = 0; i < completedShips.Count; i++)
            {
                sel.Add(completedShips.ElementAt(i));
            }
            showPlayerShips(sel);
            //Ship selected = shipsAvailable.ElementAt(comboBox1.SelectedIndex);
            //selected.moveRight();
            //List<Ship> sel = new List<Ship>();
            //sel.Add(selected);
            //showPlayerShips(sel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shipsAvailable.ElementAt(comboBox1.SelectedIndex).moveUp();
            List<Ship> sel = new List<Ship>();
            sel.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            for (int i = 0; i < completedShips.Count; i++)
            {
                sel.Add(completedShips.ElementAt(i));
            }
            showPlayerShips(sel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shipsAvailable.ElementAt(comboBox1.SelectedIndex).moveLeft();
            List<Ship> sel = new List<Ship>();
            sel.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            for (int i = 0; i < completedShips.Count; i++)
            {
                sel.Add(completedShips.ElementAt(i));
            }
            showPlayerShips(sel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            shipsAvailable.ElementAt(comboBox1.SelectedIndex).moveDown();
            List<Ship> sel = new List<Ship>();
            sel.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            for (int i = 0; i < completedShips.Count; i++)
            {
                sel.Add(completedShips.ElementAt(i));
            }
            showPlayerShips(sel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // rotate left
            shipsAvailable.ElementAt(comboBox1.SelectedIndex).rotateLeft();
            List<Ship> sel = new List<Ship>();
            sel.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            for (int i = 0; i < completedShips.Count; i++)
            {
                sel.Add(completedShips.ElementAt(i));
            }
            showPlayerShips(sel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // rotate right
            shipsAvailable.ElementAt(comboBox1.SelectedIndex).rotateRight();
            List<Ship> sel = new List<Ship>();
            sel.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            for (int i = 0; i < completedShips.Count; i++)
            {
                sel.Add(completedShips.ElementAt(i));
            }
            showPlayerShips(sel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // place ship
            completedShips.Add(shipsAvailable.ElementAt(comboBox1.SelectedIndex));
            //shipsAvailable.RemoveAt(comboBox1.SelectedIndex);
            //comboBox1.Items.Remove(comboBox1.SelectedIndex);

        }
    }
}
