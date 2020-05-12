using DesktopChangerDemo.Services.OpenImageService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo.DesktopChanger.Controllers
{
    public static class DesktopChangerSelectMenuController
    {
        private static string path = null;

        public static void OpenLocalImage(OpenFileDialog OBrwsDialog, OpenImageService service)
        {
            service.OpenLocalImage(OBrwsDialog);
            if (OBrwsDialog.ShowDialog() == DialogResult.OK)
            {
                path = OBrwsDialog.FileName;

            }
            else
            {
                path = null;
            }
        }
        public static void OpenWebImage(OpenFromWebMenu menu, OpenImageService service)
        {
            service.OpenWebImage(menu);
            path = $"{Path.GetTempPath()}desktop{SelectMenu.count}.png";
        }
        public static string ReturnPath()
        {
            return path;
        }

    }
}
