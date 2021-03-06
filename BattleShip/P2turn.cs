﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Serializable()]
    class P2turn : GameState
    {        
        public override void enter()
        {
            this.showGui();
            Form1 ff = (Form1)GameManager.getInstance().gui;
            List<Ship> shipLocsList = GameManager.getInstance().player2.getShipLocations();
            List<ShipIF> enemyShips = GameManager.getInstance().player1.getHitInfo();
            ff.showPlayerShips(GameManager.getInstance().player2, GameManager.getInstance().player1);
            ff.showEnemyShips(GameManager.getInstance().player1, GameManager.getInstance().player2);
            ff.dispInOutputBox("> " + GameManager.getInstance().player2.name + "'s Turn.");
           
        }

        public override void exit()
        {
            //throw new NotImplementedException();
        }

        public override GameState nextState(int evt)
        {
            if (evt == endTurnPressed)
            {

                return GameState.getP1Turn();
            }
            if (evt == firePressed)
            {

                Form1 ff = (Form1)GameManager.getInstance().gui;
                //ff.label13.Text = ff.getShotX().ToString() + " " + ff.getShotY().ToString();
                ff.dispInOutputBox("> Shot Fired!");
                ff.disableFire();
                //Point p = new Point(ff.getShotX(), ff.getShotY());
                Point p = new Point(ff.getShotX(), ff.getShotY());
                bool hit = GameManager.getInstance().player1.getHit(p);
                if (!hit)
                    GameManager.getInstance().player2.addShotFired(p);
               // GameManager.getInstance().player2.addShotFired(p);
                ff.showEnemyShips(GameManager.getInstance().player1, GameManager.getInstance().player2);
                if (GameManager.getInstance().player1.hasLost())
                {
                    return getPlayerWins();
                }
                //ff.dispInOutputBox(GameManager.getInstance().player1.hasLost().ToString());
                //ff.dispInOutputBox("sunk ships count:" + GameManager.getInstance().player1.sunkShipsCount().ToString());
                return this;
            }
            if (evt == saveGamePressed)
            {
                GameManager.getInstance().saveMemento();
                return this;
            }
            return this;
        }

        public override void showGui()
        {
            GameManager.getInstance().gui.Hide();
            GameManager.getInstance().gui = new Form1();
            GameManager.getInstance().gui.Show();
        }
    }
}
