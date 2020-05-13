using SimpleWifi.Win32;
using SimpleWifi.Win32.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox_GNA.Controller.WifiChecker.Services
{
	public class WifiService
	{
		public static List<string> ReturnWifiSsids()
		{
			List<string> ssids = new List<string>();

			WlanClient client = new WlanClient();

			foreach (WlanInterface wlanInterface in client.Interfaces)
			{
				Dot11Ssid ssid = wlanInterface.CurrentConnection.wlanAssociationAttributes.dot11Ssid;
				ssids.Add(new String(Encoding.ASCII.GetChars(ssid.SSID, 0, (int)ssid.SSIDLength)));
			}

			return ssids;
		}
	}
}
