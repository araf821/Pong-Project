namespace Pong
{
    partial class CharacterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterMenu));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.char4 = new System.Windows.Forms.PictureBox();
            this.char2 = new System.Windows.Forms.PictureBox();
            this.char3 = new System.Windows.Forms.PictureBox();
            this.char1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.char4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.char1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(302, 67);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(1011, 164);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Choose a character!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // char4
            // 
            this.char4.BackColor = System.Drawing.Color.Transparent;
            this.char4.Image = global::Pong.Properties.Resources.fisheye;
            this.char4.Location = new System.Drawing.Point(1100, 400);
            this.char4.Name = "char4";
            this.char4.Size = new System.Drawing.Size(250, 250);
            this.char4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.char4.TabIndex = 4;
            this.char4.TabStop = false;
            this.char4.Click += new System.EventHandler(this.char4_Click);
            // 
            // char2
            // 
            this.char2.BackColor = System.Drawing.Color.Transparent;
            this.char2.Image = global::Pong.Properties.Resources.shock;
            this.char2.Location = new System.Drawing.Point(500, 450);
            this.char2.Name = "char2";
            this.char2.Size = new System.Drawing.Size(250, 250);
            this.char2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.char2.TabIndex = 3;
            this.char2.TabStop = false;
            this.char2.Click += new System.EventHandler(this.char2_Click);
            // 
            // char3
            // 
            this.char3.BackColor = System.Drawing.Color.Transparent;
            this.char3.Image = global::Pong.Properties.Resources.crying;
            this.char3.Location = new System.Drawing.Point(800, 275);
            this.char3.Name = "char3";
            this.char3.Size = new System.Drawing.Size(250, 250);
            this.char3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.char3.TabIndex = 2;
            this.char3.TabStop = false;
            this.char3.Click += new System.EventHandler(this.char3_Click);
            // 
            // char1
            // 
            this.char1.BackColor = System.Drawing.Color.Transparent;
            this.char1.Image = global::Pong.Properties.Resources.pleading;
            this.char1.Location = new System.Drawing.Point(200, 300);
            this.char1.Name = "char1";
            this.char1.Size = new System.Drawing.Size(250, 250);
            this.char1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.char1.TabIndex = 1;
            this.char1.TabStop = false;
            this.char1.Click += new System.EventHandler(this.char1_Click);
            // 
            // CharacterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.char4);
            this.Controls.Add(this.char2);
            this.Controls.Add(this.char3);
            this.Controls.Add(this.char1);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "CharacterMenu";
            this.Text = "Choose A Character";
            ((System.ComponentModel.ISupportInitialize)(this.char4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.char1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox char1;
        private System.Windows.Forms.PictureBox char3;
        private System.Windows.Forms.PictureBox char2;
        private System.Windows.Forms.PictureBox char4;
    }
}