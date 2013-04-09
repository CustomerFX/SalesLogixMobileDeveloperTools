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
using FX.Mobile.DeveloperTools.Utility;

namespace FX.Mobile.DeveloperTools.UI
{
	public partial class FormMain : MetroFormBase
	{
		public FormMain()
		{
			InitializeComponent();

			WireControlMove(createDevEnvControl1);
			WireControlMove(createProductControl1);

			var thread = new Thread(new ThreadStart(NotificationCheck));
			thread.Start();
		}

		private void NotificationCheck()
		{
			var notification = Notifications.Get();
			if (notification == null)
			{
				this.SafeThreadAction(x => x.Controls["actionNotification"].Visible = false);
			}
			else
			{
				try
				{
					actionNotification.SafeThreadAction(x => x.Tag = notification.LinkAddress);
					actionNotification.SafeThreadAction(x => x.MainImageUrl = notification.ImageMainAddress);
					actionNotification.SafeThreadAction(x => x.HoverImageUrl = notification.ImageHoverAddress);

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

		private void actionStartMobile_ActionClicked(object sender, EventArgs e)
		{
			startMobileWebsiteControl1.SlideOut();
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
