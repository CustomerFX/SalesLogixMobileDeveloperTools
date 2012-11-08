namespace FX.Mobile.DeveloperTools.Controls
{
	partial class ActionPanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionPanel));
			this.buttonBack = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.buttonBack)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
			this.buttonBack.Location = new System.Drawing.Point(3, 19);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(32, 32);
			this.buttonBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.buttonBack.TabIndex = 14;
			this.buttonBack.TabStop = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// ActionPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonBack);
			this.Name = "ActionPanel";
			this.Size = new System.Drawing.Size(622, 334);
			((System.ComponentModel.ISupportInitialize)(this.buttonBack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox buttonBack;
	}
}
