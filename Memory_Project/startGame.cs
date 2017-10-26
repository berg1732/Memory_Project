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
                 
                if(gameToolStripMenuItem.Checked == true)
                {
                    Game.BackColor = Color.SkyBlue;
                }
                else if (musicToolStripMenuItem.Checked == true)
                {
                    Game.BackColor = Color.DarkRed;
                }
                else if (memeToolStripMenuItem.Checked == true)
                {
                    Game.BackColor = Color.DarkOrange;
                }
                else
                {
                    Game.BackColor = Color.DarkOrange;
                }

                // Multiplayer game laten weergeven
                Game.Show();
            }
            
        }

        private void buttonSingleplayer_Click(object sender, EventArgs e)
        {
            {
                // Een nieuwe instance aan maken. (singleGame Class)
                singleGame singleGame = new singleGame(this);

                if (gameToolStripMenuItem.Checked == true)
                {
                    singleGame.BackColor = Color.SkyBlue;
                }
                else if (musicToolStripMenuItem.Checked == true)
                {
                    singleGame.BackColor = Color.DarkRed;
                }
                else if (memeToolStripMenuItem.Checked == true)
                {
                    singleGame.BackColor = Color.DarkOrange;
                }
                else
                {
                    singleGame.BackColor = Color.DarkOrange;
                }

                // Singleplayer game laten weergeven
                singleGame.Show();
            }
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            // Een nieuwe instance aan maken. (scoreGame Class)
            scoreGame scoreGame = new scoreGame();

            //Scoreboard laten weergeven
            scoreGame.Show();
        }

        /// <summary>
        /// Checked of unchecked
        /// </summary>
        /// <param name="sender = unchecked"></param>
        /// <param name="e as temp"></param>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // uncheck 
            temp.CheckState = CheckState.Unchecked;
            temp = (ToolStripMenuItem)sender;
            // check 
            temp.CheckState = CheckState.Checked;
        }

        /// <summary>
        /// Kijken of deck game is aangevinked
        /// </summary>
        /// <returns>gameToolStripMenuItem.Checked = true or false</returns>
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

        /// <summary>
        /// Kijken of deck music is aangevinked
        /// </summary>
        /// <returns>musicToolStripMenuItem.Checked = true or false</returns>
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

        /// <summary>
        /// Kijken of deck meme is aangevinked
        /// </summary>
        /// <returns>memeToolStripMenuItem.Checked = true or false</returns>
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
