#region License Information
/* 

	SalesLogix Mobile Developer Tools
	Copyright (C) 2012  Customer FX Corporation - http://customerfx.com/

	This program is free software: you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation, either version 3 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program.  If not, see <http://www.gnu.org/licenses/>.
	
	ADDITIONAL TERMS: 
	The "Customer FX" link to customerfx.com on the main form must 
	remain visible and in-tact on any forks or use of this source code.

	Contact Information:
	
	Ryan Farley 
	Customer FX Corporation
	http://customerfx.com/
	2324 University Avenue West, Suite 115
	Saint Paul, Minnesota 55114
	Tel: 651.646.7777  Fax: 651.846.5185
	
	This copyright must remain intact
	
*/
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using FX.Mobile.DeveloperTools.Managers;

namespace FX.Mobile.DeveloperTools.Content
{
	public partial class CreateDevEnvControl : Controls.ActionPanel
	{
		public CreateDevEnvControl()
		{
			InitializeComponent();

			SlideOutComplete += (sender, args) =>
			{
				if (!string.IsNullOrEmpty(Program.CurrentDevSite))
				{
					textProductPath.Text = Program.CurrentDevSite;
					option12.Checked = (Program.CurrentDevMobileVersion == MobileVersion.Version12);
					option20.Checked = (Program.CurrentDevMobileVersion == MobileVersion.Version20);
				}
			};
		}

		private void buttonCreateDevEnv_Click(object sender, EventArgs e)
		{
			if (textProductPath.Text == string.Empty)
				return;

			var deployment = new DeploymentManager(textProductPath.Text);
			if (deployment.HasSDK)
			{
				MessageBox.Show("The selected path already has a mobile environment. Choose another path.", "Mobile Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			labelStatus.Visible = true;
			progressBar1.Visible = true;
			buttonCreateDevEnv.Enabled = false;

			var mobileResources = new MobileResourceManager(textProductPath.Text, (option12.Checked ? MobileVersion.Version12 : MobileVersion.Version20));
			mobileResources.IncludeArgosSample = checkIncludeSample.Checked;
			mobileResources.IncludeArgos754Compatability = checkIncludeBackCompat.Checked;
			mobileResources.ResourceInstallInitializing += mobileResources_ResourceInstallInitializing;
			mobileResources.ResourceInstallProgress += mobileResources_ResourceInstallProgress;
			mobileResources.ResourceInstallStepUpdate += mobileResources_ResourceInstallStepUpdate;
			mobileResources.ResourceInstallComplete += mobileResources_ResourceInstallComplete;
			mobileResources.Install();

			Program.CurrentDevSite = textProductPath.Text;
			Program.CurrentDevMobileVersion = (option12.Checked ? MobileVersion.Version12 : MobileVersion.Version20);
		}

		private void mobileResources_ResourceInstallInitializing(object sender, MobileResourceInstallEventArgs e)
		{
			progressBar1.Maximum = e.StepTotal;
			progressBar1.Value = e.StepNumber;

			labelStatus.Text = "Initializing downloads...";
			Application.DoEvents();
		}

		private void mobileResources_ResourceInstallProgress(object sender, MobileResourceInstallEventArgs e)
		{
			string status = string.Format("{0} {1}", e.Action, e.CurrentPackage).Trim();
			switch (e.Action)
			{
				case "Downloading":
					status += string.Format(" ({0}% complete)", e.ProgressPercentage);
					break;
				case "Extracting":
					status += string.Format(" ({0} of {1} files complete)", e.ProgressCurrentFile, e.ProgressTotalFiles);
					break;
			}

			labelStatus.Text = status;
			Application.DoEvents();
		}

		private void mobileResources_ResourceInstallStepUpdate(object sender, MobileResourceInstallEventArgs e)
		{
			progressBar1.Value = e.StepNumber;
			Application.DoEvents();
		}

		private void mobileResources_ResourceInstallComplete(object sender, MobileResourceInstallEventArgs e)
		{
			buttonCreateDevEnv.Enabled = true;
			progressBar1.Visible = false;
			labelStatus.Visible = false;

			if (checkLaunch.Checked)
			{
				var launcher = new LaunchManager();
				launcher.Launch(textProductPath.Text);
				this.FindForm().Close();
			}
			else
			{
				MessageBox.Show("The mobile development environment has been created. To start the website use the 'Start Mobile Website' shortcut located at the root of the website.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Back();
			}
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			using (var dlg = new FolderBrowserDialog())
			{
				dlg.Description = "Select root of mobile development environment";
				if (textProductPath.Text != string.Empty) dlg.SelectedPath = textProductPath.Text;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					textProductPath.Text = dlg.SelectedPath;
				}
			}
		}

		private void VersionOptionChanged(object sender, EventArgs e)
		{
			if (option20.Checked)
			{
				checkIncludeBackCompat.Visible = true;

				checkIncludeSample.Location = new Point(211, 150);
				checkLaunch.Location = new Point(211, 176);
			}
			else
			{
				checkIncludeBackCompat.Visible = false;
				checkIncludeBackCompat.Checked = false;

				checkIncludeSample.Location = new Point(211, 124);
				checkLaunch.Location = new Point(211, 150);
			}
		}
	}
}
