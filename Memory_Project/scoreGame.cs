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
        string text  = "", textMulti = "";
        

        public scoreGame()
        {
            InitializeComponent();
            readScore();
            readMultiScore();
        }
        /// <summary>
        /// path = directory voor scoreboard.txt 
        /// lines[] is voor het plaatsen van de score op elke lijn
        /// scorebox voor het plaatsen van txt 
        /// </summary>
        private void readScore()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/scoreboard.txt");
            string[] lines = File.ReadAllLines(path);


            foreach (string line in lines)
            {

                text +=  line + Environment.NewLine ;
                
            }
            singleScoreBox.Text = text; // Score voor singleplayer
        }

        /// <summary>
        /// path = directory voor scoreboardMulti.txt 
        /// lines[] is voor het plaatsen van de score op elke lijn
        /// multiscorebox voor het plaatsen van txt multi 
        /// </summary>
        private void readMultiScore()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/scoreboardMulti.txt");
            string[] lines = File.ReadAllLines(path);


            foreach (string line in lines)
            {

                textMulti += line + Environment.NewLine;

            }
            multiScoreBox.Text = textMulti; // Score voor multiplayer
        }
        private void scoreGame_Load(object sender, EventArgs e)
        {

        }
    }
}
