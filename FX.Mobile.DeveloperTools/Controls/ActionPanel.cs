using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace FX.Mobile.DeveloperTools.Controls
{
	public partial class ActionPanel : UserControl
	{
		public ActionPanel()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			var t = new Transition(new TransitionType_EaseInEaseOut(700));
			t.TransitionCompletedEvent += t_TransitionCompletedEvent;
			t.add(this, "Left", this.FindForm().Width);
			t.add(this, "BackColor", Color.Silver);
			t.run();
		}

		private void t_TransitionCompletedEvent(object sender, Transition.Args e)
		{
			this.Visible = false;
		}

		public void Back()
		{
			buttonBack_Click(buttonBack, EventArgs.Empty);
		}

		public void SlideOut()
		{
			this.Location = new Point(this.FindForm().Width, 66);
			this.Visible = true;
			this.BackColor = Color.Silver;
			this.BringToFront();

			var t = new Transition(new TransitionType_EaseInEaseOut(700));
			t.add(this, "Left", 15);
			t.add(this, "BackColor", Color.White);
			t.run();
		}
	}
}
