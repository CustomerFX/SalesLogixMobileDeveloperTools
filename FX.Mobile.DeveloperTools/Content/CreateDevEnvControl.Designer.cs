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
			this.buttonCreateDevEnv = new System.Windows.Forms.Button();
			this.checkIncludeSample = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.checkLaunch = new System.Windows.Forms.CheckBox();
			this.checkIncludeBackCompat = new System.Windows.Forms.CheckBox();
			this.option30 = new System.Windows.Forms.RadioButton();
			this.option31 = new System.Windows.Forms.RadioButton();
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
			this.option20.CheckedChanged += new System.EventHandler(this.VersionOptionChanged);
			// 
			// option12
			// 
			this.option12.AutoSize = true;
			this.option12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.option12.Location = new System.Drawing.Point(211, 46);
			this.option12.Name = "option12";
			this.option12.Size = new System.Drawing.Size(39, 17);
			this.option12.TabIndex = 15;
			this.option12.Text = "1.2";
			this.option12.UseVisualStyleBackColor = true;
			this.option12.CheckedChanged += new System.EventHandler(this.VersionOptionChanged);
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
			// buttonCreateDevEnv
			// 
			this.buttonCreateDevEnv.BackColor = System.Drawing.Color.SteelBlue;
			this.buttonCreateDevEnv.FlatAppearance.BorderSize = 0;
			this.buttonCreateDevEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCreateDevEnv.ForeColor = System.Drawing.Color.White;
			this.buttonCreateDevEnv.Location = new System.Drawing.Point(211, 223);
			this.buttonCreateDevEnv.Name = "buttonCreateDevEnv";
			this.buttonCreateDevEnv.Size = new System.Drawing.Size(193, 36);
			this.buttonCreateDevEnv.TabIndex = 25;
			this.buttonCreateDevEnv.Text = "Create Dev Environment";
			this.buttonCreateDevEnv.UseVisualStyleBackColor = false;
			this.buttonCreateDevEnv.Click += new System.EventHandler(this.buttonCreateDevEnv_Click);
			// 
			// checkIncludeSample
			// 
			this.checkIncludeSample.AutoSize = true;
			this.checkIncludeSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkIncludeSample.Location = new System.Drawing.Point(211, 150);
			this.checkIncludeSample.Name = "checkIncludeSample";
			this.checkIncludeSample.Size = new System.Drawing.Size(168, 17);
			this.checkIncludeSample.TabIndex = 23;
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
			// checkLaunch
			// 
			this.checkLaunch.AutoSize = true;
			this.checkLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkLaunch.Location = new System.Drawing.Point(211, 176);
			this.checkLaunch.Name = "checkLaunch";
			this.checkLaunch.Size = new System.Drawing.Size(238, 17);
			this.checkLaunch.TabIndex = 24;
			this.checkLaunch.Text = "Launch website after environment is created?";
			this.checkLaunch.UseVisualStyleBackColor = true;
			// 
			// checkIncludeBackCompat
			// 
			this.checkIncludeBackCompat.AutoSize = true;
			this.checkIncludeBackCompat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkIncludeBackCompat.Location = new System.Drawing.Point(211, 124);
			this.checkIncludeBackCompat.Name = "checkIncludeBackCompat";
			this.checkIncludeBackCompat.Size = new System.Drawing.Size(215, 17);
			this.checkIncludeBackCompat.TabIndex = 22;
			this.checkIncludeBackCompat.Text = "Include backwards compatibility for 7.5.4";
			this.checkIncludeBackCompat.UseVisualStyleBackColor = true;
			// 
			// option30
			// 
			this.option30.AutoSize = true;
			this.option30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.option30.Location = new System.Drawing.Point(320, 46);
			this.option30.Name = "option30";
			this.option30.Size = new System.Drawing.Size(39, 17);
			this.option30.TabIndex = 28;
			this.option30.Text = "3.0";
			this.option30.UseVisualStyleBackColor = true;
			// 
			// option31
			// 
			this.option31.AutoSize = true;
			this.option31.Checked = true;
			this.option31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.option31.Location = new System.Drawing.Point(365, 46);
			this.option31.Name = "option31";
			this.option31.Size = new System.Drawing.Size(39, 17);
			this.option31.TabIndex = 29;
			this.option31.TabStop = true;
			this.option31.Text = "3.1";
			this.option31.UseVisualStyleBackColor = true;
			// 
			// CreateDevEnvControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.option31);
			this.Controls.Add(this.option30);
			this.Controls.Add(this.checkIncludeBackCompat);
			this.Controls.Add(this.checkLaunch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.checkIncludeSample);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.buttonCreateDevEnv);
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
			this.Controls.SetChildIndex(this.buttonCreateDevEnv, 0);
			this.Controls.SetChildIndex(this.progressBar1, 0);
			this.Controls.SetChildIndex(this.labelStatus, 0);
			this.Controls.SetChildIndex(this.checkIncludeSample, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.checkLaunch, 0);
			this.Controls.SetChildIndex(this.checkIncludeBackCompat, 0);
			this.Controls.SetChildIndex(this.option30, 0);
			this.Controls.SetChildIndex(this.option31, 0);
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
		private System.Windows.Forms.Button buttonCreateDevEnv;
		private System.Windows.Forms.CheckBox checkIncludeSample;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckBox checkLaunch;
		private System.Windows.Forms.CheckBox checkIncludeBackCompat;
		private System.Windows.Forms.RadioButton option30;
		private System.Windows.Forms.RadioButton option31;
	}
}
