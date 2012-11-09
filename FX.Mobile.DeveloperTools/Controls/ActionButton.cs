using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FX.Mobile.DeveloperTools.Controls
{
	public partial class ActionButton : UserControl
	{
		public event EventHandler ActionClicked;

		public ActionButton()
		{
			InitializeComponent();
		}

		public Image MainImage
		{
			get { return imageMain.Image; }
			set { imageMain.Image = value; }
		}

		public Image HoverImage
		{
			get { return imageHover.Image; }
			set { imageHover.Image = value; }
		}

		private void imageMain_Click(object sender, EventArgs e)
		{
			if (ActionClicked != null)
				ActionClicked(this, EventArgs.Empty);
		}

		private void imageButton_MouseEnterLeave(object sender, EventArgs e)
		{
			//swap images
			Image img = imageMain.Image;
			imageMain.Image = imageHover.Image;
			imageHover.Image = img;
		}
	}
}
