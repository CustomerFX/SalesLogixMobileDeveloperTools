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

		private void actionCreateProduct_ActionClicked(object sender, EventArgs e)
		{
			createProductControl1.SlideOut();
		}

		private void actionCreateDevEnv_ActionClicked(object sender, EventArgs e)
		{
			createDevEnvControl1.SlideOut();
		}
	}
}
