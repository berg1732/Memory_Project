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
    public partial class tes : Form
    {
        PictureBox[] pictureBox = new PictureBox[50];

        public tes()
        {
            InitializeComponent();
        }

        private void tes_Load(object sender, EventArgs e)
        {

        }
        private void setPictureBoxes()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "../../Resources/");
            int i = 0;
            while (i <= 16 - 1)

            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Location = new Point(50, 50);

                pictureBox[i].Name = "pictureBox" + i;
                pictureBox[i].Size = new Size(100, 150);
                pictureBox[i].Show();
                pictureBox[i].Tag = null;
                pictureBox[i].ImageLocation = (path + "CoverG" + ".jpg");
                pictureBox[i].Show();

                //flowLayoutPanel1.Controls.Add(pictureBox[i]);
                //flowLayoutPanel1.Show();
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setPictureBoxes();
        }
    }
}
