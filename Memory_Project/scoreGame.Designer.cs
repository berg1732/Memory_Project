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
            this.singleScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.singleScoreBox.Location = new System.Drawing.Point(15, 59);
            this.singleScoreBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singleScoreBox.Name = "singleScoreBox";
            this.singleScoreBox.ReadOnly = true;
            this.singleScoreBox.Size = new System.Drawing.Size(199, 256);
            this.singleScoreBox.TabIndex = 0;
            this.singleScoreBox.Text = "";
            this.singleScoreBox.UseWaitCursor = true;
            // 
            // multiScoreBox
            // 
            this.multiScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiScoreBox.Location = new System.Drawing.Point(311, 58);
            this.multiScoreBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.multiScoreBox.Name = "multiScoreBox";
            this.multiScoreBox.ReadOnly = true;
            this.multiScoreBox.Size = new System.Drawing.Size(199, 256);
            this.multiScoreBox.TabIndex = 1;
            this.multiScoreBox.Text = "";
            this.multiScoreBox.UseWaitCursor = true;
            // 
            // labelSingleScore
            // 
            this.labelSingleScore.AutoSize = true;
            this.labelSingleScore.Location = new System.Drawing.Point(11, 39);
            this.labelSingleScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSingleScore.Name = "labelSingleScore";
            this.labelSingleScore.Size = new System.Drawing.Size(161, 15);
            this.labelSingleScore.TabIndex = 2;
            this.labelSingleScore.Text = "Singleplayer HighScore";
            this.labelSingleScore.UseWaitCursor = true;
            // 
            // labelMultiScore
            // 
            this.labelMultiScore.AutoSize = true;
            this.labelMultiScore.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelMultiScore.Location = new System.Drawing.Point(307, 39);
            this.labelMultiScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMultiScore.Name = "labelMultiScore";
            this.labelMultiScore.Size = new System.Drawing.Size(152, 15);
            this.labelMultiScore.TabIndex = 3;
            this.labelMultiScore.Text = "Multiplayer HighScore";
            this.labelMultiScore.UseWaitCursor = true;
            // 
            // scoreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(527, 328);
            this.Controls.Add(this.labelMultiScore);
            this.Controls.Add(this.labelSingleScore);
            this.Controls.Add(this.multiScoreBox);
            this.Controls.Add(this.singleScoreBox);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "scoreGame";
            this.Text = "LeaderBoard";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.scoreGame_Load);
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