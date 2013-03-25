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
using System.Windows.Forms;
using FX.Mobile.DeveloperTools.Managers;
using Microsoft.Win32;

namespace FX.Mobile.DeveloperTools
{
	static class Program
	{
		[STAThread]
		public static void Main(string[]  args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			RegisterApp();

			var launcher = new LaunchManager();
			launcher.Install();

			if (args.Length == 0)
			{
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

		public static string Path { get; set; }
		public static string Port { get; set; }
		public static string CurrentDevSite { get; set; }
		public static MobileVersion CurrentDevMobileVersion { get; set; }
	}
}
