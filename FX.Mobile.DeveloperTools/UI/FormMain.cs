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
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace FX.Mobile.DeveloperTools.UI
{
	public partial class FormMain : MetroFormBase
	{
		public FormMain()
		{
			InitializeComponent();

			WireControlMove(createDevEnvControl1);
			WireControlMove(createProductControl1);

			var thread = new Thread(new ThreadStart(this.NotificationCheck));
			thread.Start();
		}

		private void NotificationCheck()
		{
			var client = new WebClient();
			string notification = client.DownloadString("http://cfxconnect.com/applications/SalesLogixMobileDeveloperTools/notification.txt");

			if (string.IsNullOrEmpty(notification))
			{
				this.SafeThreadAction(x => x.Controls["actionNotification"].Visible = false);
			}
			else
			{
				try
				{
					string[] notificationParts = notification.Split('|');
					actionNotification.SafeThreadAction(x => x.Tag = notificationParts[0]);
					actionNotification.SafeThreadAction(x => x.MainImageUrl = notificationParts[1]);
					actionNotification.SafeThreadAction(x => x.HoverImageUrl = notificationParts[2]);

					this.SafeThreadAction(x => x.Controls["actionNotification"].Visible = true);
				}
				catch { }
			}
		}

		private void actionCreateProduct_ActionClicked(object sender, EventArgs e)
		{
			createProductControl1.SlideOut();
		}

		private void actionCreateDevEnv_ActionClicked(object sender, EventArgs e)
		{
			createDevEnvControl1.SlideOut();
		}

		private void actionGetInformation_ActionClicked(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://customerfx.com/pages/crmdeveloper/pages/saleslogix-mobile-developer-series.aspx");
			}
			catch { }
		}

		private void actionNotification_ActionClicked(object sender, EventArgs e)
		{
			if (actionNotification.Tag == null && !string.IsNullOrEmpty(actionNotification.Tag.ToString()))
				return;

			try
			{
				System.Diagnostics.Process.Start(actionNotification.Tag.ToString());
			}
			catch { }
		}
	}
}
