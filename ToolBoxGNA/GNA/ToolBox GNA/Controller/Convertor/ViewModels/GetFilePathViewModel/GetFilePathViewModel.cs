using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox_GNA.Controller.Convertor.ViewModels.GetFilePathViewModel
{
    public class GetFilePathViewModel : IGetFilePathViewModel
    {
        public string GetFileDirectory(bool radioButtonChecked)
        {

            //Creating Open File Dialog for browsing files
            OpenFileDialog OBrwsDialog = new OpenFileDialog
            {
                Title = "Original File Directory",
                //Setting starting Directory
                InitialDirectory = $"{Environment.SpecialFolder.Desktop}"
            };

            if (radioButtonChecked)
            {
                OBrwsDialog.Filter = "Documents (*.doc*; *.docx*)| *.doc*; *.docx*";


            }
            if (!radioButtonChecked)
            {
                OBrwsDialog.Filter = "Images (*.jpeg*; *.bmp*; *.jpg*)| *.jpeg*; *.bmp*; *.jpg*";

            }
            //Next time you browse you will start again from Desktop
            OBrwsDialog.RestoreDirectory = true;
            //Prints the directory on the textbox
            if (OBrwsDialog.ShowDialog() == DialogResult.OK)
            {
                string path = OBrwsDialog.FileName;
                return path;
            }

            return null;

        }
    }
}
