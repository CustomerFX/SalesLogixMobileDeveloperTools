using System;
using System.IO;

namespace FX.Mobile.DeveloperTools.Managers
{
	public class IISExpressManager
	{
		public bool IsInstalled
		{
			get
			{
				return !string.IsNullOrEmpty(this.ExecutablePath);
			}
		}

		public string ExecutablePath
		{
			get
			{
				string path = string.Empty;

				if (Directory.Exists(@"C:\Program Files (x86)\IIS Express\"))
				{
					path = Path.Combine(@"C:\Program Files (x86)\IIS Express\", "iisexpress.exe");
				}

				if (Directory.Exists(@"C:\Program Files\IIS Express\"))
				{
					path = Path.Combine(@"C:\Program Files\IIS Express\", "iisexpress.exe");
				}

				return path;
			}
		}
	}
}
