using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			Point location = new Point(
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
