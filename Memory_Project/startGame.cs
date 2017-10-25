using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Project
{
    /// <summary>
    /// Formulier voor het Hoofd menu
    /// </summary>
    public partial class startGame : Form
    {
        private ToolStripMenuItem temp;
        public startGame()
        {
            InitializeComponent();
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.musicToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            this.memeToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            temp = this.decksToolStripMenuItem;
            
        }

        private void buttonMultiplayer_Click(object sender, EventArgs e)
        {
                {
                    // Een nieuwe instance aan maken. (Game Class)
                    Game Game = new Game(this);

                    // De Game laten weergeven
                    Game.Show();
                }
            
        }

        private void buttonSingleplayer_Click(object sender, EventArgs e)
        {
            {
                singleGame singleGame = new singleGame();

                singleGame.Show();
            }
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            scoreGame scoreGame = new scoreGame();

            scoreGame.Show();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // uncheck 
            temp.CheckState = CheckState.Unchecked;
            temp = (ToolStripMenuItem)sender;
            // check 
            temp.CheckState = CheckState.Checked;
        }

        public bool deckSettingGame()
        {
            if (this.gameToolStripMenuItem.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deckSettingMusic()
        {
            if (this.musicToolStripMenuItem.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deckSettingMeme()
        {
            if (this.memeToolStripMenuItem.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
