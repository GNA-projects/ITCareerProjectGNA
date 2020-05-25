using ConverterDemo.Services;
using DatabaseOperations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToolBoxGNAUnitTesting.Services.Convertor
{

    [TestFixture()]
    public class ImageToPNGServiceTests
    {
        [TestCase(@"C:\Users\Admin\Desktop\ImageConvTests\BmpImage.bmp", @"C:\Users\Admin\Desktop\ImageConvertOutput")]
        public void ImageConvert_Correctcase_bmp(string input, string output)
        {
            ImageToPNGService service = new ImageToPNGService();
            CurrentUser.ID = 1;
            CurrentUser.Username = "Test";
            service.ImageConvert(input, output);

            FileAssert.Exists(@"C:\Users\Admin\Desktop\ImageConvertOutput\BmpImage.png");
        }
        [TestCase(@"C:\Users\Admin\Desktop\ImageConvTests\download.jpg", @"C:\Users\Admin\Desktop\ImageConvertOutput")]
        public void ImageConvert_Correctcase_jpg(string input, string output)
        {
            CurrentUser.Username = "Test";
            ImageToPNGService service = new ImageToPNGService();
            service.ImageConvert(input, output);

            FileAssert.Exists(@"C:\Users\Admin\Desktop\ImageConvertOutput\download.png");
        }
        [TestCase(@"C:\Users\Admin\Desktop\ImageConvTests\PngImage.png", @"C:\Users\Admin\Desktop\ImageConvertOutput")]
        public void ImageConvert_Correctcase_png(string input, string output)
        {
            CurrentUser.Username = "Test";
            ImageToPNGService service = new ImageToPNGService();
            service.ImageConvert(input, output);

            FileAssert.Exists(@"C:\Users\Admin\Desktop\ImageConvertOutput\PngImage.png");
        }
        [TestCase(@"C:\Users\Admin\Desktop\ImageConvTests\", @"C:\Users\Admin\Desktop\ImageConvertOutput")]
        public void ImageConvert_Incorrectcase_fileNotExist(string input, string output)
        {
            CurrentUser.Username = "Test";
            ImageToPNGService service = new ImageToPNGService();
            FieldInfo[] fields = typeof(ImageToPNGService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            var field = fields.FirstOrDefault(x => x.Name == "isDone");
            field.SetValue(service, false);
            service.ImageConvert(input, output);
            Assert.IsFalse((bool)field.GetValue(service));

        }
        [TestCase(@"C:\Users\Admin\Desktop\ImageConvTests\PngImage.png", " ")]
        public void ImageConvert_Incorrectcase_OutPutNotExist(string input, string output)
        {
            CurrentUser.Username = "Test";
            ImageToPNGService service = new ImageToPNGService();
            FieldInfo[] fields = typeof(ImageToPNGService).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            var field = fields.FirstOrDefault(x => x.Name == "isDone");
            field.SetValue(service, false);
            service.ImageConvert(input, output);
            Assert.IsFalse((bool)field.GetValue(service));

        }
    }
}
