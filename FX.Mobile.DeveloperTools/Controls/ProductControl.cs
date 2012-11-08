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
	public partial class ProductControl : UserControl
	{
		public event EventHandler ProductOptionSelected;

		public ProductControl(string ArgosProduct)
		{
			InitializeComponent();

			this.ArgosProduct = ArgosProduct;
		}

		public string ArgosProduct
		{
			get { return labelProduct.Text; }
			set
			{
				labelProduct.Text = value;
				buttonStartProd.Visible = (value == "argos-saleslogix");
			}
		}

		public string SelectedConfiguration { get; set; }

		private void buttonStartProd_Click(object sender, EventArgs e)
		{
			SelectedConfiguration = "";
			if (ProductOptionSelected != null)
				ProductOptionSelected(this, EventArgs.Empty);
		}

		private void buttonStartDev_Click(object sender, EventArgs e)
		{
			SelectedConfiguration = "dev";
			if (ProductOptionSelected != null)
				ProductOptionSelected(this, EventArgs.Empty);
		}
	}
}
