namespace Memory_Project
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Cardsholder = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblShowImages = new System.Windows.Forms.Label();
            this.timerShowImages = new System.Windows.Forms.Timer(this.components);
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.Card9 = new System.Windows.Forms.PictureBox();
            this.Card10 = new System.Windows.Forms.PictureBox();
            this.Card11 = new System.Windows.Forms.PictureBox();
            this.Card12 = new System.Windows.Forms.PictureBox();
            this.Card13 = new System.Windows.Forms.PictureBox();
            this.Card14 = new System.Windows.Forms.PictureBox();
            this.Card15 = new System.Windows.Forms.PictureBox();
            this.Card16 = new System.Windows.Forms.PictureBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblScoreP1 = new System.Windows.Forms.Label();
            this.lblScoreP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card16)).BeginInit();
            this.SuspendLayout();
            // 
            // Cardsholder
            // 
            this.Cardsholder.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Cardsholder.ImageSize = new System.Drawing.Size(16, 16);
            this.Cardsholder.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // lblShowImages
            // 
            this.lblShowImages.AutoSize = true;
            this.lblShowImages.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowImages.Location = new System.Drawing.Point(645, 182);
            this.lblShowImages.Name = "lblShowImages";
            this.lblShowImages.Size = new System.Drawing.Size(23, 25);
            this.lblShowImages.TabIndex = 18;
            this.lblShowImages.Text = "0";
            // 
            // timerShowImages
            // 
            this.timerShowImages.Interval = 1000;
            this.timerShowImages.Tick += new System.EventHandler(this.timerShowImages_Tick);
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(25, 35);
            this.Card1.Margin = new System.Windows.Forms.Padding(4);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(133, 185);
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            this.Card1.Click += new System.EventHandler(this.clickImage);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(168, 35);
            this.Card2.Margin = new System.Windows.Forms.Padding(4);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(133, 185);
            this.Card2.TabIndex = 1;
            this.Card2.TabStop = false;
            this.Card2.Click += new System.EventHandler(this.clickImage);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(308, 35);
            this.Card3.Margin = new System.Windows.Forms.Padding(4);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(133, 185);
            this.Card3.TabIndex = 2;
            this.Card3.TabStop = false;
            this.Card3.Click += new System.EventHandler(this.clickImage);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(449, 35);
            this.Card4.Margin = new System.Windows.Forms.Padding(4);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(133, 185);
            this.Card4.TabIndex = 3;
            this.Card4.TabStop = false;
            this.Card4.Click += new System.EventHandler(this.clickImage);
            // 
            // Card5
            // 
            this.Card5.Location = new System.Drawing.Point(25, 227);
            this.Card5.Margin = new System.Windows.Forms.Padding(4);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(133, 185);
            this.Card5.TabIndex = 4;
            this.Card5.TabStop = false;
            this.Card5.Click += new System.EventHandler(this.clickImage);
            // 
            // Card6
            // 
            this.Card6.Location = new System.Drawing.Point(166, 227);
            this.Card6.Margin = new System.Windows.Forms.Padding(4);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(133, 185);
            this.Card6.TabIndex = 5;
            this.Card6.TabStop = false;
            this.Card6.Click += new System.EventHandler(this.clickImage);
            // 
            // Card7
            // 
            this.Card7.Location = new System.Drawing.Point(308, 227);
            this.Card7.Margin = new System.Windows.Forms.Padding(4);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(133, 185);
            this.Card7.TabIndex = 6;
            this.Card7.TabStop = false;
            this.Card7.Click += new System.EventHandler(this.clickImage);
            // 
            // Card8
            // 
            this.Card8.Location = new System.Drawing.Point(449, 227);
            this.Card8.Margin = new System.Windows.Forms.Padding(4);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(133, 185);
            this.Card8.TabIndex = 7;
            this.Card8.TabStop = false;
            this.Card8.Click += new System.EventHandler(this.clickImage);
            // 
            // Card9
            // 
            this.Card9.Location = new System.Drawing.Point(25, 419);
            this.Card9.Margin = new System.Windows.Forms.Padding(4);
            this.Card9.Name = "Card9";
            this.Card9.Size = new System.Drawing.Size(133, 185);
            this.Card9.TabIndex = 8;
            this.Card9.TabStop = false;
            this.Card9.Click += new System.EventHandler(this.clickImage);
            // 
            // Card10
            // 
            this.Card10.Location = new System.Drawing.Point(166, 419);
            this.Card10.Margin = new System.Windows.Forms.Padding(4);
            this.Card10.Name = "Card10";
            this.Card10.Size = new System.Drawing.Size(133, 185);
            this.Card10.TabIndex = 9;
            this.Card10.TabStop = false;
            this.Card10.Click += new System.EventHandler(this.clickImage);
            // 
            // Card11
            // 
            this.Card11.Location = new System.Drawing.Point(308, 419);
            this.Card11.Margin = new System.Windows.Forms.Padding(4);
            this.Card11.Name = "Card11";
            this.Card11.Size = new System.Drawing.Size(133, 185);
            this.Card11.TabIndex = 10;
            this.Card11.TabStop = false;
            this.Card11.Click += new System.EventHandler(this.clickImage);
            // 
            // Card12
            // 
            this.Card12.Location = new System.Drawing.Point(449, 419);
            this.Card12.Margin = new System.Windows.Forms.Padding(4);
            this.Card12.Name = "Card12";
            this.Card12.Size = new System.Drawing.Size(133, 185);
            this.Card12.TabIndex = 11;
            this.Card12.TabStop = false;
            this.Card12.Click += new System.EventHandler(this.clickImage);
            // 
            // Card13
            // 
            this.Card13.Location = new System.Drawing.Point(25, 612);
            this.Card13.Margin = new System.Windows.Forms.Padding(4);
            this.Card13.Name = "Card13";
            this.Card13.Size = new System.Drawing.Size(133, 185);
            this.Card13.TabIndex = 12;
            this.Card13.TabStop = false;
            this.Card13.Click += new System.EventHandler(this.clickImage);
            // 
            // Card14
            // 
            this.Card14.Location = new System.Drawing.Point(166, 611);
            this.Card14.Margin = new System.Windows.Forms.Padding(4);
            this.Card14.Name = "Card14";
            this.Card14.Size = new System.Drawing.Size(133, 185);
            this.Card14.TabIndex = 13;
            this.Card14.TabStop = false;
            this.Card14.Click += new System.EventHandler(this.clickImage);
            // 
            // Card15
            // 
            this.Card15.Location = new System.Drawing.Point(308, 611);
            this.Card15.Margin = new System.Windows.Forms.Padding(4);
            this.Card15.Name = "Card15";
            this.Card15.Size = new System.Drawing.Size(133, 185);
            this.Card15.TabIndex = 14;
            this.Card15.TabStop = false;
            this.Card15.Click += new System.EventHandler(this.clickImage);
            // 
            // Card16
            // 
            this.Card16.Location = new System.Drawing.Point(449, 611);
            this.Card16.Margin = new System.Windows.Forms.Padding(4);
            this.Card16.Name = "Card16";
            this.Card16.Size = new System.Drawing.Size(133, 185);
            this.Card16.TabIndex = 15;
            this.Card16.TabStop = false;
            this.Card16.Click += new System.EventHandler(this.clickImage);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(613, 35);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(158, 17);
            this.lblTurn.TabIndex = 19;
            this.lblTurn.Text = "speler 1 is aan de beurt";
            // 
            // lblScoreP1
            // 
            this.lblScoreP1.AutoSize = true;
            this.lblScoreP1.Location = new System.Drawing.Point(616, 72);
            this.lblScoreP1.Name = "lblScoreP1";
            this.lblScoreP1.Size = new System.Drawing.Size(75, 17);
            this.lblScoreP1.TabIndex = 20;
            this.lblScoreP1.Text = "speler 1: 0";
            // 
            // lblScoreP2
            // 
            this.lblScoreP2.AutoSize = true;
            this.lblScoreP2.Location = new System.Drawing.Point(616, 103);
            this.lblScoreP2.Name = "lblScoreP2";
            this.lblScoreP2.Size = new System.Drawing.Size(75, 17);
            this.lblScoreP2.TabIndex = 21;
            this.lblScoreP2.Text = "speler 2: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 868);
            this.Controls.Add(this.lblScoreP2);
            this.Controls.Add(this.lblScoreP1);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.Card16);
            this.Controls.Add(this.lblShowImages);
            this.Controls.Add(this.Card15);
            this.Controls.Add(this.Card14);
            this.Controls.Add(this.Card12);
            this.Controls.Add(this.Card13);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card11);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card10);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card9);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card8);
            this.Controls.Add(this.Card6);
            this.Controls.Add(this.Card7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList Cardsholder;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblShowImages;
        private System.Windows.Forms.Timer timerShowImages;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.PictureBox Card9;
        private System.Windows.Forms.PictureBox Card10;
        private System.Windows.Forms.PictureBox Card11;
        private System.Windows.Forms.PictureBox Card12;
        private System.Windows.Forms.PictureBox Card13;
        private System.Windows.Forms.PictureBox Card14;
        private System.Windows.Forms.PictureBox Card15;
        private System.Windows.Forms.PictureBox Card16;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblScoreP1;
        private System.Windows.Forms.Label lblScoreP2;
    }
}