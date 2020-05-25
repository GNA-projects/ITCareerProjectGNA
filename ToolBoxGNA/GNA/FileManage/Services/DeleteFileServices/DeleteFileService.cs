using FileSearcherDemo.Entities.BindingModels.DeleteFileBindingModel;
using FileSearcherDemo.Services.DeleteFileServices.DeleteFileServiceF;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.DeleteFileServices
{
    /*This is a source that uses DeleterFileService, DeleteFileBindingModel and DeleteFile form to validate, set and get all the 
      things that the user inputs and also show him the results*/
    public class DeleteFileService
    {
        //Sets all the things needed for using the delete function correctly.
        private FolderBrowserDialog deleteFileDialog;
        private DialogResult result;
        private DialogResult deleteFileMessageBox;
        private DeleterFileService deleteFiles = new DeleterFileService();
        private OpenFileDialog specificDeleteFileDialog;
        private DeleteFileBindingModel deleteFileBindingModel = new DeleteFileBindingModel();
        private StringBuilder sb = new StringBuilder();
        private string sourcePath = " ";
        private string foundFilesCount = " ";

        //This method is called in the main controller to do the delete function.
        public void DeleteFiles()
        {
            //Shows the user to choose a source folder for files and check his input
            OpenFolderBrowseDialog();
            CheckUserInput();
        }

        //Shows the choosen source path from the user
        public string ShowSourcePath()
        {
            return sourcePath;
        }

        //Shows the count of the deleted files
        public string ShowDeleteFilesCount()
        {
            return foundFilesCount;
        }

        //Shows the names of the deleted files
        public string ShowDeleteFilesNames()
        {
            string deleteFileNames = sb.ToString();
            sb.Clear();
            return deleteFileNames;
        }

        private void OpenFolderBrowseDialog()
        {
            //Opens a dialog in which the user should choose a source folder
            deleteFileDialog = new FolderBrowserDialog();
            deleteFileDialog.Description = "Delete Files From: ";
            deleteFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            result = deleteFileDialog.ShowDialog();
        }
        private void CheckUserInput()
        {
            //Checks if user has pressed OK for saving the source directory
            if (result == DialogResult.OK)
            {
                //Saves the source directory in deleteFileBindingModel.FileSourcePath
                sourcePath = deleteFileBindingModel.FileSourcePath = deleteFileDialog.SelectedPath;
                deleteFileBindingModel.AllFiles = Directory.GetFiles(deleteFileBindingModel.FileSourcePath);
                CheckFileLenght(deleteFileBindingModel.AllFiles);
            }

        }
        private void CheckFileLenght(string[] files)
        {
            //Uses string[] files to check if there are any files in the array(source directory)

            if (files.Length > 0)
            {
                //Asks the user if he wants to delete all the files or specific ones.
                deleteFileMessageBox = MessageBox.Show($"Found {files.Length} file(s). Do you want to delete all of them?", "Files Found",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0,
                                       MessageBoxOptions.DefaultDesktopOnly);

                CheckMessageBoxInput();
            }
            else
            {
                foundFilesCount = "No files found.";
                MessageBox.Show("No files found.", "None files", MessageBoxButtons.OK, MessageBoxIcon.None, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void CheckMessageBoxInput()
        {
            //If the user wants to delete all the files, it deletes all the files. 
            //Else it opens the source folder to choose the files he wants to delete.
            if (deleteFileMessageBox == DialogResult.Yes)
            {
                DeleteAllFiles();
            }
            else if (deleteFileMessageBox == DialogResult.No)
            {
                OpenFileBrowseDialog();
                SetListWithSpecificFiles();
                DeleteSpecificFiles();
            }
            //He has pressed Cancel and it resets the variables
            else
            {
                foundFilesCount = " ";
                sb.Clear();
            }

        }
        private void DeleteAllFiles()
        {
            //Uses the Delete method from the DeleterFile service
            deleteFiles.Delete(deleteFileBindingModel.AllFiles, deleteFileBindingModel);
            //Shows all the deleted files
            ShowAllDeletedFiles();
        }
        private void OpenFileBrowseDialog()
        {
            //Opens a dialog in wich the user should choose the files he wants to delete.
            specificDeleteFileDialog = new OpenFileDialog();
            specificDeleteFileDialog.Multiselect = true;
            specificDeleteFileDialog.InitialDirectory = deleteFileDialog.SelectedPath;
            specificDeleteFileDialog.ShowDialog();
        }
        private void SetListWithSpecificFiles()
        {
            //Adds every choosen file in a deleteFileBindingModel.SpecificFileList
            foreach (var file in specificDeleteFileDialog.FileNames)
            {
                deleteFileBindingModel.SpecificFileList.Add(file);
            }

        }
        private void DeleteSpecificFiles()
        {
            //Uses the Delete method from the DeleterFile service
            deleteFiles.Delete(deleteFileBindingModel.SpecificFileList.ToArray(), deleteFileBindingModel);
            //Shows all the deleted files
            ShowAllDeletedFiles();
        }
        private void ShowAllDeletedFiles()
        {
            //Gets all the files that are deleted succesfully 
            foreach (var file in deleteFileBindingModel.DeletedFiles)
            {
                string appendFile = file.Split('\\').Last();
                sb.AppendLine(appendFile);
            }
            //Resets the  deleteFileBindingModel.DeletedFiles for its next use.
            deleteFileBindingModel.DeletedFiles.Clear();
            foundFilesCount = $"Delete {Regex.Matches(sb.ToString(), Environment.NewLine).Count} file(s)";
        }
    }
}
