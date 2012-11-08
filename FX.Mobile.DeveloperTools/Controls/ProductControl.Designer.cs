namespace FX.Mobile.DeveloperTools.Controls
{
	partial class ProductControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonStartProd = new System.Windows.Forms.Button();
			this.labelProduct = new System.Windows.Forms.Label();
			this.buttonStartDev = new System.Windows.Forms.Button();
			this.panelSeparator = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// buttonStartProd
			// 
			this.buttonStartProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStartProd.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonStartProd.FlatAppearance.BorderSize = 0;
			this.buttonStartProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStartProd.ForeColor = System.Drawing.Color.White;
			this.buttonStartProd.Location = new System.Drawing.Point(251, 5);
			this.buttonStartProd.Name = "buttonStartProd";
			this.buttonStartProd.Size = new System.Drawing.Size(136, 36);
			this.buttonStartProd.TabIndex = 24;
			this.buttonStartProd.Text = "Start Production";
			this.buttonStartProd.UseVisualStyleBackColor = false;
			this.buttonStartProd.Click += new System.EventHandler(this.buttonStartProd_Click);
			// 
			// labelProduct
			// 
			this.labelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelProduct.AutoEllipsis = true;
			this.labelProduct.Location = new System.Drawing.Point(41, 11);
			this.labelProduct.Name = "labelProduct";
			this.labelProduct.Size = new System.Drawing.Size(204, 37);
			this.labelProduct.TabIndex = 25;
			this.labelProduct.Text = "argos-saleslogix";
			// 
			// buttonStartDev
			// 
			this.buttonStartDev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStartDev.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonStartDev.FlatAppearance.BorderSize = 0;
			this.buttonStartDev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStartDev.ForeColor = System.Drawing.Color.White;
			this.buttonStartDev.Location = new System.Drawing.Point(391, 5);
			this.buttonStartDev.Name = "buttonStartDev";
			this.buttonStartDev.Size = new System.Drawing.Size(136, 36);
			this.buttonStartDev.TabIndex = 26;
			this.buttonStartDev.Text = "Start Dev";
			this.buttonStartDev.UseVisualStyleBackColor = false;
			this.buttonStartDev.Click += new System.EventHandler(this.buttonStartDev_Click);
			// 
			// panelSeparator
			// 
			this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSeparator.Location = new System.Drawing.Point(0, 0);
			this.panelSeparator.Name = "panelSeparator";
			this.panelSeparator.Size = new System.Drawing.Size(532, 1);
			this.panelSeparator.TabIndex = 27;
			// 
			// ProductControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.panelSeparator);
			this.Controls.Add(this.buttonStartDev);
			this.Controls.Add(this.labelProduct);
			this.Controls.Add(this.buttonStartProd);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ProductControl";
			this.Size = new System.Drawing.Size(532, 52);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonStartProd;
		private System.Windows.Forms.Label labelProduct;
		private System.Windows.Forms.Button buttonStartDev;
		private System.Windows.Forms.Panel panelSeparator;
	}
}
