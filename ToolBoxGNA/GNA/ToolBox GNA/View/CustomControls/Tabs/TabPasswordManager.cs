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
using PasswordManager.PasswordManager.Entities;
using PasswordManager.PasswordManager.Controller;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabPasswordManager : ControlDesign
	{
		public TabPasswordManager()
		{
			InitializeComponent();
		}

		private void BtnGetPasswords_Click(object sender, EventArgs e)
		{
			LbUrls.Items.Clear();
			List<Password> passwords = PasswordController.GetChromePasswords();
			foreach (var password in passwords)
			{
				LbUrls.Items.Add(password);
				LbUrls.DisplayMember = "LoginUrl";
			}
		}

		private void LbUrls_SelectedIndexChanged(object sender, EventArgs e)
		{
			TbUsername.Text = ((Password)LbUrls.SelectedItem).LoginUsername;
			TbPassword.Text = ((Password)LbUrls.SelectedItem).LoginPassword;
		}
	}
}
