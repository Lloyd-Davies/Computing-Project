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
        public Player1 myBike1;
        public Player2 myBike2;

        public GameWindow()
        {
            InitializeComponent();

        }

        public void GameWindow_Load(object sender, EventArgs e)
        {
            // Create bike 1
            //myBike1 = new Player1(this);
            // Create bike 2
            //myBike2 = new Player2(this);

			PictureBox BackgroundImage = new PictureBox();
			BackgroundImage.SizeMode = PictureBoxSizeMode.AutoSize;
			BackgroundImage.Image = Properties.Resources.BackGrid;
			GameArea.Controls.Add(BackgroundImage);
        }
    }
}
