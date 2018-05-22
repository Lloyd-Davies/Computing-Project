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
		public Player1 p1;
		public Player2 p2;

		public GameWindow()
		{
            InitializeComponent();
            

        }

		private void GameWindow_Load(object sender, EventArgs e)
		{
            // Add the background grid
			PictureBox BackgroundGrid = new PictureBox();
			BackgroundGrid.Image = Properties.Resources.BackGrid;
			BackgroundGrid.Size = new System.Drawing.Size(500, 500);
			BackgroundGrid.Name = "BackgroundGrid";
			BackgroundGrid.SizeMode =  PictureBoxSizeMode.StretchImage;
			BackgroundGrid.BackColor = Color.Black;
            
			GameArea.Controls.Add(BackgroundGrid);
            BackgroundGrid.SendToBack();

            Player1 p1 = new Player1();
            p1.Bike();
            GameArea.Controls.Add(p1.PlayerBlue);
            p1.PlayerBlue.BringToFront();

            Player2 p2 = new Player2();
            p2.Bike();
            GameArea.Controls.Add(p2.PlayerRed);
            p2.PlayerRed.BringToFront();




        }
      

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
