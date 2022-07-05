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
    public partial class GamOverScreen : Form
    {
        public static GamOverScreen Instance;
        public Label finalScore;

        public GamOverScreen()
        {
            InitializeComponent();
            Instance = this;
            finalScore = scoreDisplay;
        }

        private void retryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form newGame = new GameScreen();
            (this.Owner as GameScreen).GameTimer.Start();
            newGame.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new MainMenu();
            main.Show();
        }
    }
}
