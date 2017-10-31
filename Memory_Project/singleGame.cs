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
using System.IO;

namespace Memory_Project
{
    public partial class singleGame : Form
    {
        string naam = "naam";
        PictureBox[] pictureBox = new PictureBox[50];
        static string path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/Achtergrondgeluid.wav");
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(path);
        private bool allowClick = true;
        private PictureBox firstGuess;
        private readonly Random random = new Random();
        private readonly Timer clickTimer = new Timer();
        int ticks = 0;
        private startGame StartGame;

        /// <summary>
        /// constructor voor het maaken van het speelveld
        /// </summary>
        public singleGame(startGame ParentForm)
        {
            InitializeComponent();
            this.StartGame = ParentForm;

            naam = Interaction.InputBox("Vul je naam in", "Vul je naam in", "speler 1", -1, -1);

            setPictureBoxes();
            setRandomImages();

            lblShowImages.Text = "5";
            timerShowImages.Start();

            clickTimer.Interval = 1000;
            clickTimer.Tick += clickTimer_Tick;

            //sp.PlayLooping();
            sp.Play();

        }
        /// <summary>
        /// maakt de pictureboxes aan
        /// </summary>
        private void setPictureBoxes()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/");
            int i = 0;
            while (i <= 16 - 1)

            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Name = "pictureBox" + i;
                pictureBox[i].Size = new Size(100, 150);
                pictureBox[i].Show();
                pictureBox[i].Tag = null;

                if (StartGame != null)
                {
                    bool gameDeckCheck = StartGame.deckSettingGame();
                    bool musicDeckCheck = StartGame.deckSettingMusic();
                    bool memeDeckCheck = StartGame.deckSettingMeme();
                    if (gameDeckCheck == true)
                    {
                        pictureBox[i].ImageLocation = (path + "CoverG" + ".jpg");
                    }
                    else if (musicDeckCheck == true)
                    {
                        pictureBox[i].ImageLocation = (path + "CoverM" + ".jpg");
                    }
                    else if (memeDeckCheck == true)
                    {
                        pictureBox[i].ImageLocation = (path + "CoverMm" + ".jpg");
                    }
                    else
                    {
                        pictureBox[i].ImageLocation = (path + "CoverMm" + ".jpg");
                    }
                }
                else
                {

                    pictureBox[i].ImageLocation = (path + "CoverMm" + ".jpg");
                }

                pictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox[i].MouseClick += new MouseEventHandler(clickImage);
                i++;
            }
            i = 0;
            for (int ix = 0; ix < 4; ix++)
            {
                for (int iy = 0; iy < 4; iy++)
                {
                    pictureBox[i].Location = new Point(40 + ix * 100, 50 + iy * 150);
                    i++;
                }
            }
            Controls.AddRange(pictureBox);
        }

        /// <summary>
        /// Methode voor algmeen Array PictureBox
        /// </summary>
        private PictureBox[] PictureBoxes
        {
            get { return this.Controls.OfType<PictureBox>().ToArray(); }
        }

        /// <summary>
        /// Images uit de resources map halen
        /// </summary>
        private IEnumerable<Image> Images
        {
            get
            {
                bool gameDeckCheck = StartGame.deckSettingGame();
                bool musicDeckCheck = StartGame.deckSettingMusic();
                bool memeDeckCheck = StartGame.deckSettingMeme();
                if (gameDeckCheck == true)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/deck");
                    var result = new List<Image>();
                    var list = Directory.GetFiles(path, "*.jpg");
                    foreach (var item in list)
                    {
                        var img = Image.FromFile(item);
                        img.Tag = item;
                        result.Add(img);
                    }
                    return result;
                }
                else if (musicDeckCheck == true)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/deckm");
                    var result = new List<Image>();
                    var list = Directory.GetFiles(path, "*.jpg");
                    foreach (var item in list)
                    {
                        var img = Image.FromFile(item);
                        img.Tag = item;
                        result.Add(img);
                    }
                    return result;
                }
                else if (memeDeckCheck == true)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/deckMm");
                    var result = new List<Image>();
                    var list = Directory.GetFiles(path, "*.jpg");
                    foreach (var item in list)
                    {
                        var img = Image.FromFile(item);
                        img.Tag = item;
                        result.Add(img);
                    }
                    return result;
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/deckMm");
                    var result = new List<Image>();
                    var list = Directory.GetFiles(path, "*.jpg");
                    foreach (var item in list)
                    {
                        var img = Image.FromFile(item);
                        img.Tag = item;
                        result.Add(img);
                    }
                    return result;
                }
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

        /// <summary>
        /// show images Voor elke pic.image show image.tag
        /// </summary>
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
        /// Image verbergen via Cover+ deckkeuze
        /// </summary>
        private void hideImages()
        {
    
            bool gameDeckCheck = StartGame.deckSettingGame();
            bool musicDeckCheck = StartGame.deckSettingMusic();
            bool memeDeckCheck = StartGame.deckSettingMeme();

            if (gameDeckCheck == true)
            {
                foreach (var pic in PictureBoxes)
                {
                    pic.Image = Properties.Resources.CoverG;
                }
            }
            else if (musicDeckCheck == true)
            {
                foreach (var pic in PictureBoxes)
                {
                    pic.Image = Properties.Resources.CoverM;
                }
            }
            else if (memeDeckCheck == true)
            {
                foreach (var pic in PictureBoxes)
                {
                    pic.Image = Properties.Resources.CoverMm;
                }
            }
            else
            {
                foreach (var pic in PictureBoxes)
                {
                    pic.Image = Properties.Resources.CoverMm;
                }
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
                for (int i = 0; i < 2; i++)
                {
                    var box = PictureBoxes.FirstOrDefault(x => x.Tag == null);
                    if (box == null)
                    {
                        Console.WriteLine("box is null");
                    }
                    else
                    {
                        box.Image = image;
                    }

                }
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
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"../../Resources/scoreboard.txt", true))
            {
                file.WriteLine(naam + "  :  " + lblTime.Text + " time");
            }
            resetImages();
        }

        /// <summary>
        /// verbergt afbeeldingen en zorgt dat allow click op true word gezet
        /// </summary>
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

        /// <summary>
        /// Reset het spelbord
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetImages();
        }

        /// <summary>
        /// stopt de muziek
        /// </summary>
        private void singleGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp.Stop();
        }
    }
}
