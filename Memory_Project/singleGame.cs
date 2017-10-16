﻿using System;
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
    public partial class singleGame : Form
    {
        private bool allowClick = true;
        private PictureBox firstGuess;
        private readonly Random random = new Random();
        private readonly Timer clickTimer = new Timer();
        int ticks = 45;
        public singleGame()
        {
            InitializeComponent();
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
            int timer = Convert.ToInt32(lblShowImages.Text);
            timer = timer - 1;
            lblShowImages.Text = Convert.ToString(timer);
            if (timer == 0)
            {
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
                ticks--;
                if (ticks == -1)
                {
                    timer.Stop();
                    MessageBox.Show("Tijd is afgelopen.", "Helaas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetImages();
                }
                var time = TimeSpan.FromSeconds(ticks);
                lblTime.Text = "00:" + time.ToString("ss");
            };

        }

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
            hideImages();
            setRandomImages();
            ticks = 45;
            timer.Start();
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
                    //scoreCounter.Text = Convert.ToString(Convert.ToInt32(scoreCounter.Text) + 1);
                }
                hideImages();
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
                //scoreCounter.Text = Convert.ToString(Convert.ToInt32(scoreCounter.Text) - 1);
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

    }
}