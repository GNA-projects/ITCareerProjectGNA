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
using SaveZone.Controllers;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabSafeZone : ControlDesign
	{
		public TabSafeZone()
		{
			InitializeComponent();
		}

		private async void BtnEncrypt_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetEncryptFileServicerAsync();
			MainMenuController.PopulateEncryptInformationAsync(TbEncryptedFile, RtbInfo);
		}

		private async void BtnDecrypt_Click(object sender, EventArgs e)
		{
			await MainMenuController.SetDecryptFileServicerAsync();
			MainMenuController.PopulateDecryptInformationAsync(TbDecryptedFile, RtbInfo);
		}
	}
}
