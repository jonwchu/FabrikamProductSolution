using System;
using System.Collections.Generic;
using System.Linq;
using BikeSharing.Web.Configuration;

namespace BikeSharing.Web
{
	public static class Helper
	{
		public static string GetMessageFor(string message)
		{
			return message != null ? (message + message.Length) : null;

		}
	}
}