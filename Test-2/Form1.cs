namespace Test_2
{
    public partial class Form1 : Form
    {
        private int pipeSpeed = 8;
        private int gravity = 5;
        private int score = 0;
        private int speedFactor = 3;
        private int evaluationScore = 10;

        // Piggy Implementations
        private int currentY;
        private int coordinateFactor = 5;
        private int minY = 20;
        private int maxY = 450;


        public Form1()
        {
            InitializeComponent();

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            currentY = piggy.Top;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            angryBird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;
            piggy.Left -= pipeSpeed;
            gameScore.Text = "Score: " + score.ToString();


            if (pipeDown.Left < -60)
            {
                pipeDown.Left = 1260;
                score++;
            }

            if (pipeUp.Left < -155)
            {
                pipeUp.Left = 1420;
                score++;
            }

            if (angryBird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                angryBird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                angryBird.Bounds.IntersectsWith(ground.Bounds) ||
                angryBird.Bounds.IntersectsWith(piggy.Bounds) ||
                angryBird.Top < 0)
            {
                endGame();
            }


            if ( score >= evaluationScore)
            {
                pipeSpeed += 3;
                evaluationScore += 5;
            }

            // Piggy Vertical
            currentY += coordinateFactor;

            if (currentY >= maxY || currentY < minY)
            {
                coordinateFactor = -coordinateFactor;
            }

            // Update the PictureBox location for piggy
            piggy.Location = new Point(piggy.Left, currentY);

            // Piggy Horizontal
            if (piggy.Left < -85)
            {
                piggy.Left = 1520;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            gameOverLabel.Visible = true;
        }
    }
}
