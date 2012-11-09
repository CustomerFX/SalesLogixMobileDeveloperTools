using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace FX.Mobile.DeveloperTools.Launcher
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			string appPath = GetAppPath();
			string appArgs = string.Empty;
			if (appPath == string.Empty) return;

			foreach (string arg in args)
				appArgs += "\"" + arg + "\" ";
			
			using (var proc = new Process())
			{
				proc.StartInfo.FileName = appPath;
				proc.StartInfo.Arguments = appArgs.Trim();
				proc.Start();
			}
		}

		private static string GetAppPath()
		{
			try
			{
				var key = Registry.CurrentUser.OpenSubKey(@"Software\Customer FX Corporation\SalesLogix Mobile Developer Tools");
				return key.GetValue("Path").ToString();
			}
			catch { return string.Empty; }
		}
	}
}
