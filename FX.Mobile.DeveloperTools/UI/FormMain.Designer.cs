namespace FX.Mobile.DeveloperTools.UI
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.iconApp = new System.Windows.Forms.PictureBox();
			this.imageButtonCreateProduct = new System.Windows.Forms.PictureBox();
			this.imageButtonCreateProductSelected = new System.Windows.Forms.PictureBox();
			this.imageButtonCreateNewDevEnv = new System.Windows.Forms.PictureBox();
			this.imageButtonCreateNewDevEnvSelected = new System.Windows.Forms.PictureBox();
			this.createProductControl1 = new FX.Mobile.DeveloperTools.Content.CreateProductControl();
			this.createDevEnvControl1 = new FX.Mobile.DeveloperTools.Content.CreateDevEnvControl();
			((System.ComponentModel.ISupportInitialize)(this.iconApp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateProductSelected)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateNewDevEnv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateNewDevEnvSelected)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(64, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(432, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "SalesLogix Mobile Developer Tools";
			// 
			// iconApp
			// 
			this.iconApp.Image = ((System.Drawing.Image)(resources.GetObject("iconApp.Image")));
			this.iconApp.Location = new System.Drawing.Point(15, 12);
			this.iconApp.Name = "iconApp";
			this.iconApp.Size = new System.Drawing.Size(48, 48);
			this.iconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.iconApp.TabIndex = 4;
			this.iconApp.TabStop = false;
			// 
			// imageButtonCreateProduct
			// 
			this.imageButtonCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imageButtonCreateProduct.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonCreateProduct.Image")));
			this.imageButtonCreateProduct.Location = new System.Drawing.Point(15, 94);
			this.imageButtonCreateProduct.Name = "imageButtonCreateProduct";
			this.imageButtonCreateProduct.Size = new System.Drawing.Size(274, 85);
			this.imageButtonCreateProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.imageButtonCreateProduct.TabIndex = 7;
			this.imageButtonCreateProduct.TabStop = false;
			this.imageButtonCreateProduct.Click += new System.EventHandler(this.imageButtonCreateProduct_Click);
			this.imageButtonCreateProduct.MouseEnter += new System.EventHandler(this.imageButton_MouseEnterLeave);
			this.imageButtonCreateProduct.MouseLeave += new System.EventHandler(this.imageButton_MouseEnterLeave);
			// 
			// imageButtonCreateProductSelected
			// 
			this.imageButtonCreateProductSelected.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imageButtonCreateProductSelected.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonCreateProductSelected.Image")));
			this.imageButtonCreateProductSelected.Location = new System.Drawing.Point(15, 94);
			this.imageButtonCreateProductSelected.Name = "imageButtonCreateProductSelected";
			this.imageButtonCreateProductSelected.Size = new System.Drawing.Size(274, 85);
			this.imageButtonCreateProductSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.imageButtonCreateProductSelected.TabIndex = 8;
			this.imageButtonCreateProductSelected.TabStop = false;
			// 
			// imageButtonCreateNewDevEnv
			// 
			this.imageButtonCreateNewDevEnv.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imageButtonCreateNewDevEnv.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonCreateNewDevEnv.Image")));
			this.imageButtonCreateNewDevEnv.Location = new System.Drawing.Point(15, 186);
			this.imageButtonCreateNewDevEnv.Name = "imageButtonCreateNewDevEnv";
			this.imageButtonCreateNewDevEnv.Size = new System.Drawing.Size(274, 85);
			this.imageButtonCreateNewDevEnv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.imageButtonCreateNewDevEnv.TabIndex = 10;
			this.imageButtonCreateNewDevEnv.TabStop = false;
			this.imageButtonCreateNewDevEnv.Click += new System.EventHandler(this.imageButtonCreateNewDevEnv_Click);
			this.imageButtonCreateNewDevEnv.MouseEnter += new System.EventHandler(this.imageButton_MouseEnterLeave);
			this.imageButtonCreateNewDevEnv.MouseLeave += new System.EventHandler(this.imageButton_MouseEnterLeave);
			// 
			// imageButtonCreateNewDevEnvSelected
			// 
			this.imageButtonCreateNewDevEnvSelected.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imageButtonCreateNewDevEnvSelected.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonCreateNewDevEnvSelected.Image")));
			this.imageButtonCreateNewDevEnvSelected.Location = new System.Drawing.Point(15, 186);
			this.imageButtonCreateNewDevEnvSelected.Name = "imageButtonCreateNewDevEnvSelected";
			this.imageButtonCreateNewDevEnvSelected.Size = new System.Drawing.Size(274, 85);
			this.imageButtonCreateNewDevEnvSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.imageButtonCreateNewDevEnvSelected.TabIndex = 11;
			this.imageButtonCreateNewDevEnvSelected.TabStop = false;
			// 
			// createProductControl1
			// 
			this.createProductControl1.BackColor = System.Drawing.Color.White;
			this.createProductControl1.Location = new System.Drawing.Point(698, 66);
			this.createProductControl1.Name = "createProductControl1";
			this.createProductControl1.Size = new System.Drawing.Size(675, 335);
			this.createProductControl1.TabIndex = 9;
			// 
			// createDevEnvControl1
			// 
			this.createDevEnvControl1.BackColor = System.Drawing.Color.White;
			this.createDevEnvControl1.Location = new System.Drawing.Point(698, 66);
			this.createDevEnvControl1.Name = "createDevEnvControl1";
			this.createDevEnvControl1.Size = new System.Drawing.Size(622, 334);
			this.createDevEnvControl1.TabIndex = 12;
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(698, 430);
			this.Controls.Add(this.createDevEnvControl1);
			this.Controls.Add(this.imageButtonCreateNewDevEnv);
			this.Controls.Add(this.createProductControl1);
			this.Controls.Add(this.imageButtonCreateProduct);
			this.Controls.Add(this.imageButtonCreateProductSelected);
			this.Controls.Add(this.imageButtonCreateNewDevEnvSelected);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.ShowMinimize = true;
			this.Text = "SalesLogix Mobile Developer Tools";
			this.Controls.SetChildIndex(this.imageButtonCreateNewDevEnvSelected, 0);
			this.Controls.SetChildIndex(this.imageButtonCreateProductSelected, 0);
			this.Controls.SetChildIndex(this.imageButtonCreateProduct, 0);
			this.Controls.SetChildIndex(this.createProductControl1, 0);
			this.Controls.SetChildIndex(this.imageButtonCreateNewDevEnv, 0);
			this.Controls.SetChildIndex(this.createDevEnvControl1, 0);
			((System.ComponentModel.ISupportInitialize)(this.iconApp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateProductSelected)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateNewDevEnv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCreateNewDevEnvSelected)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox iconApp;
		private System.Windows.Forms.PictureBox imageButtonCreateProduct;
		private System.Windows.Forms.PictureBox imageButtonCreateProductSelected;
		private Content.CreateProductControl createProductControl1;
		private System.Windows.Forms.PictureBox imageButtonCreateNewDevEnv;
		private System.Windows.Forms.PictureBox imageButtonCreateNewDevEnvSelected;
		private Content.CreateDevEnvControl createDevEnvControl1;
	}
}

