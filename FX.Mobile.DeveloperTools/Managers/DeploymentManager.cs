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
using System.Collections.Generic;
using System.IO;

namespace FX.Mobile.DeveloperTools.Managers
{
	public class DeploymentManager
	{
		public DeploymentManager(string DeploymentPath)
		{
			this.DeploymentPath = DeploymentPath;
		}

		public string DeploymentPath { get; set; }

		public bool HasSDK
		{
			get
			{
				return Directory.Exists(Path.Combine(DeploymentPath, "argos-sdk"));
			}
		}

		public bool HasProducts
		{
			get
			{
				return Directory.Exists(Path.Combine(DeploymentPath, "products"));
			}
		}

		public bool HasSalesLogix
		{
			get
			{
				return Directory.Exists(Path.Combine(DeploymentPath, @"products\argos-saleslogix"));
			}
		}

		public MobileVersion Version
		{
			get
			{
				return (Directory.Exists(Path.Combine(DeploymentPath, @"argos-sdk\libraries\ext")) ? MobileVersion.Version12 : MobileVersion.Version20);
			}
		}

		public List<string> Products
		{
			get
			{
				var productList = new List<string>();

				var directories = Directory.GetDirectories(Path.Combine(Program.Path, "products"));
				foreach (var directory in directories)
				{
					string[] prodNameParts = directory.Split('\\');
					productList.Add(prodNameParts[prodNameParts.Length - 1]);
				}

				return productList;
			}
		}

		public bool ProductExists(string ProductName)
		{
			return (Directory.Exists(Path.Combine(DeploymentPath, @"products\argos-" + ProductName.ToLower() + @"\")));
		}
	}
}
