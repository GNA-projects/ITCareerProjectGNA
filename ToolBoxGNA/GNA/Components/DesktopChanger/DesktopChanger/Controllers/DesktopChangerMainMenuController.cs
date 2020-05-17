using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopChangerDemo.DesktopChanger
{
    public static class DesktopChangerMainMenuController
    {
        public static async Task SetDesktopCentredAsync(string path, DesktopWallpaperChangerService wallpaper)
        {
            await Task.Run(() => wallpaper.Set(path, DesktopWallpaperChangerService.Style.Centered));
        }

        public static async Task SetNewDesktopTiledAsync(string path, DesktopWallpaperChangerService wallpaper)
        {
            await Task.Run(() => wallpaper.Set(path, DesktopWallpaperChangerService.Style.Tiled));
        }

        public static async Task SetNewDesktopStretchedAsync(string path, DesktopWallpaperChangerService wallpaper)
        {
            await Task.Run(() => wallpaper.Set(path, DesktopWallpaperChangerService.Style.Stretched));
        }
    }
}
