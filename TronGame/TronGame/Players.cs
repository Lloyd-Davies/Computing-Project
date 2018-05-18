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

		public PictureBox Bike1 = new PictureBox();
		public PictureBox Bike2 = new PictureBox();
       
       

        
        

        private void StartGame()
        {
            //Set settings to default
            new Settings();
        }

       /* private void UpdateScreen(object sender, EventArgs e)
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



        }*/



    }
}
