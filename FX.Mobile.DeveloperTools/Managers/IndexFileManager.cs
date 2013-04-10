using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;
using FX.Mobile.DeveloperTools.Model;

namespace FX.Mobile.DeveloperTools.Managers
{
	public class IndexFileManager
	{
		private const string IndexFileResource = "FX.Mobile.DeveloperTools.Templates.index.html";
		private const string IndexItemFileResource = "FX.Mobile.DeveloperTools.Templates.index-item.html";

		public IndexFileManager()
		{
			Packages = new List<ResourcePackage>();
		}

		public List<ResourcePackage> Packages { get; set; }

		public void CreateIndex(string FilePath)
		{
			var templateManager = new TemplateManager();
			
			var replacements = new List<StringReplacement>();
			replacements.Add(new StringReplacement { Pattern = "<!--$PRODUCTLIST$-->", Value = GetProductList() });

			string indexText = templateManager.GetTemplate(IndexFileResource, replacements);

			using (var writer = new StreamWriter(Path.Combine(FilePath, "index.html")))
			{
				writer.Write(indexText);
			}
		}

		private string GetProductList()
		{
			var templateManager = new TemplateManager();
			string itemText = string.Empty;

			var cultureInfo = Thread.CurrentThread.CurrentCulture;
			var textInfo = cultureInfo.TextInfo;

			foreach (var package in Packages)
			{
				if (package.Repository.ToLower() == "argos-sdk")
					continue;

				string module = package.Repository.Replace("argos-", "");
				module = textInfo.ToTitleCase(module);
				module = module.Replace("Saleslogix", "SalesLogix");

				string filePrefix = "-" + module.ToLower();
				if (filePrefix == "-saleslogix") filePrefix = "";

				var replacements = new List<StringReplacement>();
				replacements.Add(new StringReplacement { Pattern = "$PRODUCTNAME$", Value = module });
				replacements.Add(new StringReplacement { Pattern = "$PRODUCTNAMEFILE$", Value = filePrefix });

				itemText += templateManager.GetTemplate(IndexItemFileResource, replacements);
			}

			return itemText + "\r\n<!--$PRODUCTLIST$-->";
		}
	}
}