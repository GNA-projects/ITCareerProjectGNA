using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox_GNA.Controller.Convertor.ViewModels.SetDestPathViewModel
{
    public class SetDestPathViewModel : ISetDestPathViewModel
    {
        public string SelectExtractionDirectory()
        {
            //Opens new Folder browser dialog
            FolderBrowserDialog NBrwsDialog = new FolderBrowserDialog
            {
                Description = "Converted File Directory",
                //Sets start directory
                RootFolder = Environment.SpecialFolder.Desktop
            };
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
