using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memory_Project
{
    public partial class scoreGame : Form
    {
        string text  = "";

        public scoreGame()
        {
            InitializeComponent();
            readScore();
        }

        private void readScore()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../scoreboard.txt");
            string[] lines = File.ReadAllLines(path);

            // Display the file contents by using a foreach loop.
            // Convert.ToString(richBoxScore.Text);
            foreach (string line in lines)
            {

                text +=  line + Environment.NewLine ;
                
            }
            singleScoreBox.Text = text; // Score voor singleplayer
        }

        private void scoreGame_Load(object sender, EventArgs e)
        {

        }
    }
}
