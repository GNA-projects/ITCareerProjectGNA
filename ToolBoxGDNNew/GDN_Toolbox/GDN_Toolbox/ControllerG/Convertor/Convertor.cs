using ConverterDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterDemo.ControllerG.Convertor
{
    public static class Convertor
    {
        public static string GetFileInfo(bool radiobuttonChecked)
        {
            Services.GetFilePathService.GetFilePathViewModel viewModel = new Services.GetFilePathService.GetFilePathViewModel();
            return viewModel.GetFileDirectory(radiobuttonChecked);

        }
        public static string SetDestFilePath()
        {
            ConverterDemo.Services.SetDestPathService.SetDestPathViewModel viewModel = new Services.SetDestPathService.SetDestPathViewModel();
            return viewModel.SelectExtractionDirectory();
        }
        public static async void DocumentToPDFConvertAsync(string inputPath, string outPath)
        {
            DocumetConvertorService document = new DocumetConvertorService();
            await Task.Run(()=>document.WordToPDFConv(inputPath, outPath));
        }
        public static async void ImageToPNGConvertAsync(string inputPath, string outPath)
        {
            ImageToPNGService image = new ImageToPNGService();
            await Task.Run(()=>image.ImageConvert(inputPath, outPath));
        }
    }
}
