namespace FX.Mobile.DeveloperTools.UI
{
	partial class MetroFormBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroFormBase));
            this.labelCfxLink = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.iconApp = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCfxLink
            // 
            this.labelCfxLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCfxLink.AutoSize = true;
            this.labelCfxLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCfxLink.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCfxLink.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelCfxLink.Location = new System.Drawing.Point(613, 407);
            this.labelCfxLink.Name = "labelCfxLink";
            this.labelCfxLink.Size = new System.Drawing.Size(80, 13);
            this.labelCfxLink.TabIndex = 7;
            this.labelCfxLink.Text = "customerfx.com";
            this.toolTip1.SetToolTip(this.labelCfxLink, "Visit Customer FX");
            this.labelCfxLink.Click += new System.EventHandler(this.labelCfxLink_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 427);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(698, 3);
            this.panelBottom.TabIndex = 6;
            // 
            // iconApp
            // 
            this.iconApp.Image = ((System.Drawing.Image)(resources.GetObject("iconApp.Image")));
            this.iconApp.Location = new System.Drawing.Point(15, 12);
            this.iconApp.Name = "iconApp";
            this.iconApp.Size = new System.Drawing.Size(48, 48);
            this.iconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconApp.TabIndex = 9;
            this.iconApp.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.DimGray;
            this.labelTitle.Location = new System.Drawing.Point(64, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(449, 40);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Infor CRM Mobile Developer Toolkit";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(646, 7);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(21, 21);
            this.buttonMinimize.TabIndex = 11;
            this.buttonMinimize.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonMinimize, "Minimize");
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(671, 7);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(21, 21);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.TabStop = false;
            this.toolTip1.SetToolTip(this.buttonClose, "Close");
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MetroFormBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 430);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.iconApp);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCfxLink);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MetroFormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetroFormBase";
            ((System.ComponentModel.ISupportInitialize)(this.iconApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelCfxLink;
		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.PictureBox iconApp;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Button buttonMinimize;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}