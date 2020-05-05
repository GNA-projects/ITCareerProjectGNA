using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo.DesktopChanger.Services.OpenImageService
{
    interface IOpenImageSerive
    {
        void OpenLocalImage(OpenFileDialog OBrwsDialog);
        void OpenWebImage(OpenFromWebMenu openFromWebMenu);
    }
}
