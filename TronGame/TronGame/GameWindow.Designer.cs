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
			this.GameArea = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// Options
			// 
			this.Options.Dock = System.Windows.Forms.DockStyle.Top;
			this.Options.Location = new System.Drawing.Point(0, 0);
			this.Options.Name = "Options";
			this.Options.Size = new System.Drawing.Size(500, 30);
			this.Options.TabIndex = 0;
			// 
			// GameArea
			// 
			this.GameArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameArea.Location = new System.Drawing.Point(0, 30);
			this.GameArea.Name = "GameArea";
			this.GameArea.Size = new System.Drawing.Size(500, 501);
			this.GameArea.TabIndex = 1;
			// 
			// GameWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 531);
			this.Controls.Add(this.GameArea);
			this.Controls.Add(this.Options);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "GameWindow";
			this.Text = "GameWindow";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Options;
		private System.Windows.Forms.Panel GameArea;
	}
}