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

		private void BtnEncrypt_Click(object sender, EventArgs e)
		{
			MainMenuController.SetEncryptFileServicerNonAsync();
			MainMenuController.PopulateEncryptInformationNonAsync(TbEncryptedFile, RtbInfo);
		}

		private void BtnDecrypt_Click(object sender, EventArgs e)
		{
			MainMenuController.SetDecryptFileServicerNonAsync();
			MainMenuController.PopulateDecryptInformationNonAsync(TbEncryptedFile, RtbInfo);
		}
	}
}
