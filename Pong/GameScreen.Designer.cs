
namespace Pong
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.playerScoreDisplay = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.aI = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // playerScoreDisplay
            // 
            this.playerScoreDisplay.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreDisplay.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.playerScoreDisplay.Location = new System.Drawing.Point(600, 20);
            this.playerScoreDisplay.Name = "playerScoreDisplay";
            this.playerScoreDisplay.Size = new System.Drawing.Size(400, 100);
            this.playerScoreDisplay.TabIndex = 3;
            this.playerScoreDisplay.Text = "0";
            this.playerScoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 5;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.Transparent;
            this.pongBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pongBall.Image = global::Pong.Properties.Resources.pleading;
            this.pongBall.Location = new System.Drawing.Point(768, 375);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(50, 50);
            this.pongBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pongBall.TabIndex = 4;
            this.pongBall.TabStop = false;
            // 
            // aI
            // 
            this.aI.BackColor = System.Drawing.Color.Cyan;
            this.aI.Location = new System.Drawing.Point(1560, 375);
            this.aI.Name = "aI";
            this.aI.Size = new System.Drawing.Size(10, 170);
            this.aI.TabIndex = 1;
            this.aI.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.player.Location = new System.Drawing.Point(10, 375);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(10, 150);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.aI);
            this.Controls.Add(this.player);
            this.Controls.Add(this.playerScoreDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox aI;
        public System.Windows.Forms.Timer GameTimer;
        public System.Windows.Forms.Label playerScoreDisplay;
        public System.Windows.Forms.PictureBox pongBall;
    }
}

