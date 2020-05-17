using DesktopChangerDemo.DesktopChanger.Services.OpenImageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo.Services.OpenImageService
{
    public class OpenImageService :IOpenImageSerive
    {
        public void OpenLocalImage(OpenFileDialog OBrwsDialog)
        {
            OBrwsDialog.Title = "Original File Directory";
            OBrwsDialog.InitialDirectory = $"{Environment.SpecialFolder.Desktop}";
            OBrwsDialog.Filter = "Images (*.jpeg*; *.bmp*; *.jpg*)| *.jpeg*; *.bmp*; *.jpg*";
            OBrwsDialog.RestoreDirectory = true;
        }

        public void OpenWebImage(OpenFromWebMenu form3)
        {
            form3.ShowDialog();
            SelectMenu.count -= -1;
            SelectMenu.IsFromWeb = true;
            if (OpenFromWebMenu.IsReady)
            {
                form3.Close();
            }
        }
    }
}
