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
			this.createProductControl1 = new FX.Mobile.DeveloperTools.Content.CreateProductControl();
			this.createDevEnvControl1 = new FX.Mobile.DeveloperTools.Content.CreateDevEnvControl();
			this.actionCreateProduct = new FX.Mobile.DeveloperTools.Controls.ActionButton();
			this.actionCreateDevEnv = new FX.Mobile.DeveloperTools.Controls.ActionButton();
			((System.ComponentModel.ISupportInitialize)(this.iconApp)).BeginInit();
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
			// actionCreateProduct
			// 
			this.actionCreateProduct.HoverImage = ((System.Drawing.Image)(resources.GetObject("actionCreateProduct.HoverImage")));
			this.actionCreateProduct.Location = new System.Drawing.Point(15, 92);
			this.actionCreateProduct.MainImage = ((System.Drawing.Image)(resources.GetObject("actionCreateProduct.MainImage")));
			this.actionCreateProduct.MaximumSize = new System.Drawing.Size(274, 85);
			this.actionCreateProduct.MinimumSize = new System.Drawing.Size(274, 85);
			this.actionCreateProduct.Name = "actionCreateProduct";
			this.actionCreateProduct.Size = new System.Drawing.Size(274, 85);
			this.actionCreateProduct.TabIndex = 13;
			this.actionCreateProduct.ActionClicked += new System.EventHandler(this.actionCreateProduct_ActionClicked);
			// 
			// actionCreateDevEnv
			// 
			this.actionCreateDevEnv.HoverImage = ((System.Drawing.Image)(resources.GetObject("actionCreateDevEnv.HoverImage")));
			this.actionCreateDevEnv.Location = new System.Drawing.Point(15, 184);
			this.actionCreateDevEnv.MainImage = ((System.Drawing.Image)(resources.GetObject("actionCreateDevEnv.MainImage")));
			this.actionCreateDevEnv.MaximumSize = new System.Drawing.Size(274, 85);
			this.actionCreateDevEnv.MinimumSize = new System.Drawing.Size(274, 85);
			this.actionCreateDevEnv.Name = "actionCreateDevEnv";
			this.actionCreateDevEnv.Size = new System.Drawing.Size(274, 85);
			this.actionCreateDevEnv.TabIndex = 14;
			this.actionCreateDevEnv.ActionClicked += new System.EventHandler(this.actionCreateDevEnv_ActionClicked);
			// 
			// FormMain
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(698, 430);
			this.Controls.Add(this.actionCreateDevEnv);
			this.Controls.Add(this.actionCreateProduct);
			this.Controls.Add(this.createDevEnvControl1);
			this.Controls.Add(this.createProductControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormMain";
			this.ShowIcon = true;
			this.ShowMinimize = true;
			this.ShowTitle = true;
			this.Text = "SalesLogix Mobile Developer Tools";
			this.Controls.SetChildIndex(this.createProductControl1, 0);
			this.Controls.SetChildIndex(this.createDevEnvControl1, 0);
			this.Controls.SetChildIndex(this.actionCreateProduct, 0);
			this.Controls.SetChildIndex(this.actionCreateDevEnv, 0);
			((System.ComponentModel.ISupportInitialize)(this.iconApp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox iconApp;
		private Content.CreateProductControl createProductControl1;
		private Content.CreateDevEnvControl createDevEnvControl1;
		private Controls.ActionButton actionCreateProduct;
		private Controls.ActionButton actionCreateDevEnv;
	}
}

