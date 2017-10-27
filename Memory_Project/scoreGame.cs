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
            Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();

            foreach (string line in lines)
            {
                string[] s = line.Split(':');
                text +=  line + Environment.NewLine ;
                foreach (var k in dic.Keys)
                {
                    dic[k].Sort();
                    if (dic.ContainsKey(s[0]))
                    {
                        dic[s[0]].Add(Int32.Parse(s[1]));
                    }
                }
            }
            var d = dic;
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
            Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();


            foreach (string line in lines)
            {
                string[] s = line.Split(':');
                var charsToRemove = new string[] { " ", ",", ".", ";", "'", "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower() };
                foreach (string c in charsToRemove)
                {
                    foreach (char v in c)
                    {
                        s[1] = s[1].Replace(v.ToString(), string.Empty);

                    }
                }
                textMulti += line + Environment.NewLine;
                if (dic.ContainsKey(s[0]))
                {
                    dic[s[0]].Add(Int32.Parse(s[1]));
                }
                else
                {
                    dic.Add(s[0], new List<int>());

                    dic[s[0]].Add(Int32.Parse(s[1]));
                }
            }
            foreach (var k in dic.Keys)
            {
                dic[k].Sort();
            }
            var d = dic;
            foreach (var item in dic)
            {
                var q = item;

            }
            multiScoreBox.Text = textMulti; // Score voor multiplayer
        }
        private void scoreGame_Load(object sender, EventArgs e)
        {

        }
    }
}
