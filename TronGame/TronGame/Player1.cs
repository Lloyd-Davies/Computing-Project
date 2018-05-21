﻿using System;
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
		private GameWindow gameWindow;
		private int BikeX = 375;
		private int BikeY = 250;

		public void Bike(object sender, EventArgs e, Form gameWindow)
		{
			//this.gameWindow = gameWindow;
			PlayerBlue.Size = new System.Drawing.Size(5, 5);
			PlayerBlue.Location = new System.Drawing.Point(BikeX, BikeY);
			PlayerBlue.SizeMode = PictureBoxSizeMode.AutoSize;
			PlayerBlue.Image = Properties.Resources.PlayerBlue;
			
			

		}

		private static Hashtable keyTable = new Hashtable();

		

		//Perform a check to see if a particular button is pressed.
		private static bool KeyPressed(Keys key)
		{
			if (keyTable[key] == null)
			{
				return false;
			}

			return (bool)keyTable[key];
		}

		//Detect if a keyboard button is pressed
		public static void ChangeState(Keys key, bool state)
		{
			keyTable[key] = state;
		}

		private void StartGame()
		{
			//Set settings to default
			new Settings();
		}

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
