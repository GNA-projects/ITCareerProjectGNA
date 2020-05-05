using DesktopChangerDemo.DesktopChanger;
using DesktopChangerDemo.DesktopChanger.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        readonly SelectMenu selectMenu = new SelectMenu();
        private void button1_Click(object sender, EventArgs e)
        {
            selectMenu.ShowDialog();
            if (selectMenu.IsLocal)
            {
                pictureBox1.Image = new Bitmap(selectMenu.GetImageLocalPath());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = new Bitmap(selectMenu.GetPathFromWeb());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private async void button2_Click(object sender, EventArgs e)
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
            if (IsStreched.Checked)
            {
               await DesktopChangerMainMenuController.SetNewDesktopStretchedAsync(path, wallpaper);
            }
            else if (IsTilted.Checked)
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
