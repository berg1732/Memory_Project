﻿namespace Memory_Project
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
            this.lblShowImages = new System.Windows.Forms.Label();
            this.timerShowImages = new System.Windows.Forms.Timer(this.components);
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblScoreP1 = new System.Windows.Forms.Label();
            this.lblScoreP2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.button_SaveGame = new System.Windows.Forms.Button();
            this.button_LoadGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cardsholder
            // 
            this.Cardsholder.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Cardsholder.ImageSize = new System.Drawing.Size(16, 16);
            this.Cardsholder.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblShowImages
            // 
            this.lblShowImages.AutoSize = true;
            this.lblShowImages.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowImages.Location = new System.Drawing.Point(699, 249);
            this.lblShowImages.Name = "lblShowImages";
            this.lblShowImages.Size = new System.Drawing.Size(26, 30);
            this.lblShowImages.TabIndex = 18;
            this.lblShowImages.Text = "0";
            // 
            // timerShowImages
            // 
            this.timerShowImages.Interval = 1000;
            this.timerShowImages.Tick += new System.EventHandler(this.timerShowImages_Tick);
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(663, 65);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(174, 20);
            this.lblTurn.TabIndex = 19;
            this.lblTurn.Text = "speler 1 is aan de beurt";
            // 
            // lblScoreP1
            // 
            this.lblScoreP1.AutoSize = true;
            this.lblScoreP1.Location = new System.Drawing.Point(666, 111);
            this.lblScoreP1.Name = "lblScoreP1";
            this.lblScoreP1.Size = new System.Drawing.Size(82, 20);
            this.lblScoreP1.TabIndex = 20;
            this.lblScoreP1.Text = "speler 1: 0";
            // 
            // lblScoreP2
            // 
            this.lblScoreP2.AutoSize = true;
            this.lblScoreP2.Location = new System.Drawing.Point(666, 151);
            this.lblScoreP2.Name = "lblScoreP2";
            this.lblScoreP2.Size = new System.Drawing.Size(82, 20);
            this.lblScoreP2.TabIndex = 21;
            this.lblScoreP2.Text = "speler 2: 0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(681, 314);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 45);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Restart";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // button_SaveGame
            // 
            this.button_SaveGame.Location = new System.Drawing.Point(681, 389);
            this.button_SaveGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SaveGame.Name = "button_SaveGame";
            this.button_SaveGame.Size = new System.Drawing.Size(127, 45);
            this.button_SaveGame.TabIndex = 23;
            this.button_SaveGame.Text = "Save Game";
            this.button_SaveGame.UseVisualStyleBackColor = true;
            this.button_SaveGame.Click += new System.EventHandler(this.button_SaveGame_Click);
            // 
            // button_LoadGame
            // 
            this.button_LoadGame.Location = new System.Drawing.Point(681, 469);
            this.button_LoadGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_LoadGame.Name = "button_LoadGame";
            this.button_LoadGame.Size = new System.Drawing.Size(127, 45);
            this.button_LoadGame.TabIndex = 24;
            this.button_LoadGame.Text = "Load Game";
            this.button_LoadGame.UseVisualStyleBackColor = true;
            this.button_LoadGame.Click += new System.EventHandler(this.button_LoadGame_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1102, 1038);
            this.Controls.Add(this.button_LoadGame);
            this.Controls.Add(this.button_SaveGame);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblScoreP2);
            this.Controls.Add(this.lblScoreP1);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblShowImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Game";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList Cardsholder;
        private System.Windows.Forms.Label lblShowImages;
        private System.Windows.Forms.Timer timerShowImages;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblScoreP1;
        private System.Windows.Forms.Label lblScoreP2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button_SaveGame;
        private System.Windows.Forms.Button button_LoadGame;
    }
}