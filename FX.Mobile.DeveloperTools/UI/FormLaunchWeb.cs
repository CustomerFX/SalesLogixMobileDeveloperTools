using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FX.Mobile.DeveloperTools.Controls;

namespace FX.Mobile.DeveloperTools.UI
{
	public partial class FormLaunchWeb : FX.Mobile.DeveloperTools.UI.MetroFormBase
	{
		public FormLaunchWeb()
		{
			InitializeComponent();
		}

		private void FormLaunchWeb_Load(object sender, EventArgs e)
		{
			if (!IsIisExpressInstalled())
			{
				panelError.Visible = true;
				WireControlMove(panelError);
				return;
			}

			var productList = new List<string>();

			var directories = Directory.GetDirectories(Path.Combine(Program.Path, "products"));
			foreach (var directory in directories)
			{
				string[] prodNameParts = directory.Split('\\');
				productList.Add(prodNameParts[prodNameParts.Length-1]);
			}

			productList.Reverse();

			foreach (var prod in productList)
			{
				if (prod != "argos-saleslogix")
					AddProduct(prod);
			}

			if (productList.Contains("argos-saleslogix"))
				AddProduct("argos-saleslogix");
		}

		private void AddProduct(string name)
		{
			var prodCtrl = new ProductControl(name);
			prodCtrl.ProductOptionSelected += prodCtrl_ProductOptionSelected;
			panelProductList.Controls.Add(prodCtrl);
			prodCtrl.Dock = DockStyle.Top;

			if (name == "argos-saleslogix")
				panelProductList.ScrollControlIntoView(prodCtrl);
		}

		private void prodCtrl_ProductOptionSelected(object sender, EventArgs e)
		{
			Program.Port = textPort.Text;

			var prodCtrl = (ProductControl)sender;
			string url = string.Format("http://localhost:{0}/products/argos-saleslogix/index{1}{2}{3}.html", Program.Port, (prodCtrl.SelectedConfiguration != string.Empty ? "-" : ""), prodCtrl.SelectedConfiguration, (prodCtrl.ArgosProduct != "argos-saleslogix" ? prodCtrl.ArgosProduct.ToLower().Replace("argos", "") : ""));

			using (var iis = new IISExpressAutomation.IISExpress(new IISExpressAutomation.Parameters
			{
				Path = Program.Path,
				Port = int.Parse(Program.Port)
			}))
			{
				try
				{
					System.Diagnostics.Process.Start(url);
				}
				catch { }
			}
		}

		private void labelGetIisExpress_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("http://www.microsoft.com/en-us/download/details.aspx?id=1038");
			}
			catch { }

			this.Close();
		}

		private bool IsIisExpressInstalled()
		{
			return (Directory.Exists(@"C:\Program Files (x86)\IIS Express"));
		}

		private void textPort_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}

		private void textPort_Leave(object sender, EventArgs e)
		{
			if (textPort.Text.Trim() == "")
				textPort.Text = "12684";
		}
	}
}
