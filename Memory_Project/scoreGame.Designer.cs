namespace Memory_Project
{
    partial class scoreGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scoreGame));
            this.singleScoreBox = new System.Windows.Forms.RichTextBox();
            this.multiScoreBox = new System.Windows.Forms.RichTextBox();
            this.labelSingleScore = new System.Windows.Forms.Label();
            this.labelMultiScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singleScoreBox
            // 
            this.singleScoreBox.Location = new System.Drawing.Point(11, 51);
            this.singleScoreBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.singleScoreBox.Name = "singleScoreBox";
            this.singleScoreBox.Size = new System.Drawing.Size(150, 222);
            this.singleScoreBox.TabIndex = 0;
            this.singleScoreBox.Text = "";
            // 
            // multiScoreBox
            // 
            this.multiScoreBox.Location = new System.Drawing.Point(233, 50);
            this.multiScoreBox.Name = "multiScoreBox";
            this.multiScoreBox.Size = new System.Drawing.Size(150, 222);
            this.multiScoreBox.TabIndex = 1;
            this.multiScoreBox.Text = "";
            // 
            // labelSingleScore
            // 
            this.labelSingleScore.AutoSize = true;
            this.labelSingleScore.Location = new System.Drawing.Point(8, 34);
            this.labelSingleScore.Name = "labelSingleScore";
            this.labelSingleScore.Size = new System.Drawing.Size(117, 13);
            this.labelSingleScore.TabIndex = 2;
            this.labelSingleScore.Text = "Singleplayer HighScore";
            // 
            // labelMultiScore
            // 
            this.labelMultiScore.AutoSize = true;
            this.labelMultiScore.Location = new System.Drawing.Point(230, 34);
            this.labelMultiScore.Name = "labelMultiScore";
            this.labelMultiScore.Size = new System.Drawing.Size(110, 13);
            this.labelMultiScore.TabIndex = 3;
            this.labelMultiScore.Text = "Multiplayer HighScore";
            // 
            // scoreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 284);
            this.Controls.Add(this.labelMultiScore);
            this.Controls.Add(this.labelSingleScore);
            this.Controls.Add(this.multiScoreBox);
            this.Controls.Add(this.singleScoreBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "scoreGame";
            this.Text = "Leaderboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox singleScoreBox;
        private System.Windows.Forms.RichTextBox multiScoreBox;
        private System.Windows.Forms.Label labelSingleScore;
        private System.Windows.Forms.Label labelMultiScore;
    }
}