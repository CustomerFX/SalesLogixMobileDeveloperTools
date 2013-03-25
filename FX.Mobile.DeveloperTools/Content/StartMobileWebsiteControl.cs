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
using System.Windows.Forms;
using FX.Mobile.DeveloperTools.Controls;
using FX.Mobile.DeveloperTools.Managers;

namespace FX.Mobile.DeveloperTools.Content
{
	public partial class StartMobileWebsiteControl : ActionPanel
	{
		public StartMobileWebsiteControl()
		{
			InitializeComponent();

			SlideOutComplete += (sender, args) =>
			{
				if (!string.IsNullOrEmpty(Program.CurrentDevSite))
				{
					textProductPath.Text = Program.CurrentDevSite;
				}
			};
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

					var deployment = new DeploymentManager(textProductPath.Text);
					panelWarning.Visible = !(deployment.HasSDK && deployment.HasProducts);
				}
			}
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (textProductPath.Text == string.Empty)
				return;

			if (panelWarning.Visible)
				return;

			var launcher = new LaunchManager();
			launcher.Launch(textProductPath.Text);

			FindForm().Close();
		}
	}
}
