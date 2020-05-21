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
		private async void BtnSearchFiles_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetSearchFileServiceAsync();
			MainMenuController.PopulateSearchInformationAsync(TbFileSource, TbFileDestination, RtbInfo1, RtbInfo2);
		}

		private async void BtnCopyFiles_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetCopyFileServiceAsync();
			MainMenuController.PopulateCopyInformationAsync(TbFileSource,TbFileDestination,RtbInfo1,RtbInfo2);
		}

		private async void BtnMoveFiles_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetMoveFileServiceAsync();
			MainMenuController.PopulateMoveInformationAsync(TbFileSource, TbFileDestination, RtbInfo1, RtbInfo2);
		}

		private async void BtnDeleteFiles_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetDeleteFileServiceAsync();
			MainMenuController.PopulateDeleteInformationAsync(TbFileSource, RtbInfo1, RtbInfo2);
		}

		private async void BtnCreateFiles_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetCreateFileServiceAsync();
			MainMenuController.PopulateCreateInformationAsync(TbFileDestination, RtbInfo1, RtbInfo2);
		}

		private async void BtnRenameFiles_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetRenameFileServiceAsync();
			MainMenuController.PopulateRenameInformationAsync(TbFileDestination, RtbInfo1, RtbInfo2);
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			TbFileDestination.Text = "";
			TbFileSource.Text = "";
			RtbInfo1.Text = "";
			RtbInfo2.Text = "";
		}
	}
}
