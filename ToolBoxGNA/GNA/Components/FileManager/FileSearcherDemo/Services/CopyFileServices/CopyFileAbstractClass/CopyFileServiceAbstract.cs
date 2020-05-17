using FileSearcherDemo.BindingModels.SearchFileForm;
using FileSearcherDemo.Entities.BindingModels.CopyFileBindingModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.CopyFileServices.CopyFileAbstractClass
{
    /* this is an abstract class that is inherited by CopierFileService to implement the second Copy method in it
     This class is a service that is used for saving files that are found from the SearchFileService*/
    public abstract class CopyFileServiceAbstract : ICopyFileService
    {
        public void Copy(string[] files, SearchFileBindingModel searchFileBindingModel)
        {
            //Uses string[] files to get all the files from a specific directory.
            //Uses SearchFileBindingModel to get specific information from the binding model and set some properties.

            //isCompleted checks if the work has been done corretly and succesfully
            bool isCompleted = false;
            foreach (var file in files)
            {
                //Gets the paths and the names of the files in a directory that the user has entered to search files in strings
                string sourcePath = searchFileBindingModel.SearchDir;
                string targetPath = searchFileBindingModel.DestDir;
                string fileName = Path.GetFileName(file);

                //Sets the strings to a path with the name of the found file.
                string sourcePathFile = Path.Combine(sourcePath, fileName);
                string destPathFile = Path.Combine(targetPath, fileName);
                string overwriteDestFile = Path.Combine(targetPath, "Overwrite -" + fileName);

                //Checks if file already exists in the destination path
                //If they don't exist, it tries to save the files.
                if (File.Exists(targetPath + @"\" + fileName))
                {
                    //Asks the user if he wants to overwrite the files
                    var msgBox = MessageBox.Show("Source: " + sourcePathFile + @"\" + fileName + Environment.NewLine +
                        "Destination: " + destPathFile + @"\" + fileName + Environment.NewLine +
                        "Do you want to write over existing file?", "Files Already Exists",
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
                            //searchFileBindingModel.FilesCopied property is used to add the files that are copied in it successfully
                            searchFileBindingModel.FilesCopied.Add(file);
                            isCompleted = true;
                        }
                        else
                        {
                            MessageBox.Show("File already overwrited!", "File exists!", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning,
                                0, MessageBoxOptions.DefaultDesktopOnly);

                        }
                    }
                    else if (msgBox == DialogResult.Cancel)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Existing file was not overwrited!", "Fail overwriting", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 0, 
                            MessageBoxOptions.DefaultDesktopOnly);
                    }

                }
                //Tries to save the files
                else
                {
                    //Exeption is thrown when user chooses different directory than the one he has choosen to save files from
                    try
                    {
                        File.Copy(sourcePathFile, destPathFile);
                        isCompleted = true;
                        searchFileBindingModel.FilesCopied.Add(file);
                    }
                    catch (FileNotFoundException)
                    {
                        isCompleted = false;
                        MessageBox.Show("Don't change the directory of the found files! Files failed to save", "Failed saving", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                            MessageBoxOptions.DefaultDesktopOnly);
                    }

                }
            }
            //If everything is completed successfully, the user gets this text.
            if (isCompleted == true)
            {
                MessageBox.Show("Files saved successfully!", "Files Saved", 
                                MessageBoxButtons.OK, MessageBoxIcon.None, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        //This method is used in the inherited class CopierFileService to copy files.
        public abstract void Copy(string[] files, CopyFileBindingModel copyFileBindingModel);


    }
}
