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
    /// Formulier voor het speelveld
    /// </summary>
    public partial class Game : Form
    {
        private readonly Timer timer1= new Timer();
        private readonly Timer timer2 = new Timer();
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
        private void GameWindow_Load(object sender, EventArgs e)
        {
            foreach (PictureBox picture in Cardsholder.Images)
            {
                picture.Enabled = false;
            }
            timer1.Start();
            timer2.Start();

            //All pictureboxes -> pictures 
            #region Pictures
            Card1.Image = Properties.Resources.CardG1;
            Card2.Image = Properties.Resources.CardG1;
            Card3.Image = Properties.Resources.CardG2;
            Card4.Image = Properties.Resources.CardG2;
            Card5.Image = Properties.Resources.CardG3;
            Card6.Image = Properties.Resources.CardG3;
            Card7.Image = Properties.Resources.CardG4;
            Card8.Image = Properties.Resources.CardG4;
            Card9.Image = Properties.Resources.CardG5;
            Card10.Image = Properties.Resources.CardG5;
            Card11.Image = Properties.Resources.CardG6;
            Card12.Image = Properties.Resources.CardG6;
            Card13.Image = Properties.Resources.CardG7;
            Card14.Image = Properties.Resources.CardG7;
            Card15.Image = Properties.Resources.CardG8;
            Card16.Image = Properties.Resources.CardG8;

            #endregion
        }


        public Game()
        {
            InitializeComponent();
        }
       
        private void Game_Load(object sender, EventArgs e)
        {

        }
    }

}
