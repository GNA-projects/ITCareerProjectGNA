using DatabaseOperations.Operations.FileManagerBuisseness;
using FileSearcherDemo.Entities.BindingModels.CopyFileBindingModel;
using FileSearcherDemo.Services.CopyFileServices.CopyFileAbstractClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.CopyFileServices.CopyFileServiceF
{
    /*this class is a service that is used to copy the files found in a specific directory given by the user*/
    public class CopierFileService : CopyFileServiceAbstract
    {
        bool isCompleted = false;
        public override void Copy(string[] files, CopyFileBindingModel copyFileBindingModel)
        {
            //Uses string[] files to get all the files from a specific directory.
            //Uses CopyFileBindingModel to get specific information from the binding model and set some properties.

            //isCompleted checks if the work has been done correctly and succesfully
            foreach (var file in files)
            {
                //Gets the paths and the names of the files in a directory that the user has entered to search files in strings
                string sourcePath = copyFileBindingModel.FileSourcePath;
                string targetPath = copyFileBindingModel.FileDestPath;
                string fileName = Path.GetFileName(file);

                //Sets the strings to a path with the name of the found file.
                string sourcePathFile = Path.Combine(sourcePath, fileName);
                string destPathFile = Path.Combine(targetPath, fileName);
                string overwriteDestFile = Path.Combine(targetPath, "Overwrite -" + fileName);
                string overwriteFileName = Path.GetFileName("Overwrite -" + fileName);

                //Checks if file already exists in the destination path
                //If they don't exist, it tries to save the files.
                if (File.Exists(targetPath + @"\" + fileName))
                {
                    //Asks the user if he wants to overwrite the files
                    var msgBox = MessageBox.Show("Source: " + sourcePath + @"\" + fileName + Environment.NewLine +
                        "Destination: " + targetPath + @"\" + fileName + Environment.NewLine +
                        "Do you want to write over existing file?", "File Already Exists",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 0,
                        MessageBoxOptions.DefaultDesktopOnly);

                    //If the user presses Yes it checks if it is already overwrited. 
                    //If it is not overwrited, the files are copied and overwrited succesfully
                    //If he presses No or cancel, the service stops and returns a text to the user.
                    if (msgBox == DialogResult.Yes)
                    {
                        if (!File.Exists(overwriteDestFile))
                        {
                            File.Copy(sourcePathFile, overwriteDestFile);
                            //copyFileBindingModel.FilesCopied property is used to add the files that are copied in it successfully
                            copyFileBindingModel.CopyFilesCopied.Add(file);
                            isCompleted = true;
                            FileDatabaseServices.AddCopyOperation(overwriteFileName, overwriteDestFile, "File", true);
                        }
                        else
                        {
                            FileDatabaseServices.AddCopyOperation("Unsuccessfull operation", overwriteDestFile, "File", false);
                            MessageBox.Show("File already overwrited!", "File exists!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }
                    }
                    else if (msgBox == DialogResult.Cancel)
                    {

                        return;
                    }
                    else
                    {
                        FileDatabaseServices.AddCopyOperation("Unsuccessfull operation", overwriteDestFile, "File", false);
                        MessageBox.Show("Existing file was not overwrited!", "Fail overwriting", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                            MessageBoxOptions.DefaultDesktopOnly);
                    }

                }
                //Tries to copy the files
                else
                {
                    //Exeption is thrown when user chooses different directory than the one he has choosen to save files from
                    try
                    {
                        File.Copy(sourcePathFile, destPathFile);
                        copyFileBindingModel.CopyFilesCopied.Add(file);
                        isCompleted = true;
                        FileDatabaseServices.AddCopyOperation(fileName, destPathFile, "File", true);
                    }
                    catch (FileNotFoundException)
                    {
                        isCompleted = false;
                        FileDatabaseServices.AddCopyOperation("Unsuccessfull operation", sourcePathFile, "File", false);
                        MessageBox.Show("Don't change the directory of the found files! Files failed to copy", "Failed copying", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                            MessageBoxOptions.DefaultDesktopOnly);
                    }

                }
            }

            //If everything is completed successfully, the user gets this text.
            if (isCompleted == true)
            {
                MessageBox.Show("Files copied successfully!", "Files Copied", MessageBoxButtons.OK, MessageBoxIcon.None, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
