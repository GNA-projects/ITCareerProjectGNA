using ConverterDemo.ViewModels.SetDestPathViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterDemo.Services.SetDestPathService
{
    public class SetDestPathViewModel :ISetDestPathViewModel
    {
        public string SelectExtractionDirectory()
        {
            //Opens new Folder browser dialog
            FolderBrowserDialog NBrwsDialog = new FolderBrowserDialog();
            NBrwsDialog.Description = "Converted File Directory";
            //Sets start directory
            NBrwsDialog.RootFolder = Environment.SpecialFolder.Desktop;
            //Prints the output directory
            if (NBrwsDialog.ShowDialog() == DialogResult.OK)
            {
                string path = NBrwsDialog.SelectedPath;
                return path;
            }
            //Saves the directory
            return null;

        }
    }
}
