using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TronGame
{
	public partial class GameWindow : Form
	{
        public Players p;
		public Player1 p1;
		public Player2 p2;


		public GameWindow()
		{
            InitializeComponent();
            

        }

		private void GameWindow_Load(object sender, EventArgs e)
		{
            /* Add the background grid
			PictureBox BackgroundGrid = new PictureBox();
			BackgroundGrid.Image = Properties.Resources.BackGrid;
			BackgroundGrid.Size = new System.Drawing.Size(500, 500);
			BackgroundGrid.Name = "BackgroundGrid";
			BackgroundGrid.SizeMode =  PictureBoxSizeMode.StretchImage;
			BackgroundGrid.BackColor = Color.Black;
            
			GameArea.Controls.Add(BackgroundGrid);
            BackgroundGrid.SendToBack();*/

            Player1 p1 = new Player1();
            p1.Bike();
            GameArea.Controls.Add(p1.PlayerBlue);
            p1.PlayerBlue.BringToFront();

            Player2 p2 = new Player2();
            p2.Bike();
            GameArea.Controls.Add(p2.PlayerRed);
            p2.PlayerRed.BringToFront();

            Players p = new TronGame.Players();
            GameStart();


		}

		private void GameStart()
		{
            StartPrompt = new System.Windows.Forms.Label();

            StartPrompt.AutoSize = true;
            StartPrompt.BackColor = System.Drawing.Color.Transparent;
            StartPrompt.Cursor = System.Windows.Forms.Cursors.Default;
            StartPrompt.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            StartPrompt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            StartPrompt.Location = new System.Drawing.Point(77, 404);
            StartPrompt.Name = "StartPrompt";
            StartPrompt.Size = new System.Drawing.Size(352, 31);
            StartPrompt.TabIndex = 0;
            StartPrompt.Text = "Press Space to start the game!";

            GameArea.Controls.Add(StartPrompt);
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
			//Application.Exit();
        }

	
	}
}
