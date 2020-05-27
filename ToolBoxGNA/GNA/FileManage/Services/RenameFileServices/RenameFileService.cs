using FileSearcherDemo.BindingModels.RenameFileForm;
using FileSearcherDemo.Views;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.RenameFileService
{
    /*This is a source that uses RenamerFileService and RenameFile form to validate, set and get all the 
      things that the user inputs and also show him the results*/
    public class RenameFileService
    {
        //Sets all the things needed for using the rename function correctly.
        private OpenFileDialog renameFileDialog;
        private DialogResult result;
        private RenameFile RenameFileForm = new RenameFile();
        private RenamerFileService renameFileService = new RenamerFileService();
        private string oldName = " ";
        private string newName = " ";
        private string sourcePath = " ";

        //This method is called in the main controller to do the rename function.
        public void RenameFile()
        {
            //Shows the user to choose a source folder for file and check his input
            OpenFileBrowseDialog();
            //CheckUserInput uses RenameFileForm.GetRenameFileBindingModel() to get the created binding model from the form.
            CheckUserInput(RenameFileForm.GetRenameFileBindingModel());
        }

        //Shows the choosen source path from the user
        public string ShowSourcePath()
        {
            return sourcePath;
        }

        //Shows the old file name
        public string ShowOldFileName()
        {
            return oldName;
        }

        //Shows the new file name
        public string ShowNewName()
        {
            return newName + Path.GetExtension(oldName);
        }

        private void OpenFileBrowseDialog()
        {
            //Opens a dialog in which the user should choose a source folder
            renameFileDialog = new OpenFileDialog();
            renameFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            result = renameFileDialog.ShowDialog();
        }
        private void CheckUserInput(RenameFileBindingModel renameFileBindingModel)
        {
            //Checks if user has pressed OK for saving the source directory
            if (result == DialogResult.OK)
            {
                //Saves the old file name in renameFileBindingModel.FileName
                renameFileBindingModel.FileName = renameFileDialog.FileName;
                sourcePath = Path.GetDirectoryName(renameFileBindingModel.FileName);
                //Shows the RenamerFileForm to the user.
                try
                {
                    RenameFileForm.ShowDialog();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Please, enter a name for a file before trying to search file again", "Enter name",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 0,
                               MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }
                //Checks if Cancel is pressed in the SearchFileForm form.
                CheckIfCancelIsPressed(RenameFileForm.GetRenameFileBindingModel());
            }
        }
        private void CheckIfCancelIsPressed(RenameFileBindingModel renameFileBindingModel)
        {
            //Uses RenameFileBindingModel to set its properties

            if (renameFileBindingModel.IsPressed == false)
            {
                //Uses the Rename method from the RenamerFile service
                renameFileService.Rename(renameFileBindingModel);
                //Checks if file is renamed successfully
                if (renameFileBindingModel.IsRenamed == true)
                {
                    //If it is renamed successfully it sets the variables and returns them.
                    string oldFile = renameFileBindingModel.FileName.Split('\\').Last();
                    oldName = $"File {oldFile} renamed to:";
                    newName = renameFileBindingModel.NewName + Path.GetExtension(renameFileBindingModel.FileName);
                }
                else
                {
                    //If it is not renamed successfully it returns this.
                    oldName = "File was not renamed";
                }
            }

            RenameFileForm.Dispose();
            RenameFileForm = new RenameFile();

        }
    }
}
