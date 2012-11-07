using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace FX.Mobile.DeveloperTools
{
	public partial class FormMain : Form
	{
		public Point downPoint = Point.Empty;

		public FormMain()
		{
			InitializeComponent();
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

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void labelCfxLink_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://customerfx.com");
			}
			catch { }
		}

		private void imageButton_MouseEnterLeave(object sender, EventArgs e)
		{
			//swap images
			PictureBox pMain = (PictureBox)sender;
			PictureBox pBack = (PictureBox)this.Controls[pMain.Name + "Selected"];

			Image img = pMain.Image;
			pMain.Image = pBack.Image;
			pBack.Image = img;
		}

		private void imageButtonCreateProduct_Click(object sender, EventArgs e)
		{
			createProductControl1.Location = new Point(687, 66);
			createProductControl1.Visible = true;
			createProductControl1.BackColor = Color.Silver;
			createProductControl1.BringToFront();

			var t = new Transition(new TransitionType_EaseInEaseOut(700));
			t.add(createProductControl1, "Left", 15);
			t.add(createProductControl1, "BackColor", Color.White);
			t.run();
		}

		private void imageButtonCreateNewDevEnv_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This feature is not yet available", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
