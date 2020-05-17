using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.Controller.WifiChecker.Services;

namespace ToolBox_GNA.Controller.WifiChecker.Controller
{
	public class WifiController
	{
		public static List<string> GetWifiConnectedSsids()
		{
			try
			{
				return WifiService.ReturnWifiSsids();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return new List<string>() { ex.Message };
			}
		}
	}
}
