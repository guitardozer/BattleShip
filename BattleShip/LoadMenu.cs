using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class LoadMenu : Form
    {
        string[] names;
        public LoadMenu()
        {
            InitializeComponent();
            names = Directory.GetFiles(@"..\..\gamesaves\","*.bin");
            List<String> goodnames = new List<String>();
            for (int i = 0; i < names.Length; i++) {
                goodnames.Add(names[i].Substring(16, names.ElementAt(i).Length - 16));
            }
                comboBox1.Items.AddRange(goodnames.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameManager.getInstance().setMemento(names[comboBox1.SelectedIndex]);
        }

        private void LoadMenu_FormClosing(object sender, FormClosingEventArgs e)
        {          
        }

        private void LoadMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
