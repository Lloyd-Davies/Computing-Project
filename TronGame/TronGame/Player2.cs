using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TronGame
{
    public class Player2 : Players
    {
		private static Hashtable keyTable = new Hashtable();


		private void Bike(object sender, EventArgs e)
		{
			
		}

			

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
		private static void ChangeState(Keys key, bool state)
		{
			keyTable[key] = state;
		}


		private void UpdateScreen(object sender, EventArgs e)
		{
			
			
			if (Player2.KeyPressed(Keys.D) && Settings.direction != Direction.Left)
				Settings.direction = Direction.Right;
			else if (Player2.KeyPressed(Keys.A) && Settings.direction != Direction.Right)
				Settings.direction = Direction.Left;
			else if (Player2.KeyPressed(Keys.W) && Settings.direction != Direction.Down)
				Settings.direction = Direction.Up;
			else if (Player2.KeyPressed(Keys.S) && Settings.direction != Direction.Up)
				Settings.direction = Direction.Down;


			



		}
	}
}
