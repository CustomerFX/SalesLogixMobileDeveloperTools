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

namespace FX.Mobile.DeveloperTools.UI
{
	public partial class MetroFormBase : Form
	{
		private Point downPoint = Point.Empty;

		public MetroFormBase()
		{
			InitializeComponent();
		}

		private void labelCfxLink_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://customerfx.com");
			}
			catch { }
		}

		private void buttonMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected override void OnLoad(EventArgs e)
		{
			if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
			{
				this.MouseDown += new MouseEventHandler(AppFormBase_MouseDown);
				this.MouseMove += new MouseEventHandler(AppFormBase_MouseMove);
				this.MouseUp += new MouseEventHandler(AppFormBase_MouseUp);
			}

			base.OnLoad(e);
		}

		protected override CreateParams CreateParams
		{
			get
			{
				const int CS_DROPSHADOW = 0x00020000;

				CreateParams cp = base.CreateParams;
				cp.ClassStyle |= CS_DROPSHADOW;
				return cp;
			}
		}

		void AppFormBase_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
			{
				return;
			}
			downPoint = new Point(e.X, e.Y);
		}

		void AppFormBase_MouseMove(object sender, MouseEventArgs e)
		{
			if (downPoint == Point.Empty)
			{
				return;
			}
			var location = new Point(
				this.Left + e.X - downPoint.X,
				this.Top + e.Y - downPoint.Y);
			this.Location = location;
		}

		void AppFormBase_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left)
			{
				return;
			}
			downPoint = Point.Empty;
		}

		public bool ShowMinimize
		{
			get { return buttonMinimize.Visible; }
			set { buttonMinimize.Visible = value; }
		}

		public bool ShowTitle
		{
			get { return labelTitle.Visible; }
			set { labelTitle.Visible = value; }
		}

		public bool ShowIcon
		{
			get { return iconApp.Visible; }
			set { iconApp.Visible = value; }
		}

		public void WireControlMove(Control control)
		{
			control.MouseMove += AppFormBase_MouseMove;
			control.MouseUp += AppFormBase_MouseUp;
			control.MouseDown += AppFormBase_MouseDown;
		}
	}
}
