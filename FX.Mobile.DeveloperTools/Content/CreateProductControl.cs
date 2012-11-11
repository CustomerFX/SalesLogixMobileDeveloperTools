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
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using FX.Mobile.DeveloperTools.Managers;

namespace FX.Mobile.DeveloperTools.Content
{
	public partial class CreateProductControl : Controls.ActionPanel
	{
		public CreateProductControl()
		{
			InitializeComponent();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			using (var dlg = new FolderBrowserDialog())
			{
				dlg.Description = "Select root of mobile development environment (where argos-sdk and products are subfolders)";
				if (textProductPath.Text != string.Empty) dlg.SelectedPath = textProductPath.Text;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					textProductPath.Text = dlg.SelectedPath;

					var deployment = new DeploymentManager(textProductPath.Text);
					panelWarning.Visible = !(deployment.HasSDK && deployment.HasProducts);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textProductName.Text == "") return;
			if (textProductPath.Text == "") return;

			var deployment = new DeploymentManager(textProductPath.Text);

			if (option12.Checked && deployment.Version != DeploymentVersion.Version12 && deployment.HasSDK)
			{
				MessageBox.Show("You've selected to create a version 1.2 product but the target environment is not a mobile 1.2 system. Change the version or select a different location.", "Mobile Version Does Not Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (option20.Checked && deployment.Version == DeploymentVersion.Version12 && deployment.HasSDK)
			{
				MessageBox.Show("You've selected to create a version 2.0 product but the target environment is a mobile 1.2 system. Change the version or select a different location.", "Mobile Version Does Not Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (deployment.ProductExists(textProductName.Text))
			{
				MessageBox.Show("The product '" + textProductName.Text + "' already exists at the selected path. Choose another name.", "Product Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			progressBar1.Visible = true;
			labelStatus.Visible = true;
			button1.Enabled = false;
			var _assembly = Assembly.GetExecutingAssembly();

			string version = (option12.Checked ? "Mobile1_2" : "Mobile2_0");
			string baseNamespace = "FX.Mobile.DeveloperTools.Templates" + "." + version + ".";

			var resourceFiles = _assembly.GetManifestResourceNames();
			progressBar1.Maximum = resourceFiles.Length + 1;
			progressBar1.Value = 1;

			labelStatus.Text = "Initializing product...";
			Application.DoEvents();

			foreach (var resourceFile in resourceFiles)
			{
				Thread.Sleep(100);
				Application.DoEvents();

				if (resourceFile.StartsWith(baseNamespace))
				{
					using (var reader = new StreamReader(_assembly.GetManifestResourceStream(resourceFile)))
					{
						var fileContents = reader.ReadToEnd();
						fileContents = fileContents.Replace("[MODULE:Custom]", textProductName.Text);
						fileContents = fileContents.Replace("[MODULE-LC:Custom]", textProductName.Text.ToLower());

						var fileName = resourceFile.Replace(baseNamespace, "");

						var filePath = Path.Combine(textProductPath.Text, @"products\");
						if (!Directory.Exists(filePath))
							Directory.CreateDirectory(filePath);

						filePath = Path.Combine(filePath, "argos-" + textProductName.Text.ToLower());
						if (!Directory.Exists(filePath))
							Directory.CreateDirectory(filePath);

						//check if sub directory
						var parts = fileName.Split('.');
						if (parts.Length > 2)
						{
							for (int i = 0; i < parts.Length - 2; i++)
							{
								filePath = Path.Combine(filePath, parts[i]);
								if (!Directory.Exists(filePath))
									Directory.CreateDirectory(filePath);

								fileName = fileName.Replace(parts[i] + ".", "");
							}
						}

						if (fileName == "build-custom.cmd")
						{
							fileName = fileName.Replace("custom", textProductName.Text.ToLower());
							filePath = textProductPath.Text;
						}
						if (fileName == "index-dev-custom.html")
						{
							fileName = fileName.Replace("custom", textProductName.Text.ToLower());
							filePath = Path.Combine(textProductPath.Text, @"products\argos-saleslogix\");
							if (!Directory.Exists(filePath))
								Directory.CreateDirectory(filePath);
						}

						labelStatus.Text = "Creating file " + fileName;
						Application.DoEvents();

						using (var writer = new StreamWriter(Path.Combine(filePath, fileName)))
						{
							writer.Write(fileContents);
						}
					}
				}

				progressBar1.Value++;
				Application.DoEvents();
			}

			progressBar1.Value = 0;
			labelStatus.Text = "";
			progressBar1.Visible = false;
			labelStatus.Visible = false;
			button1.Enabled = true;

			Application.DoEvents();
			MessageBox.Show("Product '" + textProductName.Text + "' created and is ready for use.", "Product Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Back();
		}
	}
}
