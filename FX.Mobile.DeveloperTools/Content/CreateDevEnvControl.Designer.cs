namespace FX.Mobile.DeveloperTools.Content
{
	partial class CreateDevEnvControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDevEnvControl));
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.textProductPath = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.option20 = new System.Windows.Forms.RadioButton();
			this.option12 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.labelStatus = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button1 = new System.Windows.Forms.Button();
			this.checkIncludeSample = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowse.FlatAppearance.BorderSize = 0;
			this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBrowse.ForeColor = System.Drawing.Color.White;
			this.buttonBrowse.Image = ((System.Drawing.Image)(resources.GetObject("buttonBrowse.Image")));
			this.buttonBrowse.Location = new System.Drawing.Point(547, 89);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(32, 32);
			this.buttonBrowse.TabIndex = 21;
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// textProductPath
			// 
			this.textProductPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textProductPath.BackColor = System.Drawing.SystemColors.Window;
			this.textProductPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textProductPath.Location = new System.Drawing.Point(211, 89);
			this.textProductPath.Name = "textProductPath";
			this.textProductPath.ReadOnly = true;
			this.textProductPath.Size = new System.Drawing.Size(330, 20);
			this.textProductPath.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(56, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Mobile root";
			// 
			// option20
			// 
			this.option20.AutoSize = true;
			this.option20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.option20.Location = new System.Drawing.Point(266, 46);
			this.option20.Name = "option20";
			this.option20.Size = new System.Drawing.Size(39, 17);
			this.option20.TabIndex = 16;
			this.option20.Text = "2.0";
			this.option20.UseVisualStyleBackColor = true;
			// 
			// option12
			// 
			this.option12.AutoSize = true;
			this.option12.Checked = true;
			this.option12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.option12.Location = new System.Drawing.Point(211, 46);
			this.option12.Name = "option12";
			this.option12.Size = new System.Drawing.Size(39, 17);
			this.option12.TabIndex = 15;
			this.option12.TabStop = true;
			this.option12.Text = "1.2";
			this.option12.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Select version";
			// 
			// labelStatus
			// 
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(56, 272);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(197, 13);
			this.labelStatus.TabIndex = 25;
			this.labelStatus.Text = "Click \'Create Dev Environment\' to start...";
			this.labelStatus.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(59, 298);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(482, 29);
			this.progressBar1.TabIndex = 24;
			this.progressBar1.Visible = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SteelBlue;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(211, 178);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(193, 36);
			this.button1.TabIndex = 23;
			this.button1.Text = "Create Dev Environment";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkIncludeSample
			// 
			this.checkIncludeSample.AutoSize = true;
			this.checkIncludeSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkIncludeSample.Location = new System.Drawing.Point(211, 128);
			this.checkIncludeSample.Name = "checkIncludeSample";
			this.checkIncludeSample.Size = new System.Drawing.Size(168, 17);
			this.checkIncludeSample.TabIndex = 26;
			this.checkIncludeSample.Text = "Include argos-sample product?";
			this.checkIncludeSample.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.SteelBlue;
			this.label5.Location = new System.Drawing.Point(54, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(405, 25);
			this.label5.TabIndex = 27;
			this.label5.Text = "Create new mobile development environment";
			// 
			// CreateDevEnvControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkIncludeSample);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textProductPath);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.option20);
			this.Controls.Add(this.option12);
			this.Controls.Add(this.label1);
			this.Name = "CreateDevEnvControl";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.option12, 0);
			this.Controls.SetChildIndex(this.option20, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.textProductPath, 0);
			this.Controls.SetChildIndex(this.buttonBrowse, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.progressBar1, 0);
			this.Controls.SetChildIndex(this.labelStatus, 0);
			this.Controls.SetChildIndex(this.checkIncludeSample, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TextBox textProductPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton option20;
		private System.Windows.Forms.RadioButton option12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkIncludeSample;
		private System.Windows.Forms.Label label5;
	}
}
