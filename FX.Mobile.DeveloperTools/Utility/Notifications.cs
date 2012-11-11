using System;
using System.Net;
using FX.Mobile.DeveloperTools.Model;

namespace FX.Mobile.DeveloperTools.Utility
{
	public class Notifications
	{
		public static AppNotification Get()
		{
			var client = new WebClient();
			string values = client.DownloadString("http://cfxconnect.com/applications/SalesLogixMobileDeveloperTools/notification.txt?id=" + Machine.ID);

			if (!string.IsNullOrEmpty(values))
			{
				string[] notificationValues = values.Split('|');
				var notification = new AppNotification();
				notification.LinkAddress = notificationValues[0];
				notification.ImageMainAddress = notificationValues[1];
				notification.ImageHoverAddress = notificationValues[2];
				return notification;
			}
			else
			{
				return null;
			}
		}
	}
}
