using ConverterDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                DocumetConvertorService document = new DocumetConvertorService();
                await Task.Run(() => document.WordToPDFConv(inputPath, outPath));

            }
            catch (Exception)
            {
                MessageBox.Show("Error during converting. Please check if you selected correct convert file and settings!");
            }

        }
        public static async void ImageToPNGConvertAsync(string inputPath, string outPath)
        {
            try
            {
                ImageToPNGService service = new ImageToPNGService();
                await Task.Run(()=>service.ImageConvert(inputPath, outPath));
            }
            catch (Exception)
            {
                MessageBox.Show("Error during converting. Please check if you selected correct convert file and settings!");

            }
        }
        public static void DocumentToPDFConvert(string inputPath, string outPath)
        {
            try
            {
                DocumetConvertorService document = new DocumetConvertorService();
                document.WordToPDFConv(inputPath, outPath);

            }
            catch (Exception)
            {
                MessageBox.Show("Error during converting. Please check if you selected correct convert file and settings!");
            }

        }
        public static void ImageToPNGConvert(string inputPath, string outPath)
        {
            try
            {
                ImageToPNGService service = new ImageToPNGService();
                service.ImageConvert(inputPath, outPath);
            }
            catch (Exception)
            {
                MessageBox.Show("Error during converting. Please check if you selected correct convert file and settings!");

            }
        }
    }
}
