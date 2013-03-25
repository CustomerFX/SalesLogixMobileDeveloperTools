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

		private void buttonCreateProduct_Click(object sender, EventArgs e)
		{
			if (textProductName.Text == "") return;
			if (textProductPath.Text == "") return;

			var deployment = new DeploymentManager(textProductPath.Text);

			if (option12.Checked && deployment.Version != MobileVersion.Version12 && deployment.HasSDK)
			{
				MessageBox.Show("You've selected to create a version 1.2 product but the target environment is a mobile 2.0 system. Change the version or select a different location.", "Mobile Version Does Not Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (option20.Checked && deployment.Version == MobileVersion.Version12 && deployment.HasSDK)
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
			buttonCreateProduct.Enabled = false;

			var product = new ProductManager(textProductPath.Text, option12.Checked ? MobileVersion.Version12 : MobileVersion.Version20);
			product.ProductCreateProgress += product_ProductCreateProgress;
			product.ProductCreateInitializing += product_ProductCreateInitializing;
			product.ProductCreateComplete += product_ProductCreateComplete;
			product.Create(textProductName.Text);
		}

		private void product_ProductCreateInitializing(object sender, ProductCreateEventArgs e)
		{
			progressBar1.Maximum = e.Total;
			progressBar1.Value = 0;
			labelStatus.Text = "Initializing product...";
			Application.DoEvents();
		}

		private void product_ProductCreateProgress(object sender, ProductCreateEventArgs e)
		{
			labelStatus.Text = "Creating file " + e.CurrentFile;
			progressBar1.Value = e.Count;
			Application.DoEvents();
			Thread.Sleep(200);
		}

		private void product_ProductCreateComplete(object sender, ProductCreateEventArgs e)
		{
			progressBar1.Value = 0;
			labelStatus.Text = string.Empty;

			progressBar1.Visible = false;
			labelStatus.Visible = false;
			buttonCreateProduct.Enabled = true;

			Application.DoEvents();
			MessageBox.Show("Product '" + textProductName.Text + "' created and is ready for use.", "Product Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Back();

			Program.CurrentDevSite = textProductPath.Text;
			Program.CurrentDevMobileVersion = (option12.Checked ? MobileVersion.Version12 : MobileVersion.Version20);
		}
	}
}
