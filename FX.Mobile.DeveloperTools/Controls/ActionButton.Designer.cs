namespace FX.Mobile.DeveloperTools.Controls
{
	partial class ActionButton
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionButton));
			this.imageHover = new System.Windows.Forms.PictureBox();
			this.imageMain = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imageHover)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageMain)).BeginInit();
			this.SuspendLayout();
			// 
			// imageHover
			// 
			this.imageHover.Location = new System.Drawing.Point(0, 0);
			this.imageHover.Name = "imageHover";
			this.imageHover.Size = new System.Drawing.Size(274, 85);
			this.imageHover.TabIndex = 0;
			this.imageHover.TabStop = false;
			// 
			// imageMain
			// 
			this.imageMain.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageMain.InitialImage")));
			this.imageMain.Location = new System.Drawing.Point(0, 0);
			this.imageMain.Name = "imageMain";
			this.imageMain.Size = new System.Drawing.Size(274, 85);
			this.imageMain.TabIndex = 1;
			this.imageMain.TabStop = false;
			this.imageMain.Click += new System.EventHandler(this.imageMain_Click);
			this.imageMain.MouseEnter += new System.EventHandler(this.imageButton_MouseEnterLeave);
			this.imageMain.MouseLeave += new System.EventHandler(this.imageButton_MouseEnterLeave);
			// 
			// ActionButton
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.imageMain);
			this.Controls.Add(this.imageHover);
			this.MaximumSize = new System.Drawing.Size(274, 85);
			this.MinimumSize = new System.Drawing.Size(274, 85);
			this.Name = "ActionButton";
			this.Size = new System.Drawing.Size(274, 85);
			((System.ComponentModel.ISupportInitialize)(this.imageHover)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageMain)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox imageHover;
		private System.Windows.Forms.PictureBox imageMain;
	}
}
