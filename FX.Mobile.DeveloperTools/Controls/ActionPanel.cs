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
using Transitions;

namespace FX.Mobile.DeveloperTools.Controls
{
	public partial class ActionPanel : UserControl
	{
		public event EventHandler SlideOutComplete;

		public ActionPanel()
		{
			InitializeComponent();
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			var t = new Transition(new TransitionType_EaseInEaseOut(700));
			t.TransitionCompletedEvent += HideTransitionCompletedEvent;
			t.add(this, "Left", FindForm().Width);
			t.add(this, "BackColor", Color.Silver);
			t.run();
		}

		private void HideTransitionCompletedEvent(object sender, Transition.Args e)
		{
			this.Visible = false;
		}

		private void ShowTransitionCompletedEvent(object sender, Transition.Args e)
		{
			if (SlideOutComplete != null)
				SlideOutComplete(this, EventArgs.Empty);
		}

		public void Back()
		{
			buttonBack_Click(buttonBack, EventArgs.Empty);
		}

		public void SlideOut()
		{
			this.Location = new Point(FindForm().Width, 66);
			this.Visible = true;
			this.BackColor = Color.Silver;
			this.BringToFront();

			var t = new Transition(new TransitionType_EaseInEaseOut(700));
			t.TransitionCompletedEvent += ShowTransitionCompletedEvent;
			t.add(this, "Left", 15);
			t.add(this, "BackColor", Color.White);
			t.run();
		}
	}
}
