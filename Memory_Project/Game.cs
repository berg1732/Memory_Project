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
using System.IO;
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
        PictureBox[] pictureBox = new PictureBox[50];
        string naamP1 = "Speler 1";
        string naamP2 = "Speler 2";
        int scoreP1 = 0;
        int scoreP2 = 0;
        int WinningScore;
        private startGame StartGame;
        /// <summary>
        /// Constructor waarin het Parrent Form meegegeven word
        /// </summary>
        public Game(startGame ParentForm)
        {

            InitializeComponent();
            this.StartGame = ParentForm;

            naamP1 = Interaction.InputBox("Vul je naam in", "Vul je naam in", "Speler 1", -1, -1);
            naamP2 = Interaction.InputBox("Vul je naam in", "Vul je naam in", "Speler 2", -1, -1);
            lblScoreP1.Text = naamP1 + ": " + scoreP1;
            lblScoreP2.Text = naamP2 + ": " + scoreP2;
            lblTurn.Text = naamP1 + " is aan de beurt";
            lblShowImages.Text = "5";
            setPictureBoxes();
            setRandomImages();
            timerShowImages.Start();
            clickTimer.Interval = 1000;
            clickTimer.Tick += clickTimer_Tick;
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
        private  IEnumerable<Image> Images
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
                hideImages();
            }
            else
            {
                showImages();
            }
        }

        /// <summary>
        /// Show images.
        /// Voor elke pic.image show image.tag
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

            // Score reset
            scoreP1 = 0;
            scoreP2 = 0;
            lblScoreP1.Text = naamP1 + ": " + scoreP1;
            lblScoreP2.Text = naamP2 + ": " + scoreP2;

            // Speler aan de beurt reset
            turn = 0;
            lblTurn.Text = naamP1 + " is aan de beurt";

            // Images verbergen
            hideImages();

            // Flash timer reset
            lblShowImages.Text = "5";

            // Images random setten
            setRandomImages();

            // Flash timer starten
            timerShowImages.Start();
        }

        /// <summary>
        /// Image verbergen
        /// </summary>
        private void hideImages()
        {

            bool gameDeckCheck = StartGame.deckSettingGame();
            bool musicDeckCheck = StartGame.deckSettingMusic();
            bool memeDeckCheck = StartGame.deckSettingMeme();

            if(gameDeckCheck == true)
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
        /// Random image setten op vrij slot
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
            string picloc = pic.ImageLocation;
            string[] picloca = picloc.Split('/');
            if (picloca[picloca.Length -1 ][1] == 'o')
            {
                if (pic.Image == firstGuess.Image && pic != firstGuess)
                {
                    pic.Visible = firstGuess.Visible = false;
                    pic.Tag = null;
                    firstGuess.Tag = null;
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
                    if (turn > 0)
                    {
                        turn--;
                    }
                    else
                    {
                        turn++;
                    }
                    switchTurns();
                    allowClick = false;
                    clickTimer.Start();
                }
            }
            else if (pic.ImageLocation == firstGuess.ImageLocation && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                pic.Tag = null;
                firstGuess.Tag = null;
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
                if (turn > 0)
                {
                    turn--;
                }
                else
                {
                    turn++;
                }
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

            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/VICTORY.wav");
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(path);
            sp.Play();

            MessageBox.Show("Gefeliciteerd " + winPlayer + " heeft gewonnen", " Je bent officeel een Meme Mister", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (StreamWriter file =
            new StreamWriter(Directory.GetCurrentDirectory() + "../../../Resources/scoreboardMulti.txt", true))
            {
                file.WriteLine(winPlayer+":   "+WinningScore+" points");
            }
            scoreGame scoreGame = new scoreGame();

            scoreGame.Show();
            
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
        /// wisselt wie er aan de beurt is
        /// </summary>
        private void switchTurns()
        {
            if (this.turn == 0)
            {
                turn = 0;
                lblTurn.Text = naamP1 + " is aan de beurt";
            }
            else
            {
                turn = 1;
                lblTurn.Text = naamP2 + " is aan de beurt";
            }


        }

        /// <summary>
        /// Reset het speelveld
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetImages();

        }
        /// <summary>
        /// Save pictureboxes places + score + name + beurt
        /// </summary>
        private void button_SaveGame_Click(object sender, EventArgs e)
        {
            
            DateTime time = DateTime.Now;   // Tijd nu

            using (StreamWriter file =
                      new StreamWriter(@"../../Resources/savefiles/" + "SaveGame-" + time.ToString("dd_MM_yyyy_HH_mm") + ".txt", true)) // File aanmaken

            {

                foreach (var picBox in PictureBoxes)    // Voor elke Picturebox doe...
                {
                    if (picBox.Tag != null)
                    {
                        Bitmap bitmap = (Bitmap)picBox.Tag; // Pictureboxes ophalen
                        file.WriteLine(bitmap.Tag + "|" + picBox.Location);         // Pictureboxes saven
                    }

                }
                file.WriteLine("asdfghjklqwertyuiop");
                file.WriteLine(naamP1.ToString());      // Naam speler 1
                file.WriteLine(scoreP1.ToString());     // Score speler 1
                file.WriteLine(naamP2.ToString());      // Naam speler 2
                file.WriteLine(scoreP2.ToString());     // Score speler 2
                file.WriteLine(lblTurn.ToString());     // Beurt welke speler
            }
        }
        /// <summary>
        /// Button load game
        /// Voor elke line(1t/m16) set picturebox.ImageLocation
        /// Laaste vijf lines voor speler + score + beurt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_LoadGame_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < PictureBoxes.Count(); i++)
            {
                PictureBoxes[i] = null;
            }
            Stream myStream = null;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/savefiles/");

            OpenFileDialog openFile= new OpenFileDialog();  // Nieuwe fileDialog venster
            openFile.InitialDirectory = @"c:\\"+path;       // Pad naar savFiles
            openFile.Filter = "Text files (*.txt)|*.txt";   // Filteren op .txt files
            openFile.FilterIndex = 2;                       // Twee index filters
            openFile.RestoreDirectory = true; 

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    if ((myStream = openFile.OpenFile()) != null)
                    {
                        using (StreamReader reader = new StreamReader(myStream))
                        {
                            
                            string line;
                            string[] sline;
                            string[] pline;
                            line = reader.ReadLine();   // Lees de lines in bestand
                            int c = 0;
                            while (line != "asdfghjklqwertyuiop") // Voor elke Picturebox doe dan..
                            {
                                sline = line.Split('|');
                                pline = sline[1].Split(',');
                                pline[1]=pline[1].Replace("}", string.Empty);
                                PictureBoxes[c].ImageLocation = sline[0];   // Zet line naar picturebox.imageLocation
                                int x = Int32.Parse(pline[0].Split('=')[1]);
                                int y = Int32.Parse(pline[1].Split('=')[1]);
                                PictureBoxes[c].Tag = Image.FromFile(sline[0]);
                                PictureBoxes[c].Image.Tag = sline[0];
                                PictureBoxes[c].Location = new Point(x, y);
                                line = reader.ReadLine();   // Lees de lines in bestand
                                c++;
                                //showImages(); //<- is om te testen of loading picturebox images werkt
                            }
                        }
                    }
                    List<string> text = File.ReadLines(openFile.FileName).Reverse().Take(5).ToList();
                    naamP2 = text[2];
                    scoreP2 = Int32.Parse(text[1]);
                    scoreP1 = Int32.Parse(text[3]);
                    naamP1 = text[4];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + error.Message);
                }
            }
        }
    }

}
