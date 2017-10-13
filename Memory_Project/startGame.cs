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
        public startGame()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
                {
                    // Een nieuwe instance aan maken. (Game Class)
                    Game Game = new Game();

                    // De Game laten weergeven
                    Game.Show();
                }
            
        }
    }
}
