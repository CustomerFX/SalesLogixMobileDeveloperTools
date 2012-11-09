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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.labelGetIisExpress = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textPort = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panelError.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(98, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(508, 63);
			this.label1.TabIndex = 12;
			this.label1.Text = "Launch the mobile website in IIS Express. Choose from the products and configurat" +
    "ions below to start:";
			// 
			// panelProductList
			// 
			this.panelProductList.AutoScroll = true;
			this.panelProductList.Location = new System.Drawing.Point(102, 173);
			this.panelProductList.Name = "panelProductList";
			this.panelProductList.Size = new System.Drawing.Size(504, 205);
			this.panelProductList.TabIndex = 13;
			// 
			// panelError
			// 
			this.panelError.Controls.Add(this.pictureBox2);
			this.panelError.Controls.Add(this.labelGetIisExpress);
			this.panelError.Controls.Add(this.label3);
			this.panelError.Controls.Add(this.label2);
			this.panelError.Controls.Add(this.pictureBox1);
			this.panelError.Location = new System.Drawing.Point(14, 76);
			this.panelError.Name = "panelError";
			this.panelError.Size = new System.Drawing.Size(674, 326);
			this.panelError.TabIndex = 14;
			this.panelError.Visible = false;
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
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(86, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(497, 77);
			this.label3.TabIndex = 2;
			this.label3.Text = "IIS Express is required to launch websites without using IIS.  You can install II" +
    "S Express from Microsoft or configure IIS for this development environment.";
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(98, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 21);
			this.label4.TabIndex = 15;
			this.label4.Text = "Port:";
			// 
			// textPort
			// 
			this.textPort.Location = new System.Drawing.Point(146, 128);
			this.textPort.Name = "textPort";
			this.textPort.Size = new System.Drawing.Size(77, 29);
			this.textPort.TabIndex = 16;
			this.textPort.Text = "12684";
			this.textPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPort_KeyPress);
			this.textPort.Leave += new System.EventHandler(this.textPort_Leave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(98, 381);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(514, 21);
			this.label5.TabIndex = 17;
			this.label5.Text = "To stop, look for IIS Express in the system tray, right-click, and select \'Exit\'";
			// 
			// FormLaunchWeb
			// 
			this.ClientSize = new System.Drawing.Size(698, 430);
			this.Controls.Add(this.panelError);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textPort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panelProductList);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormLaunchWeb";
			this.ShowIcon = true;
			this.ShowMinimize = true;
			this.ShowTitle = true;
			this.Text = "SalesLogix Mobile Developer Tools Launcher";
			this.Load += new System.EventHandler(this.FormLaunchWeb_Load);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.panelProductList, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.textPort, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.panelError, 0);
			this.panelError.ResumeLayout(false);
			this.panelError.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textPort;
		private System.Windows.Forms.Label label5;

	}
}
