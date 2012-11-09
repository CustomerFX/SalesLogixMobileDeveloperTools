using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace FX.Mobile.DeveloperTools
{
	static class Program
	{
		[STAThread]
		public static void Main(string[]  args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (args.Length == 0)
			{
				RegisterApp();
				InstallLauncher();

				Application.Run(new UI.FormMain());
			}
			else
			{
				foreach (string arg in args)
				{
					if (arg.Trim().ToLower().StartsWith("/path:"))
						Program.Path = arg.Replace("/path:", "").Trim().Replace("\"", "");

					if (arg.Trim().ToLower().StartsWith("/port:"))
						Program.Port = arg.Replace("/port:", "").Trim().Replace("\"", "");
				}
				
				Application.Run(new UI.FormLaunchWeb());
			}
		}

		private static void RegisterApp()
		{
			try
			{
				var key = Registry.CurrentUser.CreateSubKey(@"Software\Customer FX Corporation\SalesLogix Mobile Developer Tools");
				key.SetValue("Path", Application.ExecutablePath);
			}
			catch { }
		}

		private static void InstallLauncher()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			if (!File.Exists(System.IO.Path.Combine(path, "FX.Mobile.DeveloperTools.Launcher.exe")))
			{
				File.Copy(System.IO.Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName, "Deployment\\FX.Mobile.DeveloperTools.Launcher.exe.bak"), System.IO.Path.Combine(path, "FX.Mobile.DeveloperTools.Launcher.exe"));
			}
		}

		public static string Path { get; set; }
		public static string Port { get; set; }
	}
}
