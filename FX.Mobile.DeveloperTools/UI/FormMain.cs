using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transitions;

namespace FX.Mobile.DeveloperTools.UI
{
	public partial class FormMain : MetroFormBase
	{
		public FormMain()
		{
			InitializeComponent();

			WireControlMove(createDevEnvControl1);
			WireControlMove(createProductControl1);
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
			createProductControl1.SlideOut();
		}

		private void imageButtonCreateNewDevEnv_Click(object sender, EventArgs e)
		{
			createDevEnvControl1.SlideOut();
		}
	}
}
