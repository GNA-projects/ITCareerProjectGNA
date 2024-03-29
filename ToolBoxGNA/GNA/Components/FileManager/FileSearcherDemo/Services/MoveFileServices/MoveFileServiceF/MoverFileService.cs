﻿using FileSearcherDemo.Entities.BindingModels.MoveFileBindingModel;
using System;
using System.IO;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.MoveFileServices.MoveFileServiceF
{
    /*this class is a service that is used to move the files found in a specific directory given by the user*/
    public class MoverFileService : IMoveFileService
    {
        public void Move(string[] foundFiles, MoveFileBindingModel moveFileBindingModel)
        {
            //Uses string[] files to get all the files from a specific directory.
            //Uses MoveFileBindingModel to get specific information from the binding model and set some properties.

            //isMoved checks if the work has been done correctly and succesfully
            bool isMoved = false;
            //Throws exeption if a file that should be moved is opened while the service is trying to move the files.
            try
            {
                foreach (var file in foundFiles)
                {
                    //Gets the paths and the names of the files in a directory that the user has entered to search files in strings
                    string sourcePath = moveFileBindingModel.FileSourcePath;
                    string targetPath = moveFileBindingModel.FileDest;
                    string name = Path.GetFileName(file);

                    //Sets the strings to a path with the name of the found file.
                    string sourceFile = Path.Combine(sourcePath, name);
                    string destFile = Path.Combine(targetPath, name);
                    string overwriteDestFile = Path.Combine(targetPath, "Overwrite -" + name);

                    //Checks if file already exists in the destination path
                    //If they don't exist, it tries to move the files.
                    if (File.Exists(targetPath + @"\" + name))
                    {
                        //Asks the user if he wants to overwrite the files
                        var msgBox = MessageBox.Show("Source: " + sourceFile + @"\" + name + Environment.NewLine +
                            "Destination: " + destFile + @"\" + name + Environment.NewLine +
                            "Do you want to write over existing file?", "File Already Exists",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 0,
                            MessageBoxOptions.DefaultDesktopOnly);

                        //If the user presses Yes it checks if it is already overwrited. 
                        //If it is not overwrited, the files are moved and overwrited succesfully
                        //If he presses No or cancel, the service stops and returns a text to the user.
                        if (msgBox == DialogResult.Yes)
                        {
                            if (!File.Exists(overwriteDestFile))
                            {
                                File.Move(sourceFile, overwriteDestFile);
                                //moveFileBindingModel.FilesMoved property is used to add the files that are copied in it successfully
                                moveFileBindingModel.FilesMoved.Add(file);
                                isMoved = true;
                            }
                            else
                            {
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
                            MessageBox.Show("Existing file was not overwrited!", "Fail overwriting", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }

                    }
                    //Tries to copy the files
                    else
                    {
                        //Exeption is thrown when user chooses different directory than the one he has choosen to move files from
                        try
                        {
                            File.Move(sourceFile, destFile);
                            moveFileBindingModel.FilesMoved.Add(file);
                            isMoved = true;
                        }
                        catch (FileNotFoundException)
                        {
                            isMoved = false;
                            MessageBox.Show("Don't change the directory of the found files! Files failed to move", "Failed moving", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error,0,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }


                    }

                }

            }
            catch (IOException)
            {
                foundFiles = null;
                isMoved = false;
                MessageBox.Show("File opened! \nPlease, close the file to proceed!", "Running process", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //If everything is completed successfully, the user gets this text.
            if (isMoved == true)
            {
                MessageBox.Show("Files moved successfully!", "Files Moved", MessageBoxButtons.OK);
            }

        }
    }
}
