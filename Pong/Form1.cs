using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {

        // Travel direction + speed
        int aiDirection = 5;
        int ballXCoordinate = 5;
        int ballYCoordinate = 5;

        // Score Variables
        int playerScore = 0;
        int[] highScores = new int[10];

        // Size Variables
        int horizontalMidpoint;
        int verticalMidpoint;
        int bottomBoundary;

        // Player Input-Detection Variables
        bool playerUp;
        bool playerDown;
        int paused = 0;

        public Pong()
        {
            InitializeComponent();

            bottomBoundary = ClientSize.Height - player.Height;
            horizontalMidpoint = ClientSize.Width / 2;
            verticalMidpoint = ClientSize.Height / 2;
        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Initial ball position
            pongBall.Left = horizontalMidpoint;
            pongBall.Top = verticalMidpoint;

            // Get the ball moving!
            pongBall.Top -= ballYCoordinate;
            pongBall.Left -= ballXCoordinate;

            // Get the AI moving!
            aI.Top += aiDirection;
            // AI switches direction once it hits the boundaries
            if (aI.Top < 0 || aI.Top > bottomBoundary)
            {
                aiDirection = -aiDirection;
            }


            if (pongBall.Left < 0) // Ball has reached the wall past your player
            {
                // Reset its coordinates
                pongBall.Left = horizontalMidpoint;
                pongBall.Top = verticalMidpoint;
                gameOver();
            }
            else if (pongBall.Left + pongBall.Width > ClientSize.Width)
            {
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                playerScoreDisplay.Text = playerScore.ToString();

                // Ball speeds up every time the player gets a point
                ballXCoordinate++;
            }

            // Ensure that the ball stays within the vertical boundaries
            if (pongBall.Top <= 0 || pongBall.Top + pongBall.Height > ClientSize.Height)
            {
                ballYCoordinate = -ballYCoordinate;
            }

            // Check to see if the ball hits the player or the AI
            if (pongBall.Bounds.IntersectsWith(player.Bounds) || pongBall.Bounds.IntersectsWith(aI.Bounds))
            {
                // Make the ball start moving in the opposite direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move Player Up
            if (playerUp == true && player.Top > 0)
            {
                player.Top -= 10;
            }

            // Move Player Down
            if (playerDown == true && player.Top < bottomBoundary)
            {
                player.Top += 10;
            }

        }

        private void gameOver()
        {
            gameTimer.Stop();
            this.Hide();
            Form gameOverScreen = new GameOverScreen();
            gameOverScreen.Show();
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            // If up arrow key is released, player stops moving up.
            if (e.KeyCode == Keys.Up)
            {
                playerUp = false;
            }

            // If down arrow key is released, player stops moving down.
            if (e.KeyCode == Keys.Down)
            {
                playerDown = false;
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            // If up arrow key is pressed, player moves up.
            if (e.KeyCode == Keys.Up)
            {
                playerUp = true;
            }

            // If down arrow key is pressed, player moves down.
            if (e.KeyCode == Keys.Down)
            {
                playerDown = true;
            }

            // If ESC key is pressed, the game pauses.
            if (e.KeyCode == Keys.Escape)
            {
                paused++;

                if (paused % 2 == 0)
                {
                    gameTimer.Stop();
                }
                else
                {
                    gameTimer.Start();
                }
            }
        }

    }
}
