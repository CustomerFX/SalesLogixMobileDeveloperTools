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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FX.Mobile.DeveloperTools.Managers
{
	public class LaunchManager
	{
		public string InstallPath
		{
			get
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				return Path.Combine(path, "FX.Mobile.DeveloperTools.Launcher.exe");
			}
		}

		public bool IsInstalled
		{
			get
			{
				return File.Exists(this.InstallPath);
			}
		}

		public void Install()
		{
			try
			{
				if (File.Exists(InstallPath))
					File.Delete(InstallPath);

				File.Copy(System.IO.Path.Combine(new FileInfo(Application.ExecutablePath).DirectoryName, @"Deployment\FX.Mobile.DeveloperTools.Launcher.exe.bak"), this.InstallPath);
			}
			catch { }

		}

		public void Launch(string DeploymentPath)
		{
			var process = new Process();
			process.StartInfo.FileName = this.InstallPath;
			process.StartInfo.Arguments = "/path:\"" + DeploymentPath + "\"";
			process.Start();
		}
	}
}
