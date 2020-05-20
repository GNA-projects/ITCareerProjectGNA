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
using ToolBox_GNA.View.Forms.DesignForms;
using FileSearcherDemo.Controllers;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabFileSearcher : ControlDesign
	{
		public TabFileSearcher()
		{
			InitializeComponent();
		}
		private void BtnSearchFiles_Click(object sender, EventArgs e)
		{
			MainMenuController.SetSearchFileServiceAsync();
			MainMenuController.PopulateSearchInformationAsync(TbFileSource, TbFileDestination, RtbInfo1, RtbInfo2);
		}
	}
}
