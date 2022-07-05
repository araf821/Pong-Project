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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void charSelectBtn_Click(object sender, EventArgs e)
        {
            Form charMenu = new SelectionsMenu();
            Form owner = new GameScreen();
            charMenu.Owner = owner;
            this.Hide();
            charMenu.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void startBtn_MouseLeave(object sender, EventArgs e)
        {
            startBtn.BackgroundImage = Properties.Resources.startBtn;
        }

        private void startBtn_MouseMove(object sender, MouseEventArgs e)
        {
            startBtn.BackgroundImage = Properties.Resources.startBtnHover;
        }

        private void highscoreBtn_MouseLeave(object sender, EventArgs e)
        {
            highscoreBtn.BackgroundImage = Properties.Resources.highscoresBtn;
        }

        private void highscoreBtn_MouseMove(object sender, MouseEventArgs e)
        {
            highscoreBtn.BackgroundImage = Properties.Resources.highscoresBtnHover;
        }

        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            settingsBtn.BackgroundImage = Properties.Resources.settingsBtn;
        }

        private void settingsBtn_MouseMove(object sender, MouseEventArgs e)
        {
            settingsBtn.BackgroundImage = Properties.Resources.settingsBtnHover;
        }

        private void exitBtn_MouseLeave(object sender, EventArgs e)
        {
            exitBtn.BackgroundImage = Properties.Resources.exitBtn;
        }

        private void exitBtn_MouseMove(object sender, MouseEventArgs e)
        {
            exitBtn.BackgroundImage = Properties.Resources.exitBtnHover;
        }
    }
}
