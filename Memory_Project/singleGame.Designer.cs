namespace Memory_Project
{
    partial class singleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singleGame));
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblShowImages = new System.Windows.Forms.Label();
            this.timerShowImages = new System.Windows.Forms.Timer(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(611, 27);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(55, 24);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "00:00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // lblShowImages
            // 
            this.lblShowImages.AutoSize = true;
            this.lblShowImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowImages.Location = new System.Drawing.Point(642, 49);
            this.lblShowImages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowImages.Name = "lblShowImages";
            this.lblShowImages.Size = new System.Drawing.Size(20, 24);
            this.lblShowImages.TabIndex = 17;
            this.lblShowImages.Text = "0";
            // 
            // timerShowImages
            // 
            this.timerShowImages.Interval = 1000;
            this.timerShowImages.Tick += new System.EventHandler(this.timerShowImages_Tick);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Black;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(446, 51);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReset.Size = new System.Drawing.Size(86, 42);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Memory_Project.Properties.Resources.Logovanons;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(468, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 140);
            this.panel1.TabIndex = 19;
            // 
            // singleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(672, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblShowImages);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "singleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.singleGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowImages;
        private System.Windows.Forms.Timer timerShowImages;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
    }
}