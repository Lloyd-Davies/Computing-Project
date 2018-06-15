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
		public bool Started = false;

		public GameWindow()
		{
            InitializeComponent();
            

        }

		private void GameWindow_Load(object sender, EventArgs e)
		{
			this.KeyDown += new KeyEventHandler(GameStart);
			StartPrompt = new Label();

            StartPrompt.AutoSize = true;
            StartPrompt.BackColor = Color.Transparent;
            StartPrompt.Cursor = Cursors.Default;
            StartPrompt.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            StartPrompt.ForeColor = SystemColors.ButtonHighlight;
            StartPrompt.Location = new Point(77, 404);
            StartPrompt.Name = "StartPrompt";
            StartPrompt.Size = new Size(352, 31);
            StartPrompt.TabIndex = 0;
            StartPrompt.Text = "Press Space to start the game!";

            GameArea.Controls.Add(StartPrompt);

            Player1 p1 = new Player1();
            p1.Bike();
            GameArea.Controls.Add(p1.PlayerBlue);
            p1.PlayerBlue.BringToFront();

            Player2 p2 = new Player2();
            p2.Bike();
            GameArea.Controls.Add(p2.PlayerRed);
            p2.PlayerRed.BringToFront();

            Players p = new TronGame.Players();

            //GameStart(e); 


		}

		private static Hashtable keyTable = new Hashtable();
		

		private void GameStart(object sender, KeyEventArgs e)
		{


			if ((Keys.Space == e.KeyCode))
			{

				Started = true;
				GameArea.Controls.Remove(StartPrompt);
				p.StartGame();

			}
			
		}



        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
			//Application.Exit();
        }

	
	}
}
