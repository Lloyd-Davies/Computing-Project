namespace TronGame
{
    partial class MainMenu
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
            this.buttonTwoPlayer = new System.Windows.Forms.Button();
            this.buttonMultiplayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTwoPlayer
            // 
            this.buttonTwoPlayer.BackColor = System.Drawing.Color.White;
            this.buttonTwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTwoPlayer.Location = new System.Drawing.Point(66, 91);
            this.buttonTwoPlayer.Name = "buttonTwoPlayer";
            this.buttonTwoPlayer.Size = new System.Drawing.Size(154, 34);
            this.buttonTwoPlayer.TabIndex = 0;
            this.buttonTwoPlayer.Text = "Play Two Player";
            this.buttonTwoPlayer.UseVisualStyleBackColor = false;
            this.buttonTwoPlayer.Click += new System.EventHandler(this.buttonTwoPlayer_Click);
            // 
            // buttonMultiplayer
            // 
            this.buttonMultiplayer.BackColor = System.Drawing.Color.White;
            this.buttonMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMultiplayer.Location = new System.Drawing.Point(66, 144);
            this.buttonMultiplayer.Name = "buttonMultiplayer";
            this.buttonMultiplayer.Size = new System.Drawing.Size(154, 34);
            this.buttonMultiplayer.TabIndex = 1;
            this.buttonMultiplayer.Text = "Play Multiplayer (LAN)";
            this.buttonMultiplayer.UseVisualStyleBackColor = false;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Woodcut", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRON GAME";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMultiplayer);
            this.Controls.Add(this.buttonTwoPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTwoPlayer;
        private System.Windows.Forms.Button buttonMultiplayer;
        private System.Windows.Forms.Label label1;
    }
}

