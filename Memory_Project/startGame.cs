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
                    // Create a new instance of the Form2 class
                    Game startGame = new Game();

                    // Show the settings form
                    startGame.Show();
                }
            
        }
    }
}
