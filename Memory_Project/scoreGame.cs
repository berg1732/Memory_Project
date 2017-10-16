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
        //string text = File.ReadAllText(Properties.Resources.scoreboard);
        string[] lines = File.ReadAllLines(Properties.Resources.scoreboard);

        

        private void readScore()
        {
            // Display the file contents by using a foreach loop.
            // Convert.ToString(richBoxScore.Text);
            foreach (string line in lines)
            {

                text += Environment.NewLine+ line;
                
            }
            richBoxScore.Text = text;
        }

    }
}
