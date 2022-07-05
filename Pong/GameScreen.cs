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
    public partial class GameScreen : Form
    {

        // Speed Variables
        int aiSpeed = 10;
        int ballHorizontalSpeed = 5;
        int ballVerticalSpeed = 5;
        int playerSpeed = 10;

        // Score Variables
        public int playerScore = 0;

        // Window Size Variables
        int horizontalMidpoint;
        int verticalMidpoint;
        int bottomBoundary;

        // Player Input-Detection Variables
        bool playerUp;
        bool playerDown;
        int paused = 1;

        public GameScreen()
        {
            InitializeComponent();

            bottomBoundary = ClientSize.Height - player.Height;
            horizontalMidpoint = ClientSize.Width / 2;
            verticalMidpoint = ClientSize.Height / 2;

            //Instance = this;
            //lbl = playerScoreDisplay;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            /* ----------------- BALL MOVEMENTS -------------------------- */

            // Make the ball start moving
            pongBall.Left -= ballHorizontalSpeed;
            pongBall.Top += ballVerticalSpeed;

            // Ensure that it does not exit the boundaries
            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height)
            {
                ballVerticalSpeed = -ballVerticalSpeed;
            }

            if (pongBall.Left > ClientSize.Width + pongBall.Width)
            {
                ballHorizontalSpeed = -ballHorizontalSpeed;
            }

            /* ------------------------------- PLAYER MOVEMENTS --------------------------------- */

            if (playerUp == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            } 

            if (playerDown == true && player.Top < bottomBoundary)
            {
                player.Top += playerSpeed;
            }

            /* ----------------------- CPU PLAYER MOVEMENTS --------------------------- */

            //aI.Top += aiSpeed;
            aI.Top = pongBall.Top - 70;

            if (aI.Top < 0 || aI.Top > bottomBoundary)
            {
                aiSpeed = -aiSpeed; // Reverse the direction of the player.
            }

            /* ------------------------------- PHYSICS --------------------------- */
            if (player.Bounds.IntersectsWith(pongBall.Bounds))
            {
                ballHorizontalSpeed = -ballHorizontalSpeed;
                ballHorizontalSpeed--;
                playerSpeed++;
            }

            if (pongBall.Bounds.IntersectsWith(aI.Bounds))
            {
                ballHorizontalSpeed = -ballHorizontalSpeed;
                ballHorizontalSpeed++;
            }

            /* --------------------- SCORE KEEPING -------------------------- */
            if (pongBall.Left < 0)
            {
                GameOver();
            }

            if (pongBall.Left > ClientSize.Width + pongBall.Width)
            {
                playerScore++;
                playerScoreDisplay.Text = playerScore.ToString();
            }

        }

        private void GameOver()
        {
            GameTimer.Stop();
            this.Close();
            Form gameOverScreen = new GamOverScreen();
            GamOverScreen.Instance.finalScore.Text = "Your Score: " + playerScore.ToString();
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
                    GameTimer.Stop();
                    this.Opacity = 0.5;
                }
                else
                {
                    GameTimer.Start();
                    this.Opacity = 1;
                }
            }
        }
    }
}
