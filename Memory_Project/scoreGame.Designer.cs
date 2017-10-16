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
            this.richBoxScore = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richBoxScore
            // 
            this.richBoxScore.Location = new System.Drawing.Point(12, 12);
            this.richBoxScore.Name = "richBoxScore";
            this.richBoxScore.Size = new System.Drawing.Size(223, 339);
            this.richBoxScore.TabIndex = 0;
            this.richBoxScore.Text = "";
            // 
            // scoreGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 437);
            this.Controls.Add(this.richBoxScore);
            this.Name = "scoreGame";
            this.Text = "scoreGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richBoxScore;
    }
}