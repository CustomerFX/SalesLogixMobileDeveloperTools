namespace FX.Mobile.DeveloperTools.Content
{
	partial class CreateProductControl
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProductControl));
			this.label1 = new System.Windows.Forms.Label();
			this.option12 = new System.Windows.Forms.RadioButton();
			this.option20 = new System.Windows.Forms.RadioButton();
			this.buttonCreateProduct = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.textProductName = new System.Windows.Forms.TextBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.textProductPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelWarning = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelWarning.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select version";
			// 
			// option12
			// 
			this.option12.AutoSize = true;
			this.option12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.option12.Location = new System.Drawing.Point(211, 46);
			this.option12.Name = "option12";
			this.option12.Size = new System.Drawing.Size(39, 17);
			this.option12.TabIndex = 1;
			this.option12.Text = "1.2";
			this.option12.UseVisualStyleBackColor = true;
			// 
			// option20
			// 
			this.option20.AutoSize = true;
			this.option20.Checked = true;
			this.option20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.option20.Location = new System.Drawing.Point(266, 46);
			this.option20.Name = "option20";
			this.option20.Size = new System.Drawing.Size(98, 17);
			this.option20.TabIndex = 2;
			this.option20.TabStop = true;
			this.option20.Text = "2.0 (and higher)";
			this.option20.UseVisualStyleBackColor = true;
			// 
			// buttonCreateProduct
			// 
			this.buttonCreateProduct.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonCreateProduct.FlatAppearance.BorderSize = 0;
			this.buttonCreateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCreateProduct.ForeColor = System.Drawing.Color.White;
			this.buttonCreateProduct.Location = new System.Drawing.Point(211, 206);
			this.buttonCreateProduct.Name = "buttonCreateProduct";
			this.buttonCreateProduct.Size = new System.Drawing.Size(154, 36);
			this.buttonCreateProduct.TabIndex = 3;
			this.buttonCreateProduct.Text = "Create Product";
			this.buttonCreateProduct.UseVisualStyleBackColor = false;
			this.buttonCreateProduct.Click += new System.EventHandler(this.buttonCreateProduct_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(59, 298);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(482, 29);
			this.progressBar1.TabIndex = 4;
			this.progressBar1.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Product name";
			// 
			// textProductName
			// 
			this.textProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textProductName.Location = new System.Drawing.Point(211, 89);
			this.textProductName.Name = "textProductName";
			this.textProductName.Size = new System.Drawing.Size(330, 20);
			this.textProductName.TabIndex = 6;
			this.textProductName.Text = "Custom";
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(56, 272);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(185, 13);
			this.labelStatus.TabIndex = 7;
			this.labelStatus.Text = "Click \'Create Product\' above to start...";
			this.labelStatus.Visible = false;
			// 
			// textProductPath
			// 
			this.textProductPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textProductPath.BackColor = System.Drawing.SystemColors.Window;
			this.textProductPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textProductPath.Location = new System.Drawing.Point(211, 125);
			this.textProductPath.Name = "textProductPath";
			this.textProductPath.ReadOnly = true;
			this.textProductPath.Size = new System.Drawing.Size(330, 20);
			this.textProductPath.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Mobile root";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowse.FlatAppearance.BorderSize = 0;
			this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBrowse.ForeColor = System.Drawing.Color.White;
			this.buttonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowse.Image")));
			this.buttonBrowse.Location = new System.Drawing.Point(547, 123);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(32, 32);
			this.buttonBrowse.TabIndex = 10;
			this.toolTip1.SetToolTip(this.buttonBrowse, "Select destination folder");
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
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
			// panelWarning
			// 
			this.panelWarning.Controls.Add(this.label4);
			this.panelWarning.Controls.Add(this.pictureBox1);
			this.panelWarning.Location = new System.Drawing.Point(211, 156);
			this.panelWarning.Name = "panelWarning";
			this.panelWarning.Size = new System.Drawing.Size(348, 36);
			this.panelWarning.TabIndex = 12;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.SteelBlue;
			this.label5.Location = new System.Drawing.Point(54, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(400, 25);
			this.label5.TabIndex = 15;
			this.label5.Text = "Create new mobile product for customization";
			// 
			// CreateProductControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panelWarning);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textProductPath);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.textProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.buttonCreateProduct);
			this.Controls.Add(this.option20);
			this.Controls.Add(this.option12);
			this.Controls.Add(this.label1);
			this.Name = "CreateProductControl";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.option12, 0);
			this.Controls.SetChildIndex(this.option20, 0);
			this.Controls.SetChildIndex(this.buttonCreateProduct, 0);
			this.Controls.SetChildIndex(this.progressBar1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.textProductName, 0);
			this.Controls.SetChildIndex(this.labelStatus, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.textProductPath, 0);
			this.Controls.SetChildIndex(this.buttonBrowse, 0);
			this.Controls.SetChildIndex(this.panelWarning, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelWarning.ResumeLayout(false);
			this.panelWarning.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton option12;
		private System.Windows.Forms.RadioButton option20;
		private System.Windows.Forms.Button buttonCreateProduct;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textProductName;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.TextBox textProductPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panelWarning;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}
