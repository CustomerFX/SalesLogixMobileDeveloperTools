﻿#region License Information
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
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FX.Mobile.DeveloperTools.Controls;
using Microsoft.Win32;

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
				Path = "\"" + Program.Path + "\"",
				Port = int.Parse(Program.Port)
			}, string.Format(@"C:\Program Files{0}\IIS Express\iisexpress.exe", Is64bit() ? " (x86)" : "")))
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
			return (Directory.Exists(string.Format(@"C:\Program Files{0}\IIS Express", Is64bit() ? " (x86)" : "")));
		}

		private static bool Is64bit()
		{
			using (var key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\"))
			{
				return key.GetValue("ProgramFilesDir (x86)") != null;
			}
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
