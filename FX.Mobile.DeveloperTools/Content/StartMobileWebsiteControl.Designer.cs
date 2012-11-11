namespace FX.Mobile.DeveloperTools.Content
{
	partial class StartMobileWebsiteControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMobileWebsiteControl));
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.textProductPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.panelWarning = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelWarning.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.SteelBlue;
			this.label5.Location = new System.Drawing.Point(54, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(300, 25);
			this.label5.TabIndex = 28;
			this.label5.Text = "Start a mobile website without IIS";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(56, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(523, 101);
			this.label1.TabIndex = 29;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowse.FlatAppearance.BorderSize = 0;
			this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBrowse.ForeColor = System.Drawing.Color.White;
			this.buttonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowse.Image")));
			this.buttonBrowse.Location = new System.Drawing.Point(547, 163);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(32, 32);
			this.buttonBrowse.TabIndex = 32;
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// textProductPath
			// 
			this.textProductPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textProductPath.BackColor = System.Drawing.SystemColors.Window;
			this.textProductPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textProductPath.Location = new System.Drawing.Point(211, 163);
			this.textProductPath.Name = "textProductPath";
			this.textProductPath.ReadOnly = true;
			this.textProductPath.Size = new System.Drawing.Size(330, 20);
			this.textProductPath.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 30;
			this.label3.Text = "Mobile root";
			// 
			// buttonStart
			// 
			this.buttonStart.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonStart.FlatAppearance.BorderSize = 0;
			this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStart.ForeColor = System.Drawing.Color.White;
			this.buttonStart.Location = new System.Drawing.Point(211, 239);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(193, 36);
			this.buttonStart.TabIndex = 33;
			this.buttonStart.Text = "Start Mobile Website";
			this.buttonStart.UseVisualStyleBackColor = false;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// panelWarning
			// 
			this.panelWarning.Controls.Add(this.label4);
			this.panelWarning.Controls.Add(this.pictureBox1);
			this.panelWarning.Location = new System.Drawing.Point(211, 194);
			this.panelWarning.Name = "panelWarning";
			this.panelWarning.Size = new System.Drawing.Size(348, 36);
			this.panelWarning.TabIndex = 34;
			this.panelWarning.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label4.Location = new System.Drawing.Point(25, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(305, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "Warning: argos-sdk and products folders are not found!";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// StartMobileWebsiteControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panelWarning);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textProductPath);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Name = "StartMobileWebsiteControl";
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.textProductPath, 0);
			this.Controls.SetChildIndex(this.buttonBrowse, 0);
			this.Controls.SetChildIndex(this.buttonStart, 0);
			this.Controls.SetChildIndex(this.panelWarning, 0);
			this.panelWarning.ResumeLayout(false);
			this.panelWarning.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TextBox textProductPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Panel panelWarning;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
