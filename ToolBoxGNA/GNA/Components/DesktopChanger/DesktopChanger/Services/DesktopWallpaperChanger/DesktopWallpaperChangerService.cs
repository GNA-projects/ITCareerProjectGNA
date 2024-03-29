﻿using DatabaseOperations.Operations.DesktopChangerBuissiness;
using DesktopChangerDemo.Services.DesktopWallpaperChanger;
using Microsoft.Win32;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopChangerDemo
{
    public class DesktopWallpaperChangerService : IDesktopWallpaperChanger
    {

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public enum Style : int
        {
            Tiled,
            Centered,
            Stretched
        }

        public void Set(string path, Style style)
        {

            Image img = Image.FromFile(path);
            string tempPath = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
            img.Save(tempPath, System.Drawing.Imaging.ImageFormat.Bmp);
            var name = path.Split('\\').ToArray();
            try
            {

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
                if (style == Style.Stretched)
                {
                    key.SetValue(@"WallpaperStyle", 2.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }

                else if (style == Style.Centered)
                {
                    key.SetValue(@"WallpaperStyle", 1.ToString());
                    key.SetValue(@"TileWallpaper", 0.ToString());
                }

                else if (style == Style.Tiled)
                {
                    key.SetValue(@"WallpaperStyle", 1.ToString());
                    key.SetValue(@"TileWallpaper", 1.ToString());

                }

                SystemParametersInfo(SPI_SETDESKWALLPAPER,
                    0,
                    tempPath,
                    SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                DesktopChnagerDbService.AddDesktopChange(name.Last(), path, true);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error during setting deskop. Please check you have correct credetials!");

            }
        }
    }
}

