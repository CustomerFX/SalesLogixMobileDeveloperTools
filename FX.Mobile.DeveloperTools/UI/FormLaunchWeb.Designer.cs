namespace FX.Mobile.DeveloperTools.UI
{
	partial class FormLaunchWeb
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaunchWeb));
			this.label1 = new System.Windows.Forms.Label();
			this.panelProductList = new System.Windows.Forms.Panel();
			this.panelError = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labelGetIisExpress = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panelError.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(98, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(508, 63);
			this.label1.TabIndex = 12;
			this.label1.Text = "Launch the mobile website in IIS Express. Choose from the products and configurat" +
    "ions below to start:";
			// 
			// panelProductList
			// 
			this.panelProductList.AutoScroll = true;
			this.panelProductList.Location = new System.Drawing.Point(102, 162);
			this.panelProductList.Name = "panelProductList";
			this.panelProductList.Size = new System.Drawing.Size(504, 222);
			this.panelProductList.TabIndex = 13;
			// 
			// panelError
			// 
			this.panelError.Controls.Add(this.pictureBox2);
			this.panelError.Controls.Add(this.labelGetIisExpress);
			this.panelError.Controls.Add(this.label3);
			this.panelError.Controls.Add(this.label2);
			this.panelError.Controls.Add(this.pictureBox1);
			this.panelError.Location = new System.Drawing.Point(12, 76);
			this.panelError.Name = "panelError";
			this.panelError.Size = new System.Drawing.Size(674, 326);
			this.panelError.TabIndex = 14;
			this.panelError.Visible = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(90, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(80, 80);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.label2.Location = new System.Drawing.Point(176, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(407, 70);
			this.label2.TabIndex = 1;
			this.label2.Text = "IIS Express does not appear to be installed";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(86, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(497, 77);
			this.label3.TabIndex = 2;
			this.label3.Text = "IIS Express is required to launch websites without using IIS.  You can install II" +
    "S Express from Microsoft or configure IIS for this development environment.";
			// 
			// labelGetIisExpress
			// 
			this.labelGetIisExpress.AutoSize = true;
			this.labelGetIisExpress.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelGetIisExpress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline);
			this.labelGetIisExpress.ForeColor = System.Drawing.Color.SteelBlue;
			this.labelGetIisExpress.Location = new System.Drawing.Point(203, 232);
			this.labelGetIisExpress.Name = "labelGetIisExpress";
			this.labelGetIisExpress.Size = new System.Drawing.Size(275, 21);
			this.labelGetIisExpress.TabIndex = 3;
			this.labelGetIisExpress.Text = "Click to download Micosoft IIS Express";
			this.labelGetIisExpress.Click += new System.EventHandler(this.labelGetIisExpress_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(182, 235);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 16);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// FormLaunchWeb
			// 
			this.ClientSize = new System.Drawing.Size(698, 430);
			this.Controls.Add(this.panelError);
			this.Controls.Add(this.panelProductList);
			this.Controls.Add(this.label1);
			this.Name = "FormLaunchWeb";
			this.ShowIcon = true;
			this.ShowMinimize = true;
			this.ShowTitle = true;
			this.Load += new System.EventHandler(this.FormLaunchWeb_Load);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.panelProductList, 0);
			this.Controls.SetChildIndex(this.panelError, 0);
			this.panelError.ResumeLayout(false);
			this.panelError.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelProductList;
		private System.Windows.Forms.Panel panelError;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label labelGetIisExpress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;

	}
}
