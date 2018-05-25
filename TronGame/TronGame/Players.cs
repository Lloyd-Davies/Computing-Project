using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronGame
{
    public class Players
    {
        public int maxScreenX = 500;
        public int maxScreenY = 500;

		public PictureBox PlayerBlue = new PictureBox();
		public PictureBox PlayerRed = new PictureBox();
       
       

        
        

        public void StartGame()
        {
            //Set settings to default
            new Settings();
        }
		private static Hashtable keyTable = new Hashtable();

		public static bool KeyPressed(Keys key)
		{
			if (keyTable[key] == null)
			{
				return false;
			}

			return (bool)keyTable[key];
		}

		public static void ChangeState(Keys key, bool state)
		{
			keyTable[key] = state;
		}



		static void MovePlayers()
		{ 
			 if (firstPlayerDirection == right) 
			 { 
				firstPlayerColumn++; 
			 } 
			 if (firstPlayerDirection == left) 
			 { 
				 firstPlayerColumn--;          } 
			 if (firstPlayerDirection == up) 
			 { 
				firstPlayerRow--;          } 
			 if (firstPlayerDirection == down) 
			 { 
				 firstPlayerRow++; 
			 } 
 
 

			 if (secondPlayerDirection == right) 
			 { 
				 secondPlayerColumn++; 
			 } 
			 if (secondPlayerDirection == left) 
			 { 
				 secondPlayerColumn--; 
			 } 
			 if (secondPlayerDirection == up) 
			 { 
				 secondPlayerRow--; 
			 } 
			 if (secondPlayerDirection == down) 
			 { 
				 secondPlayerRow++; 
			 } 
			 
		}

		static void ChangePlayerDirection(ConsoleKeyInfo key)
		{
			if (key.Key == ConsoleKey.W && firstPlayerDirection != down)
			{
				firstPlayerDirection = up;
			}
			if (key.Key == ConsoleKey.A && firstPlayerDirection != right)
			{
				firstPlayerDirection = left;
			}
			if (key.Key == ConsoleKey.D && firstPlayerDirection != left)
			{
				firstPlayerDirection = right;
			}
			if (key.Key == ConsoleKey.S && firstPlayerDirection != up)
			{
				firstPlayerDirection = down;
			}


			if (key.Key == ConsoleKey.UpArrow && secondPlayerDirection != down)
			{
				secondPlayerDirection = up;
			}
			if (key.Key == ConsoleKey.LeftArrow && secondPlayerDirection != right)
			{
				secondPlayerDirection = left;
			}
			if (key.Key == ConsoleKey.RightArrow && secondPlayerDirection != left)
			{
				secondPlayerDirection = right;
			}
			if (key.Key == ConsoleKey.DownArrow && secondPlayerDirection != up)
			{
				secondPlayerDirection = down;
			}
		}




































		private void UpdateScreen(object sender, EventArgs e)
		 {
			 //Check for Game Over
			 if (Settings.GameOver)
			 {
				 //Check if Enter is pressed
				 if (Players.KeyPressed(Keys.Space))
				 {
					 StartGame();
				 }
			 }
			 else
			 {
				 if (Players.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
					 Settings.direction = Direction.Right;
				 else if (Players.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
					 Settings.direction = Direction.Left;
				 else if (Players.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
					 Settings.direction = Direction.Up;
				 else if (Players.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
					 Settings.direction = Direction.Down;


			 }



		 }



	}
}
