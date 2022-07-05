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
    public partial class SelectionsMenu : Form
    {
        public SelectionsMenu()
        {
            InitializeComponent();
        }

        private void char1_Click(object sender, EventArgs e)
        {
            (this.Owner as GameScreen).pongBall.Image = Properties.Resources.pleading;
            (this.Owner as GameScreen).GameTimer.Start();
            this.Hide();
            (this.Owner as GameScreen).Show();
        }

        private void char2_Click(object sender, EventArgs e)
        {
            (this.Owner as GameScreen).pongBall.Image = Properties.Resources.shock;
            (this.Owner as GameScreen).GameTimer.Start();
            this.Hide();
            (this.Owner as GameScreen).Show();
        }

        private void char3_Click(object sender, EventArgs e)
        {
            (this.Owner as GameScreen).pongBall.Image = Properties.Resources.angy;
            (this.Owner as GameScreen).GameTimer.Start();
            this.Hide();
            (this.Owner as GameScreen).Show();
        }

        private void char4_Click(object sender, EventArgs e)
        {
            (this.Owner as GameScreen).pongBall.Image = Properties.Resources.fisheye;
            (this.Owner as GameScreen).GameTimer.Start();
            this.Hide();
            (this.Owner as GameScreen).Show();
        }

    }
}
