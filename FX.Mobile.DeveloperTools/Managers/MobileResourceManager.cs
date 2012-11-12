#region License Information
/* 

    SalesLogix Mobile Developer Tools
    Copyright (C) 2012  Customer FX Corporation - http://customerfx.com/

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either GetResourceVersion() 3 of the License, or
    (at your option) any later GetResourceVersion.

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
using System.ComponentModel;
using System.IO;
using System.Net;
using Ionic.Zip;
using FX.Mobile.DeveloperTools.Utility;

namespace FX.Mobile.DeveloperTools.Managers
{
	public class MobileResourceManager
	{
		public event EventHandler<MobileResourceInstallEventArgs> ResourceInstallInitializing;
		public event EventHandler<MobileResourceInstallEventArgs> ResourceInstallProgress;
		public event EventHandler<MobileResourceInstallEventArgs> ResourceInstallStepUpdate;
		public event EventHandler<MobileResourceInstallEventArgs> ResourceInstallComplete;

		public MobileResourceManager(string MobilePath, MobileVersion Version)
		{
			this.MobilePath = MobilePath;
			this.Version = Version;
		}

		public MobileVersion Version { get; set; }
		public string MobilePath { get; set; }
		public bool IncludeArgosSample { get; set; }

		private string CurrentFile { get; set; }

		public void Install()
		{
			if (ResourceInstallInitializing != null)
				ResourceInstallInitializing(this, new MobileResourceInstallEventArgs { Action = "Initializing downloads", StepNumber = 0, StepTotal = (this.IncludeArgosSample ? 6 : 5) });

			CurrentFile = "argos-sdk " + GetResourceVersion();
			var client = new WebClient();
			client.DownloadProgressChanged += webClient_DownloadProgressChanged;
			client.DownloadFileCompleted += webClient_DownloadFileCompleted;
			client.DownloadFileAsync(new Uri("https://github.com/Sage/argos-sdk/archive/" + GetResourceVersion() + ".zip"), Path.Combine(MobilePath, "argos-sdk-" + GetResourceVersion() + ".zip"));
		}

		private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			if (ResourceInstallStepUpdate != null)
				ResourceInstallStepUpdate(this, new MobileResourceInstallEventArgs { StepNumber = 1 });

			CurrentFile = "argos-saleslogix " + GetResourceVersion();

			var client = new WebClient();
			client.DownloadProgressChanged += webClient_DownloadProgressChanged;
			if (this.IncludeArgosSample)
				client.DownloadFileCompleted += webClient_DownloadFileCompletedSample;
			else
				client.DownloadFileCompleted += webClient_DownloadFileCompletedContinue;
			client.DownloadFileAsync(new Uri("https://github.com/SageSalesLogix/argos-saleslogix/archive/" + GetResourceVersion() + ".zip"), Path.Combine(MobilePath, "argos-saleslogix-" + GetResourceVersion() + ".zip"));
		}

		private void webClient_DownloadFileCompletedSample(object sender, AsyncCompletedEventArgs e)
		{
			if (ResourceInstallStepUpdate != null)
				ResourceInstallStepUpdate(this, new MobileResourceInstallEventArgs { StepNumber = 2 });

			CurrentFile = "argos-sample " + GetResourceVersion();

			var client = new WebClient();
			client.DownloadProgressChanged += webClient_DownloadProgressChanged;
			client.DownloadFileCompleted += webClient_DownloadFileCompletedContinue;
			client.DownloadFileAsync(new Uri("https://github.com/SageSalesLogix/argos-sample/archive/" + (GetResourceVersion() == "2.0" ? "master" : GetResourceVersion()) + ".zip"), Path.Combine(MobilePath, "argos-sample-" + (GetResourceVersion() == "2.0" ? "master" : GetResourceVersion()) + ".zip"));
		}

		private void webClient_DownloadFileCompletedContinue(object sender, AsyncCompletedEventArgs e)
		{
			if (ResourceInstallStepUpdate != null)
				ResourceInstallStepUpdate(this, new MobileResourceInstallEventArgs { StepNumber = 3 });

			CurrentFile = "argos-sdk " + GetResourceVersion();

			if (ResourceInstallProgress != null)
				ResourceInstallProgress(this, new MobileResourceInstallEventArgs { Action = "Extracting", CurrentFile = this.CurrentFile, ProgressCurrentFile = 0, ProgressTotalFiles = 0 });

			ExtractResource(Path.Combine(MobilePath, "argos-sdk-" + GetResourceVersion() + ".zip"), Path.Combine(MobilePath, "argos-sdk"));

			if (ResourceInstallStepUpdate != null)
				ResourceInstallStepUpdate(this, new MobileResourceInstallEventArgs { StepNumber = 4 });

			if (!Directory.Exists(Path.Combine(MobilePath, "products")))
				Directory.CreateDirectory(Path.Combine(MobilePath, "products"));

			CurrentFile = "argos-saleslogix " + GetResourceVersion();
			ExtractResource(Path.Combine(MobilePath, "argos-saleslogix-" + GetResourceVersion() + ".zip"), Path.Combine(Path.Combine(MobilePath, "products"), "argos-saleslogix"));

			if (ResourceInstallStepUpdate != null)
				ResourceInstallStepUpdate(this, new MobileResourceInstallEventArgs { StepNumber = 5 });

			if (IncludeArgosSample)
			{
				CurrentFile = "argos-sample " + GetResourceVersion();
				ExtractResource(Path.Combine(MobilePath, "argos-sample-" + (GetResourceVersion() == "2.0" ? "master" : GetResourceVersion()) + ".zip"), Path.Combine(Path.Combine(MobilePath, "products"), "argos-sample"));

				File.Move(Path.Combine(MobilePath, @"products\argos-sample\index-dev-sample.html"), Path.Combine(MobilePath, @"products\argos-saleslogix\index-dev-sample.html"));

				if (ResourceInstallStepUpdate != null)
					ResourceInstallStepUpdate(this, new MobileResourceInstallEventArgs { StepNumber = 6 });
			}

			CreateReadme();
			CreateStartShortcut();

			if (ResourceInstallComplete != null)
				ResourceInstallComplete(this, new MobileResourceInstallEventArgs());
		}

		private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			if (ResourceInstallProgress != null)
				ResourceInstallProgress(this, new MobileResourceInstallEventArgs { Action = "Downloading", CurrentFile = this.CurrentFile, ProgressPercentage = e.ProgressPercentage });
		}

		private void ExtractResource(string ResourceFile, string Location)
		{
			using (var zip = ZipFile.Read(ResourceFile))
			{
				int total = zip.Count;
				int count = 1;

				foreach (ZipEntry file in zip)
				{
					file.Extract(MobilePath, ExtractExistingFileAction.OverwriteSilently);

					if (ResourceInstallProgress != null)
						ResourceInstallProgress(this, new MobileResourceInstallEventArgs { Action = "Extracting", CurrentFile = this.CurrentFile, ProgressCurrentFile = count, ProgressTotalFiles = total });

					count++;
				}
			}

			var dir = new DirectoryInfo(Path.Combine(MobilePath, new FileInfo(ResourceFile).Name.Replace(".zip", "")));
			dir.MoveTo(Location);
			File.Delete(ResourceFile);
		}

		private void CreateReadme()
		{
			using (var writer = new StreamWriter(Path.Combine(MobilePath, "SalesLogix Mobile Version " + GetResourceVersion() + ".txt")))
			{
				writer.WriteLine("SalesLogix Mobile Version " + GetResourceVersion());
				writer.WriteLine("Development Environment");
				writer.WriteLine("------------------------------------------------");
				writer.WriteLine("\r\n");
				writer.WriteLine("Use the 'Start Mobile Website' link to start the website in  IIS Express");
				writer.WriteLine("or open IIS and add a new website to point to this directory.");
				writer.WriteLine("\r\n");
				writer.WriteLine("To access production configuration visit:");
				writer.WriteLine("http://MobileWebsiteRoot/products/argos-saleslogix/index.html");
				writer.WriteLine("\r\n");
				writer.WriteLine("To access development configuration visit:");
				writer.WriteLine("http://MobileWebsiteRoot/products/argos-saleslogix/index-dev.html");
				writer.WriteLine("\r\n");
				writer.WriteLine("------------------------------------------------");
				writer.WriteLine("SalesLogix Mobile Development Tools");
				writer.WriteLine("http://customerfx.com");
			}
		}

		private void CreateStartShortcut()
		{
			using (var link = new ShellLink())
			{
				link.Target = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FX.Mobile.DeveloperTools.Launcher.exe");
				link.Description = "Start Mobile Website";
				link.DisplayMode = ShellLink.LinkDisplayMode.edmNormal;
				link.Arguments = "\"/path:" + MobilePath + "\"";
				link.Save(Path.Combine(MobilePath, link.Description + ".lnk"));
			}
		}

		private string GetResourceVersion()
		{
			switch (this.Version)
			{
				case MobileVersion.Version12:
					return "1.2";
				case MobileVersion.Version20:
					return "2.0";
				default:
					return "1.2";
			}
		}
	}

	public class MobileResourceInstallEventArgs : EventArgs
	{
		public string CurrentFile { get; set; }
		public string Action { get; set; }
		public int ProgressPercentage { get; set; }
		public int ProgressCurrentFile { get; set; }
		public int ProgressTotalFiles { get; set; }
		public int StepNumber { get; set; }
		public int StepTotal { get; set; }
	}
}
