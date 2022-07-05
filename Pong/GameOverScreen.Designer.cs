namespace Pong
{
    partial class GamOverScreen
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
            this.gameOverText = new System.Windows.Forms.Label();
            this.scoreDisplay = new System.Windows.Forms.Label();
            this.retryBtn = new System.Windows.Forms.Button();
            this.mainMenuBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Font = new System.Drawing.Font("Segoe Print", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverText.ForeColor = System.Drawing.Color.White;
            this.gameOverText.Location = new System.Drawing.Point(394, 80);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(806, 213);
            this.gameOverText.TabIndex = 0;
            this.gameOverText.Text = "Game Over!";
            this.gameOverText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreDisplay
            // 
            this.scoreDisplay.AutoSize = true;
            this.scoreDisplay.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreDisplay.ForeColor = System.Drawing.Color.White;
            this.scoreDisplay.Location = new System.Drawing.Point(504, 250);
            this.scoreDisplay.Name = "scoreDisplay";
            this.scoreDisplay.Size = new System.Drawing.Size(596, 141);
            this.scoreDisplay.TabIndex = 1;
            this.scoreDisplay.Text = "Your score: 0";
            this.scoreDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // retryBtn
            // 
            this.retryBtn.BackColor = System.Drawing.Color.Transparent;
            this.retryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retryBtn.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryBtn.ForeColor = System.Drawing.Color.Black;
            this.retryBtn.Image = global::Pong.Properties.Resources.button;
            this.retryBtn.Location = new System.Drawing.Point(625, 425);
            this.retryBtn.Name = "retryBtn";
            this.retryBtn.Size = new System.Drawing.Size(350, 100);
            this.retryBtn.TabIndex = 2;
            this.retryBtn.Text = "Play Again";
            this.retryBtn.UseVisualStyleBackColor = false;
            this.retryBtn.Click += new System.EventHandler(this.retryBtn_Click);
            // 
            // mainMenuBtn
            // 
            this.mainMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuBtn.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuBtn.ForeColor = System.Drawing.Color.Black;
            this.mainMenuBtn.Image = global::Pong.Properties.Resources.button;
            this.mainMenuBtn.Location = new System.Drawing.Point(625, 557);
            this.mainMenuBtn.Name = "mainMenuBtn";
            this.mainMenuBtn.Size = new System.Drawing.Size(350, 100);
            this.mainMenuBtn.TabIndex = 3;
            this.mainMenuBtn.Text = "Main Menu";
            this.mainMenuBtn.UseVisualStyleBackColor = false;
            this.mainMenuBtn.Click += new System.EventHandler(this.mainMenuBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Image = global::Pong.Properties.Resources.button;
            this.exitBtn.Location = new System.Drawing.Point(625, 685);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(350, 100);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // GamOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.mainMenuBtn);
            this.Controls.Add(this.retryBtn);
            this.Controls.Add(this.scoreDisplay);
            this.Controls.Add(this.gameOverText);
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "GamOverScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over :(";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Button retryBtn;
        private System.Windows.Forms.Button mainMenuBtn;
        private System.Windows.Forms.Button exitBtn;
        public System.Windows.Forms.Label scoreDisplay;
    }
}