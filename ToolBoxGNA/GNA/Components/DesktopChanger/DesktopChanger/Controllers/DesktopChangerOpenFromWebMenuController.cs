using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo.DesktopChanger.Controllers
{
    public static class DesktopChangerOpenFromWebMenuController
    {
        public static string path = null;
        public static void GetImageFromWeb(string text)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData($"{text}");

                    using (MemoryStream mem = new MemoryStream(data))
                    {
                        using (var yourImage = Image.FromStream(mem))
                        {
                            path = $"{Path.GetTempPath()}desktop{SelectMenu.count}.png";
                            yourImage.Save(path, ImageFormat.Png);

                        }
                    }

                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Please select correct image adress!");
            }
        }
    }

}

