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
using TempDeleter.TempDeleter;
using System.IO;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabTempDeleter : ControlDesign
	{
		public TabTempDeleter()
		{
			InitializeComponent();
		}

		private void BtnCheckDel_Click(object sender, EventArgs e)
		{
			if (BtnCheckDel.Text == "Check")
			{
				if (TempDeleterController.HasTempFiles())
				{
					BtnCheckDel.Text = "Delete";
				}
			}
			else
			{
				TempDeleterController.ResetValues();
				TempDeleterController.DeleteTempFilesAsync(Path.GetTempPath());
			}
			
		}

		private void BtnInfo_Click(object sender, EventArgs e)
		{
			TempDeleterController.GetNamesAsync();
			RtbInfo.Text = TempDeleterController.GetNames();
		}

		private void RtbInfo_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
