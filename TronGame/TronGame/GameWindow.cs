using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronGame
{
	public partial class GameWindow : Form
	{
		public Player1 Bike;
		public Player2 BikeRed;

		public GameWindow()
		{
			InitializeComponent();
		}

		private void GameWindow_Load(object sender, EventArgs e)
		{
			PictureBox BackgroundGrid = new PictureBox();
			BackgroundGrid.Image = Properties.Resources.BackGrid;
			BackgroundGrid.Size = new System.Drawing.Size(500, 500);
			BackgroundGrid.Name = "BackgtroundGrid";
			BackgroundGrid.SizeMode =  PictureBoxSizeMode.StretchImage;
			BackgroundGrid.BackColor = Color.Black;
			GameArea.Controls.Add(BackgroundGrid);

			Bike = new Player1(this);


			GameArea.Controls.Add(Bike.PlayerBlue);
			//p1.PlayerBlue.BringToFront();

			//p1.Bike();


		}

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
