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
			this.canvas = new System.Windows.Forms.Panel();
			this.GameArea = new System.Windows.Forms.Panel();
			this.Controls = new System.Windows.Forms.Panel();
			this.canvas.SuspendLayout();
			this.SuspendLayout();
			// 
			// canvas
			// 
			this.canvas.AutoSize = true;
			this.canvas.Controls.Add(this.Controls);
			this.canvas.Controls.Add(this.GameArea);
			this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.canvas.Location = new System.Drawing.Point(0, 0);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(500, 530);
			this.canvas.TabIndex = 0;
			// 
			// GameArea
			// 
			this.GameArea.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GameArea.Location = new System.Drawing.Point(0, 30);
			this.GameArea.Name = "GameArea";
			this.GameArea.Size = new System.Drawing.Size(500, 500);
			this.GameArea.TabIndex = 0;
			// 
			// Controls
			// 
			this.Controls.Dock = System.Windows.Forms.DockStyle.Top;
			this.Controls.Location = new System.Drawing.Point(0, 0);
			this.Controls.Name = "Controls";
			this.Controls.Size = new System.Drawing.Size(500, 30);
			this.Controls.TabIndex = 1;
			// 
			// GameWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(500, 530);
			this.Controls.Add(this.BackgroundImage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GameWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameWindow";
			this.canvas.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel canvas;
		private System.Windows.Forms.Panel Controls;
		private System.Windows.Forms.Panel GameArea;
	}
}