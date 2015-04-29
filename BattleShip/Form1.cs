﻿using System;
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
            for (int i = 0; i < ships.Count; i++) { 
                pts = ships.ElementAt(i).getPoints();
                this.playerBoard.Text += pts.Count + " ";
            }
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
    }
}
