using System;
using System.Collections.Generic;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace TronGame
{
	
    public class Player1 : Players
    {
		
		public int BikeX = 375;
		public int BikeY = 250;

		public void Bike()
		{
            PlayerBlue.Image = Properties.Resources.PlayerBlue;
            PlayerBlue.Size = new System.Drawing.Size(15, 15);
			PlayerBlue.Location = new System.Drawing.Point(BikeX, BikeY);
			PlayerBlue.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerBlue.BackColor = Color.Transparent;
            
            

		}

		private static Hashtable keyTable = new Hashtable();
       
		//Perform a check to see if a particular button is pressed.
		

        //Detect if a keyboard button is pressed
      
		

		private void UpdateScreen(object sender, EventArgs e)
		{

			if (Player1.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
			{
				Settings.direction = Direction.Right;
				BikeX = BikeX + 5;
			}
			else if (Player1.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
			{
				Settings.direction = Direction.Left;
				BikeX = BikeX - 5;
			}

			else if (Player1.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
			{
				Settings.direction = Direction.Up;
				BikeY = BikeY + 5;
			}

			else if (Player1.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
			{
				Settings.direction = Direction.Down;
				BikeY = BikeY - 5;
			}		
		}
	}
}
