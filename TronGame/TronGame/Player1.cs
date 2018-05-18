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

		private void Bike(object sender, EventArgs e)
		{
			Bike1.Size = new System.Drawing.Size(5, 5);
			Bike1.Image = Properties.Resources.Bike1;

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
				Settings.direction = Direction.Right;
			else if (Player1.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
				Settings.direction = Direction.Left;
			else if (Player1.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
				Settings.direction = Direction.Up;
			else if (Player1.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
				Settings.direction = Direction.Down;


			



		}
	}

	
    
}
