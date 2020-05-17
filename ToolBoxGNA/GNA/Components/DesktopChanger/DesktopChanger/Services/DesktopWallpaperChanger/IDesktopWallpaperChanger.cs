using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesktopChangerDemo.DesktopWallpaperChangerService;

namespace DesktopChangerDemo.Services.DesktopWallpaperChanger
{
    interface IDesktopWallpaperChanger
    {

        void Set(string path, Style style);
        
    }
}
