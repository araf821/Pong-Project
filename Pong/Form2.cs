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
    public partial class CharacterMenu : Form
    {
        public CharacterMenu()
        {
            InitializeComponent();
        }

        private void char1_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Properties.Resources.pleading;
            (this.Owner as Pong).gameTimer.Start();
            this.Hide();
            (this.Owner as Pong).Show();
        }

        private void char2_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Properties.Resources.shock;
            (this.Owner as Pong).gameTimer.Start();
            this.Hide();
            (this.Owner as Pong).Show();
        }

        private void char3_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Properties.Resources.crying;
            (this.Owner as Pong).gameTimer.Start();
            this.Hide();
            (this.Owner as Pong).Show();
        }

        private void char4_Click(object sender, EventArgs e)
        {
            (this.Owner as Pong).pongBall.Image = Properties.Resources.fisheye;
            (this.Owner as Pong).gameTimer.Start();
            this.Hide();
            (this.Owner as Pong).Show();
        }
    }
}
