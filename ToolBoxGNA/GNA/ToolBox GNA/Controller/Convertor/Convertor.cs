using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox_GNA.Controller.Convertor.Services.ImageToPNGService;
using ToolBox_GNA.Controller.Convertor.Services.WordToPDFConvertorService;
using ToolBox_GNA.Controller.Convertor.ViewModels.GetFilePathViewModel;
using ToolBox_GNA.Controller.Convertor.ViewModels.SetDestPathViewModel;

namespace ToolBox_GNA.Controller.Convertor
{
    public static class Convertor
    {
        public static string GetFileInfo(bool radiobuttonChecked)
        {
            GetFilePathViewModel viewModel = new GetFilePathViewModel();
            return viewModel.GetFileDirectory(radiobuttonChecked);
        }
        public static string SetDestFilePath()
        {
            SetDestPathViewModel viewModel = new SetDestPathViewModel();
            return viewModel.SelectExtractionDirectory();
        }
        public static async void DocumentToPDFConvertAsync(string inputPath, string outPath)
        {
            DocumetConvertorService document = new DocumetConvertorService();
            await Task.Run(() => document.WordToPDFConv(inputPath, outPath));
        }
        public static async void ImageToPNGConvertAsync(string inputPath, string outPath)
        {
            ImageToPNGService image = new ImageToPNGService();
            await Task.Run(() => image.ImageConvert(inputPath, outPath));
        }
    }
}
