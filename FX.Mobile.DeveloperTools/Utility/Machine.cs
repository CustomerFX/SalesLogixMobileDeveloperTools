using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace FX.Mobile.DeveloperTools.Utility
{
	public class Machine
	{	
		/// <summary>
		/// This value is used to be able to indentify if a notification has already been sent to this instance
		/// </summary>
		public static string ID
		{
			get
			{
				string id = string.Empty;

				foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
				{
					id += netInterface.Id;
				}

				return id;
			}
		}
	}
}
