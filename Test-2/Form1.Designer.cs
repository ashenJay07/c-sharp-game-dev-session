namespace Test_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            angryBird = new PictureBox();
            pipeDown = new PictureBox();
            pipeUp = new PictureBox();
            ground = new PictureBox();
            gameScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            gameOverLabel = new Label();
            piggy = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)angryBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piggy).BeginInit();
            SuspendLayout();
            // 
            // angryBird
            // 
            angryBird.Image = Properties.Resources.angry_bird;
            angryBird.Location = new Point(125, 123);
            angryBird.Name = "angryBird";
            angryBird.Size = new Size(96, 83);
            angryBird.SizeMode = PictureBoxSizeMode.StretchImage;
            angryBird.TabIndex = 0;
            angryBird.TabStop = false;
            // 
            // pipeDown
            // 
            pipeDown.Image = Properties.Resources.pipedown;
            pipeDown.Location = new Point(731, -17);
            pipeDown.Name = "pipeDown";
            pipeDown.Size = new Size(125, 161);
            pipeDown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeDown.TabIndex = 0;
            pipeDown.TabStop = false;
            // 
            // pipeUp
            // 
            pipeUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pipeUp.Image = Properties.Resources.pipe;
            pipeUp.Location = new Point(465, 395);
            pipeUp.Name = "pipeUp";
            pipeUp.Size = new Size(125, 208);
            pipeUp.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeUp.TabIndex = 0;
            pipeUp.TabStop = false;
            // 
            // ground
            // 
            ground.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-5, 549);
            ground.Name = "ground";
            ground.Size = new Size(1146, 87);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            // 
            // gameScore
            // 
            gameScore.AutoSize = true;
            gameScore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameScore.Location = new Point(12, 9);
            gameScore.Name = "gameScore";
            gameScore.Size = new Size(92, 41);
            gameScore.TabIndex = 1;
            gameScore.Text = "Score";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // gameOverLabel
            // 
            gameOverLabel.AutoSize = true;
            gameOverLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameOverLabel.ForeColor = Color.Red;
            gameOverLabel.Location = new Point(405, 235);
            gameOverLabel.Name = "gameOverLabel";
            gameOverLabel.Size = new Size(312, 62);
            gameOverLabel.TabIndex = 2;
            gameOverLabel.Text = "Game Over !!!";
            gameOverLabel.Visible = false;
            // 
            // piggy
            // 
            piggy.Image = Properties.Resources.piggy;
            piggy.Location = new Point(900, 113);
            piggy.Name = "piggy";
            piggy.Size = new Size(96, 83);
            piggy.SizeMode = PictureBoxSizeMode.StretchImage;
            piggy.TabIndex = 3;
            piggy.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1142, 633);
            Controls.Add(piggy);
            Controls.Add(gameOverLabel);
            Controls.Add(gameScore);
            Controls.Add(ground);
            Controls.Add(pipeDown);
            Controls.Add(angryBird);
            Controls.Add(pipeUp);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gameKeyDown;
            KeyUp += gameKeyUp;
            ((System.ComponentModel.ISupportInitialize)angryBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeUp).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)piggy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox angryBird;
        private PictureBox pipeDown;
        private PictureBox pipeUp;
        private PictureBox ground;
        private Label gameScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label gameOverLabel;
        private PictureBox piggy;
    }
}
