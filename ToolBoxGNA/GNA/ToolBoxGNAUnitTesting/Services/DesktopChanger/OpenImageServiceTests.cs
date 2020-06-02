using NUnit.Framework;
using DesktopChangerDemo.Services.OpenImageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChangerDemo.Services.OpenImageService.Tests
{
    [TestFixture()]
    //TODO: TESTS NEED TO SETUP DIFFERENT PARAMETHERS FOR DIFFERENT MACHINES
    public class OpenImageServiceTests
    {
        [Test()]
        public void OpenLocalImage_OpenDialogCorrectly()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            OpenImageService service = new OpenImageService();
            service.OpenLocalImage(dialog);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Assert.Pass();
            }
        }

        [Test()]
        public void OpenWebImage_OpenFormCorrectly()
        {
            OpenFromWebMenu form3 = new OpenFromWebMenu();
            form3.ShowDialog();
            Assert.Pass();
        }
    }

}
