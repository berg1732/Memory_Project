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
                    Resources.CardG1;

                };
            }
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
