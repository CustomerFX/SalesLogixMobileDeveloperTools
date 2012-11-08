using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace FX.Mobile.DeveloperTools.Content
{
	public partial class CreateProductControl : Controls.ActionPanel
	{
		public CreateProductControl()
		{
			InitializeComponent();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			using (var dlg = new FolderBrowserDialog())
			{
				dlg.Description = "Select root of mobile development environment (where argos-sdk and products are subfolders)";
				if (textProductPath.Text != string.Empty) dlg.SelectedPath = textProductPath.Text;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					textProductPath.Text = dlg.SelectedPath;

					panelWarning.Visible = !(Directory.Exists(Path.Combine(textProductPath.Text, @"argos-sdk\")) && Directory.Exists(Path.Combine(textProductPath.Text, @"products\")));
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textProductName.Text == "") return;
			if (textProductPath.Text == "") return;

			if (Directory.Exists(Path.Combine(textProductPath.Text, @"products\argos-" + textProductName.Text.ToLower() + @"\")))
			{
				MessageBox.Show("The product '" + textProductName.Text + "' already exists at the selected path. Choose another name.", "Product Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			progressBar1.Visible = true;
			labelStatus.Visible = true;
			button1.Enabled = false;
			var _assembly = Assembly.GetExecutingAssembly();

			string version = "Mobile1_2";
			string baseNamespace = "FX.Mobile.DeveloperTools.Templates" + "." + version + ".";

			var resourceFiles = _assembly.GetManifestResourceNames();
			progressBar1.Maximum = resourceFiles.Length + 1;
			progressBar1.Value = 1;

			labelStatus.Text = "Initializing product...";
			Application.DoEvents();

			foreach (var resourceFile in resourceFiles)
			{
				Thread.Sleep(100);
				Application.DoEvents();

				if (resourceFile.StartsWith(baseNamespace))
				{
					using (var reader = new StreamReader(_assembly.GetManifestResourceStream(resourceFile)))
					{
						var fileContents = reader.ReadToEnd();
						fileContents = fileContents.Replace("[MODULE:Custom]", textProductName.Text);
						fileContents = fileContents.Replace("[MODULE-LC:Custom]", textProductName.Text.ToLower());

						var fileName = resourceFile.Replace(baseNamespace, "");

						var filePath = Path.Combine(textProductPath.Text, @"products\");
						if (!Directory.Exists(filePath))
							Directory.CreateDirectory(filePath);

						filePath = Path.Combine(filePath, "argos-" + textProductName.Text.ToLower());
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
							fileName = fileName.Replace("custom", textProductName.Text.ToLower());
							filePath = textProductPath.Text;
						}
						if (fileName == "index-dev-custom.html")
						{
							fileName = fileName.Replace("custom", textProductName.Text.ToLower());
							filePath = Path.Combine(textProductPath.Text, @"products\argos-saleslogix\");
							if (!Directory.Exists(filePath))
								Directory.CreateDirectory(filePath);
						}

						labelStatus.Text = "Creating file " + fileName;
						Application.DoEvents();

						using (var writer = new StreamWriter(Path.Combine(filePath, fileName)))
						{
							writer.Write(fileContents);
						}
					}
				}

				progressBar1.Value++;
				Application.DoEvents();
			}

			progressBar1.Value = 0;
			labelStatus.Text = "";
			progressBar1.Visible = false;
			labelStatus.Visible = false;
			button1.Enabled = true;

			Application.DoEvents();
			MessageBox.Show("Product '" + textProductName.Text + "' created and is ready for use.", "Product Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Back();
		}
	}
}
