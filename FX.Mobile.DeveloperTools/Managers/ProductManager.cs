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
using System.Collections.Generic;
using System.IO;
using FX.Mobile.DeveloperTools.Model;

namespace FX.Mobile.DeveloperTools.Managers
{
	public class ProductManager
	{
		public event EventHandler<ProductCreateEventArgs> ProductCreateProgress;
		public event EventHandler<ProductCreateEventArgs> ProductCreateInitializing;
		public event EventHandler<ProductCreateEventArgs> ProductCreateComplete;

		public ProductManager(string MobilePath, MobileVersion Version)
		{
			this.MobilePath = MobilePath;
			this.Version = Version;
		}

		public string MobilePath { get; set; }
		public MobileVersion Version { get; set; }

		public void Create(string ProductName)
		{
			string version = GetTemplateVersion();
			string baseNamespace = "FX.Mobile.DeveloperTools.Templates" + "." + version + ".";

			var template = new TemplateManager();
			var templateFiles = template.GetTemplateList();

			int total = 0;
			int count = 1;
			foreach (var templateFile in templateFiles)
			{
				if (templateFile.StartsWith(baseNamespace))
					total++;
			}

			if (ProductCreateInitializing != null)
				ProductCreateInitializing(this, new ProductCreateEventArgs { Count = 0, CurrentFile = string.Empty, Total = total });

			var replacements = new List<StringReplacement>();
			replacements.Add(new StringReplacement { Pattern = "[MODULE:Custom]", Value = ProductName });
			replacements.Add(new StringReplacement { Pattern = "[MODULE-LC:Custom]", Value = ProductName.ToLower() });

			foreach (var templateFile in templateFiles)
			{
				if (templateFile.StartsWith(baseNamespace))
				{
					var fileContents = template.GetTemplate(templateFile, replacements);
					var fileName = templateFile.Replace(baseNamespace, "");

					var filePath = Path.Combine(MobilePath, @"products\");
					if (!Directory.Exists(filePath))
						Directory.CreateDirectory(filePath);

					filePath = Path.Combine(filePath, "argos-" + ProductName.ToLower());
					if (!Directory.Exists(filePath))
						Directory.CreateDirectory(filePath);

					//check if sub directory
					var parts = fileName.Split('.');
					if (parts.Length > 2)
					{
						for (int i = 0; i < parts.Length - 2; i++)
						{
							filePath = Path.Combine(filePath, parts[i]);
							if (!Directory.Exists(filePath))
								Directory.CreateDirectory(filePath);

							fileName = fileName.Replace(parts[i] + ".", "");
						}
					}

					if (fileName == "build-custom.cmd")
					{
						fileName = fileName.Replace("custom", ProductName.ToLower());
						filePath = MobilePath;
					}
					if (fileName == "index-dev-custom.html")
					{
						fileName = fileName.Replace("custom", ProductName.ToLower());
						filePath = Path.Combine(MobilePath, @"products\argos-saleslogix\");
						if (!Directory.Exists(filePath))
							Directory.CreateDirectory(filePath);
					}

					if (ProductCreateProgress != null)
						ProductCreateProgress(this, new ProductCreateEventArgs { Count = count, CurrentFile = fileName, Total = total });

					count++;

					using (var writer = new StreamWriter(Path.Combine(filePath, fileName)))
					{
						writer.Write(fileContents);
					}
				}
			}

			if (ProductCreateComplete != null)
				ProductCreateComplete(this, new ProductCreateEventArgs { Count = count, CurrentFile = string.Empty, Total = total });
		}

		private string GetTemplateVersion()
		{
			switch (this.Version)
			{
				case MobileVersion.Version12:
					return "Mobile1_2";
				case MobileVersion.Version20:
					return "Mobile2_0";
				default:
					return "Mobile1_2";
			}
		}
	}

	public class ProductCreateEventArgs : EventArgs
	{
		public string CurrentFile { get; set; }
		public int Count { get; set; }
		public int Total { get; set; }
	}
}
