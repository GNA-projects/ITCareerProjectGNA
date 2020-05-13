using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.View.CustomControls.Tabs.Design;
using ToolBox_GNA.Controller.WifiChecker.Controller;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabWifiChecker : ControlDesign
	{
		public TabWifiChecker()
		{
			InitializeComponent();
		}

		private void BtnGetWifiInfo_Click(object sender, EventArgs e)
		{
			RtbWifiInfo.AppendText($"You are currently connected to => {WifiController.GetWifiConnectedSsids()[0]}");
		}
	}
}
