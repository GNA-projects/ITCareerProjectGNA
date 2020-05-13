using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox_GNA.Controller.WifiChecker.Services;

namespace ToolBox_GNA.Controller.WifiChecker.Controller
{
	public class WifiController
	{
		public static List<string> GetWifiConnectedSsids()
		{
			return WifiService.ReturnWifiSsids();
		}
	}
}
