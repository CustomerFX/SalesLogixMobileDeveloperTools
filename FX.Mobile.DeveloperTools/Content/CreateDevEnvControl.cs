﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Ionic.Zip;
using FX.Mobile.DeveloperTools.Utility;

namespace FX.Mobile.DeveloperTools.Content
{
	public partial class CreateDevEnvControl : Controls.ActionPanel
	{
		public CreateDevEnvControl()
		{
			InitializeComponent();
		}

		string version = "1.2";
		string currFile = "";

		private void button1_Click(object sender, EventArgs e)
		{
			if (textProductPath.Text == string.Empty)
				return;

			if (Directory.Exists(Path.Combine(textProductPath.Text, "argos-sdk")))
			{
				MessageBox.Show("The selected path already has a mobile environment. Choose another path.", "Mobile Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			version = (option12.Checked ? "1.2" : "2.0");

			labelStatus.Visible = true;
			progressBar1.Visible = true;
			progressBar1.Maximum = (checkIncludeSample.Checked ? 6 : 5);
			progressBar1.Value = 0;
			button1.Enabled = false;

			labelStatus.Text = "Initializing downloads...";
			Application.DoEvents();

			currFile = "argos-sdk " + version;
			var webClient = new WebClient();
			webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
			webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;
			webClient.DownloadFileAsync(new Uri("https://github.com/Sage/argos-sdk/archive/" + version + ".zip"), Path.Combine(textProductPath.Text, "argos-sdk-" + version + ".zip"));
		}

		void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			progressBar1.Value++;
			Application.DoEvents();

			currFile = "argos-saleslogix " + version;

			var webClient = new WebClient();
			webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
			if (checkIncludeSample.Checked)
				webClient.DownloadFileCompleted += webClient_DownloadFileCompletedSample;
			else
				webClient.DownloadFileCompleted += webClient_DownloadFileCompletedContinue;
			webClient.DownloadFileAsync(new Uri("https://github.com/SageSalesLogix/argos-saleslogix/archive/" + version + ".zip"), Path.Combine(textProductPath.Text, "argos-saleslogix-" + version + ".zip"));
		}

		void webClient_DownloadFileCompletedSample(object sender, AsyncCompletedEventArgs e)
		{
			progressBar1.Value++;
			Application.DoEvents();

			currFile = "argos-sample " + version;

			var webClient = new WebClient();
			webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
			webClient.DownloadFileCompleted += webClient_DownloadFileCompletedContinue;
			webClient.DownloadFileAsync(new Uri("https://github.com/SageSalesLogix/argos-sample/archive/" + (version == "2.0" ? "master" : version) + ".zip"), Path.Combine(textProductPath.Text, "argos-sample-" + version + ".zip"));
		}

		void webClient_DownloadFileCompletedContinue(object sender, AsyncCompletedEventArgs e)
		{
			progressBar1.Value++;

			labelStatus.Text = "Extracting argos-sdk " + version;
			Application.DoEvents();

			currFile = "argos-sdk " + version;

			using (var zip = ZipFile.Read(Path.Combine(textProductPath.Text, "argos-sdk-" + version + ".zip")))
			{
				int total = zip.Count;
				int count = 1;
				
				foreach (ZipEntry file in zip)
				{
					file.Extract(textProductPath.Text, ExtractExistingFileAction.OverwriteSilently);

					labelStatus.Text = string.Format("Extracting {0} ({1} of {2} files complete)", currFile, count, total);
					Application.DoEvents();
					count++;
				}
			}

			var dir = new DirectoryInfo(Path.Combine(textProductPath.Text, "argos-sdk-" + version));
			dir.MoveTo(Path.Combine(textProductPath.Text, "argos-sdk"));
			File.Delete(Path.Combine(textProductPath.Text, "argos-sdk-" + version + ".zip"));

			progressBar1.Value++;
			Application.DoEvents();

			if (!Directory.Exists(Path.Combine(textProductPath.Text, "products")))
				Directory.CreateDirectory(Path.Combine(textProductPath.Text, "products"));

			currFile = "argos-saleslogix " + version;

			using (var zip = ZipFile.Read(Path.Combine(textProductPath.Text, "argos-saleslogix-" + version + ".zip")))
			{
				int total = zip.Count;
				int count = 1;

				foreach (ZipEntry file in zip)
				{
					file.Extract(Path.Combine(textProductPath.Text, "products"), ExtractExistingFileAction.OverwriteSilently);

					labelStatus.Text = string.Format("Extracting {0} ({1} of {2} files complete)", currFile, count, total);
					Application.DoEvents();
					count++;
				}
			}

			var dirProd = new DirectoryInfo(Path.Combine(Path.Combine(textProductPath.Text, "products"), "argos-saleslogix-" + version));
			dirProd.MoveTo(Path.Combine(Path.Combine(textProductPath.Text, "products"), "argos-saleslogix"));
			File.Delete(Path.Combine(textProductPath.Text, "argos-saleslogix-" + version + ".zip"));

			progressBar1.Value++;
			Application.DoEvents();

			if (checkIncludeSample.Checked)
			{
				currFile = "argos-sample " + version;

				using (var zip = ZipFile.Read(Path.Combine(textProductPath.Text, "argos-sample-" + version + ".zip")))
				{
					int total = zip.Count;
					int count = 1;

					foreach (ZipEntry file in zip)
					{
						file.Extract(Path.Combine(textProductPath.Text, "products"), ExtractExistingFileAction.OverwriteSilently);

						labelStatus.Text = string.Format("Extracting {0} ({1} of {2} files complete)", currFile, count, total);
						Application.DoEvents();
						count++;
					}
				}

				var dirSample = new DirectoryInfo(Path.Combine(Path.Combine(textProductPath.Text, "products"), "argos-sample-" + (version == "2.0" ? "master" : version)));
				dirSample.MoveTo(Path.Combine(Path.Combine(textProductPath.Text, "products"), "argos-sample"));
				File.Delete(Path.Combine(textProductPath.Text, "argos-sample-" + version + ".zip"));

				File.Move(Path.Combine(textProductPath.Text, @"products\argos-sample\index-dev-sample.html"), Path.Combine(textProductPath.Text, @"products\argos-saleslogix\index-dev-sample.html"));

				progressBar1.Value++;
				Application.DoEvents();
			}

			using (var writer = new StreamWriter(Path.Combine(textProductPath.Text, "SalesLogix Mobile Version " + version + ".txt")))
			{
				writer.WriteLine("SalesLogix Mobile Version " + version);
				writer.WriteLine("Development Environment");
				writer.WriteLine("------------------------------------------------");
				writer.WriteLine("\r\n\r\n");
				writer.WriteLine("Use the 'Start Mobile Website link to start the website in  IIS Express");
				writer.WriteLine("or open IIS and add a new website to point to this directory.");
				writer.WriteLine("\r\n");
				writer.WriteLine("To access production configuration visit:");
				writer.WriteLine("http://MobileWebsiteRoot/products/argos-saleslogix/index.html");
				writer.WriteLine("\r\n");
				writer.WriteLine("To access development configuration visit:");
				writer.WriteLine("http://MobileWebsiteRoot/products/argos-saleslogix/index-dev.html");
				writer.WriteLine("\r\n\r\n");
				writer.WriteLine("------------------------------------------------");
				writer.WriteLine("SalesLogix Mobile Development Tools");
				writer.WriteLine("http://customerfx.com");
			}

			using (var link = new ShellLink())
			{
				link.Target = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FX.Mobile.DeveloperTools.Launcher.exe");
				link.Description = "Start Mobile Website";
				link.DisplayMode = ShellLink.LinkDisplayMode.edmNormal;
				link.Arguments = "\"/path:" + textProductPath.Text + "\" /port:3678";
				link.Save(Path.Combine(textProductPath.Text, link.Description + ".lnk"));
			}

			MessageBox.Show("The mobile development environment has been created. To start the website use the 'Start Mobile Website' shortcut located at the root of the website.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			button1.Enabled = true;
			this.Back();
			progressBar1.Visible = false;
			labelStatus.Visible = false;
		}

		void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			labelStatus.Text = string.Format("Downloading {0} ({1}% complete)", currFile, e.ProgressPercentage);
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			using (var dlg = new FolderBrowserDialog())
			{
				dlg.Description = "Select root of mobile development environment";
				if (textProductPath.Text != string.Empty) dlg.SelectedPath = textProductPath.Text;

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					textProductPath.Text = dlg.SelectedPath;
				}
			}
		}
	}
}
