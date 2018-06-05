namespace TronGame
{
	partial class GameWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Options = new System.Windows.Forms.Panel();
			this.QuitButton = new NonFocusButton();
			this.GameArea = new System.Windows.Forms.Panel();
			this.Options.SuspendLayout();
			this.GameArea.SuspendLayout();
			this.SuspendLayout();
			// 
			// Options
			// 
			this.Options.Controls.Add(this.QuitButton);
			this.Options.Dock = System.Windows.Forms.DockStyle.Top;
			this.Options.Location = new System.Drawing.Point(0, 0);
			this.Options.Name = "Options";
			this.Options.Size = new System.Drawing.Size(500, 30);
			this.Options.TabIndex = 0;
			// 
			// QuitButton
			// 
			this.QuitButton.BackColor = System.Drawing.Color.Red;
			this.QuitButton.CausesValidation = false;
			this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.QuitButton.Location = new System.Drawing.Point(417, 3);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(80, 24);
			this.QuitButton.TabIndex = 0;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = false;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// GameArea
			// 
			this.GameArea.BackColor = System.Drawing.Color.Transparent;
			this.GameArea.BackgroundImage = global::TronGame.Properties.Resources.BackGrid;			
			this.GameArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameArea.Location = new System.Drawing.Point(0, 30);
			this.GameArea.Name = "GameArea";
			this.GameArea.Size = new System.Drawing.Size(500, 500);
			this.GameArea.TabIndex = 1;
			// 
			// GameWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ClientSize = new System.Drawing.Size(500, 530);
			this.Controls.Add(this.GameArea);
			this.Controls.Add(this.Options);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "GameWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameWindow";
			this.Load += new System.EventHandler(this.GameWindow_Load);
			this.Options.ResumeLayout(false);
			this.GameArea.ResumeLayout(false);
			this.GameArea.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Options;
		public System.Windows.Forms.Panel GameArea;
        private System.Windows.Forms.Button QuitButton;
		private System.Windows.Forms.Label StartPrompt;
	}
}