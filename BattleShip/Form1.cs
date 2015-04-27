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

        public void dispInOutputBox(String s) {
         //   this.outputBox.Text += "\n" + s;
            this.outputBox.AppendText(s + "\n");
        }
        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
