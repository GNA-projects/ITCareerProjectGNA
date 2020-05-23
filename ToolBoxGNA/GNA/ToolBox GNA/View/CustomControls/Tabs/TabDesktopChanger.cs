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
using DesktopChangerDemo;
using DesktopChangerDemo.DesktopChanger;

namespace ToolBox_GNA.View.CustomControls.Tabs
{
	public partial class TabDesktopChanger : ControlDesign
	{
		public TabDesktopChanger()
		{
			InitializeComponent();
		}

		readonly SelectMenu selectMenu = new SelectMenu();
		private void BtnOpen_Click(object sender, EventArgs e)
		{
			try
			{

			selectMenu.ShowDialog();
			if (selectMenu.IsLocal)
			{
				PbImagePreview.Image = new Bitmap(selectMenu.GetImageLocalPath());
				PbImagePreview.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
			{
				PbImagePreview.Image = new Bitmap(selectMenu.GetPathFromWeb());
				PbImagePreview.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			}
			catch (ArgumentNullException)
			{

			}
		}

		private async void BtnApply_Click(object sender, EventArgs e)
		{
			string path = null;
			if (SelectMenu.IsFromWeb)
			{
				path = selectMenu.GetPathFromWeb();
			}
			else
			{
				path = selectMenu.GetImageLocalPath();
			}
			DesktopWallpaperChangerService wallpaper = new DesktopWallpaperChangerService();
			if (RbStretched.Checked)
			{
				await DesktopChangerMainMenuController.SetNewDesktopStretchedAsync(path, wallpaper);
			}
			else if (RbTiled.Checked)
			{
				await DesktopChangerMainMenuController.SetNewDesktopTiledAsync(path, wallpaper);
			}
			else
			{
				await DesktopChangerMainMenuController.SetDesktopCentredAsync(path, wallpaper);
			}
		}
	}
}
