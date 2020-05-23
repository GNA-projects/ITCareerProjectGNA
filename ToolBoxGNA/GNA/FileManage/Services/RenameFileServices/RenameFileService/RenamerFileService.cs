using DatabaseOperations.Operations.FileManagerBuisseness;
using FileSearcherDemo.BindingModels.RenameFileForm;
using System;
using System.IO;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.RenameFileService
{
    /*this class is a service that is used to rename the files found in a specific directory given by the user*/
    public class RenamerFileService : IRenameFileService
    {
        public void Rename(RenameFileBindingModel renameFileBindingModel)
        {
            //Uses RenameFileBindingModel to get specific information from the binding model and set some properties.

            //isRenamed checks if the work has been done correctly and succesfully
            bool isRenamed = false;
            //strings that gets the name of the choosen file and get the new name for it
            string fileName = Path.GetFileName(renameFileBindingModel.FileName);
            string newName = renameFileBindingModel.NewName;

            //Throws exeption if a file that should be renamed is opened while the service is trying to rename the files.
            try
            {
                //Gets the extension of the choosen file
                string extension = Path.GetExtension(renameFileBindingModel.FileName);
                //Gets the path of the file choosen to be renamed
                string sourcePath = Path.GetDirectoryName(renameFileBindingModel.FileName);
                string targetPath = Path.GetDirectoryName(renameFileBindingModel.FileName);

                //Sets the strings to a path with the name of the file that has to be renamed.
                string sourceFile = Path.Combine(sourcePath, fileName);
                //Sets the strings to a path with the New name of the file that has to be renamed + the extension of the file.
                string destFile = Path.Combine(targetPath, newName + extension);
                string overwriteDestFile = Path.Combine(targetPath, "Overwrite -" + fileName);
                string overwriteFileName = Path.GetFileName("Overwrite -" + fileName);

                //Checks if file already exists in the destination path
                //If they don't exist, it tries to rename the file.
                if (File.Exists(destFile))
                {
                    //Asks the user if he wants to overwrite the file
                    var msgBox = MessageBox.Show("Source: " + sourceFile + @"\" + fileName + Environment.NewLine +
                        "Destination: " + destFile + @"\" + fileName + Environment.NewLine +
                        "Do you want to write over existing file?", "File Already Exists",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 0,
                                MessageBoxOptions.DefaultDesktopOnly);

                    //If the user presses Yes it checks if it is already overwrited. 
                    //If it is not overwrited, the file is renamed and overwrited succesfully
                    //If he presses No or cancel, the service stops and returns a text to the user.
                    if (msgBox == DialogResult.Yes)
                    {
                        if (!File.Exists(overwriteDestFile))
                        {
                            File.Move(sourceFile, overwriteDestFile);
                            //renameFileBindingModel.IsRenamed is used to tell that the file is renamed successfully.
                            renameFileBindingModel.IsRenamed = true;
                            isRenamed = true;
                            FileDatabaseServices.AddRenameOperation(fileName, newName, "File", true);
                        }
                        else
                        {
                            FileDatabaseServices.AddRenameOperation("Unsuccessfull operation", overwriteDestFile, "File", false);
                            MessageBox.Show("File already overwrited!", "File exists!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
                            return;
                        }
                    }
                    else if (msgBox == DialogResult.Cancel)
                    {

                        return;
                    }
                    else
                    {
                        FileDatabaseServices.AddRenameOperation("Unsuccessfull operation", overwriteDestFile, "File", false);
                        MessageBox.Show("Existing file was not renamed!", "Failed renaming", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                }
                //Renames the file
                else
                {

                    File.Move(sourceFile, destFile);
                    renameFileBindingModel.IsRenamed = true;
                    isRenamed = true;
                    FileDatabaseServices.AddRenameOperation(fileName, newName + extension, "File", true);
                }
            }
            catch (IOException)
            {
                FileDatabaseServices.AddRenameOperation("Unsuccessfull operation", "None", "File", false);
                isRenamed = false;
                MessageBox.Show("File opened! \nPlease, close the file to proceed!", "Running process", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
            //If everything is completed successfully, the user gets this text.
            if (isRenamed == true)
            {
                MessageBox.Show($"File renamed as {newName + Path.GetExtension(fileName)}", "File Renamed", 
                                MessageBoxButtons.OK, MessageBoxIcon.None,0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }


        }
    }
}
