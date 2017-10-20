using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Memory_Project
{
    
    /// <summary>
    /// Formulier voor het speelveld voor multiplayer games op dezelfde pc
    /// </summary>
    public partial class Game : Form
    {
        public int turn = 0;
        private bool allowClick = true;
        private PictureBox firstGuess;
        private readonly Random random = new Random();
        private readonly Timer clickTimer = new Timer();
       
        string naamP1 = "speler 1";
        string naamP2 = "speler 2";
        int scoreP1 = 0;
        int scoreP2 = 0;
        int WinningScore;
       
        public Game()
        {
            InitializeComponent();
            setRandomImages();
            naamP1 = Interaction.InputBox("Vul je naam in", "Vul je naam in", "speler 1", -1, -1);
            naamP2 = Interaction.InputBox("Vul je naam in", "Vul je naam in", "speler 2", -1, -1);
            lblScoreP1.Text = naamP1 + ": " + scoreP1;
            lblScoreP2.Text = naamP2 + ": " + scoreP2;
            lblTurn.Text = naamP1 + " is aan de beurt";
            lblShowImages.Text = "5";
            timerShowImages.Start();

            clickTimer.Interval = 1000;
            clickTimer.Tick += clickTimer_Tick;
        }

        /// <summary>
        /// Methode voor algmeen Array PictureBox
        /// </summary>
        private PictureBox[] PictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        /// <summary>
        /// Images uit de resources map halen
        /// </summary>
        private static IEnumerable<Image> Images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.CardG1,
                    Properties.Resources.CardG2,
                    Properties.Resources.CardG3,
                    Properties.Resources.CardG4,
                    Properties.Resources.CardG5,
                    Properties.Resources.CardG6,
                    Properties.Resources.CardG7,
                    Properties.Resources.CardG8
                };
            }
        }

        /// <summary>
        /// Timer om de afbeeldingen voor 5 seconde weer te geven
        /// </summary>
        private void timerShowImages_Tick(object sender, EventArgs e)
        {
            allowClick = false;
            int timer = Convert.ToInt32(lblShowImages.Text);
            timer = timer - 1;
            lblShowImages.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                allowClick = true;
                timerShowImages.Stop();
                hideImages();
            }
            else
            {
                showImages();
            }
        }

        private void showImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Image = (Image)pic.Tag;

            }
        }

        /// <summary>
        /// Start de Timer van de Game
        /// </summary>
        /// <summary>
        /// Reset Images bij nadat 45 secondes zijn afgelopen
        /// </summary>
        private void resetImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            scoreP1 = 0;
            scoreP2 = 0;
            hideImages();
            lblShowImages.Text = "5";
            setRandomImages();
            timerShowImages.Start();
        }

        /// <summary>
        /// Image verbergen
        /// </summary>
        private void hideImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Image = Properties.Resources.CoverG;
            }
        }

        /// <summary>
        /// Als er een vrij slot is zoek dan nieuw image
        /// </summary>
        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = random.Next(0, PictureBoxes.Count());
            } while (PictureBoxes[num].Tag != null);
            return PictureBoxes[num];
        }

        /// <summary>
        /// Random image setten op vrij slot
        /// </summary>
        private void setRandomImages()
        {
            foreach (var image in Images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        /// <summary>
        /// Click van image op picturebox zodat image wordt gedraaid
        /// Als geen paar hebt dan image weer verbergen
        /// Als ze gelijk zijn verwijder dan de image van het speelveld
        /// </summary>
        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                if (this.turn == 0)
                {
                    scoreP1++;
                    lblScoreP1.Text = naamP1 + ": " + scoreP1;
                }
                else
                {
                    scoreP2++;
                    lblScoreP2.Text = naamP2 + ": " + scoreP2;
                }
                hideImages();
            }
            else
            {
                switchTurns();
                allowClick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            if (PictureBoxes.Any(p => p.Visible)) return;
            String winPlayer = "";
            if (scoreP1 > scoreP2)
            {
                winPlayer = naamP1;
                WinningScore = scoreP1;
            }
            else
            {
                winPlayer = naamP2;
                WinningScore = scoreP2;
            }

            MessageBox.Show("Gefeliciteerd " + winPlayer + " heeft gewonnen", " Je bent officeel een Meme Mister", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"../../Resources/scoreboardMulti.txt", true))
            {
                file.WriteLine(winPlayer+"   "+WinningScore+" points");
            }
            scoreGame scoreGame = new scoreGame();

            scoreGame.Show();
            
        }

        private void clickTimer_Tick(object sender, EventArgs e)
        {
            hideImages();
            allowClick = true;
            clickTimer.Stop();
        }
        private void switchTurns()
        {
            if (this.turn == 0)
            {
                turn = 1;
                lblTurn.Text = naamP1 + " is aan de beurt";
            }
            else
            {
                turn = 0;
                lblTurn.Text = naamP2 + " is aan de beurt";
            }
            

        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetImages();

        }
        /// <summary>
        /// do not touch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SaveGame_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// do not touch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_LoadGame_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }

}
