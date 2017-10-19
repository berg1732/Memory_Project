using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Project
{
    public partial class singleGame : Form
    {
        string naam = "naam";

        private bool allowClick = true;
        private PictureBox firstGuess;
        private readonly Random random = new Random();
        private readonly Timer clickTimer = new Timer();
        int ticks = 0;
        public singleGame()
        {
            InitializeComponent();
            naam = Interaction.InputBox("Vul je naam in", "Vul je naam in", "speler 1", -1, -1);

            setRandomImages();


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
                startGameTimer();
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
        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                ticks++;
                if (ticks == 180)
                {
                    timer.Stop();
                    MessageBox.Show("Zolang al mee bezig", "Restarten?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetImages();
                }
                var time = TimeSpan.FromSeconds(ticks);
                lblTime.Text = "00:" + time.ToString("ss");
            };

        }

        /// <summary>
        /// Reset Images. Gekoppeld met btnReset_Click()
        /// </summary>
        private void resetImages()
        {
            foreach (var pic in PictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            timer.Stop();
            resetTimer();
            lblShowImages.Text = "5";
            setRandomImages();
            timerShowImages.Start();
           
            
        }

        /// <summary>
        /// Image verbergen via CoverG
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
        /// Random image zetten op vrij picturebox plaats
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
                hideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }
            firstGuess = null;
            if (PictureBoxes.Any(p => p.Visible)) return;
            timer.Stop();
            MessageBox.Show("Gefeliciteerd.", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetImages();
        }

        private void clickTimer_Tick(object sender, EventArgs e)
        {
            hideImages();
            allowClick = true;
            clickTimer.Stop();
        }

        /// <summary>
        /// Timer resetten: ticks naar 0 seconden om lblTime.Text naar 00:00 te krijgen
        /// -1 tick om weer de op 1 seconde tick te komen
        /// </summary>
        private void resetTimer()
        {
            ticks = 0;
            var time = TimeSpan.FromSeconds(ticks);
            lblTime.Text = "00:" + time.ToString("ss");

            timer.Tick += delegate
            {
                ticks = ticks -1;
            };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetImages();
        }

        private void singleGame_Load(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
