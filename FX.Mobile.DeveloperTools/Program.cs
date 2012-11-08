using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
				Application.Run(new UI.FormMain());
			else
			{
				foreach (string arg in args)
				{
					if (arg.Trim().ToLower().StartsWith("/path:"))
						Program.Path = arg.Replace("/path:", "").Trim();

					if (arg.Trim().ToLower().StartsWith("/port:"))
						Program.Port = arg.Replace("/port:", "").Trim();
				}

				Application.Run(new UI.FormLaunchWeb());
			}
		}

		public static string Path { get; set; }
		public static string Port { get; set; }
	}
}
