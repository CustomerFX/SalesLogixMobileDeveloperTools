using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FX.Mobile.DeveloperTools.Model
{
	public class ResourcePackage
	{
		public string Name { get; set; }
		public string File { get; set; }
		public string Account { get; set; }
		public string Repository { get; set; }
		public string Archive { get; set; }
		public string Path { get; set; }
		public Action PostAction { get; set; }
	}
}
