using FileSearcherDemo.Entities.BindingModels.CopyFileBindingModel;
using FileSearcherDemo.Services.CopyFileServices.CopyFileServiceF;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.CopyFileServices
{
    /*This is a source that uses CopierFileService and CopyFileBindingModel to validate, set and get all the 
      things that the user inputs and also show him the results*/
    public class CopyFileService
    {
        //Sets all the things needed for using the copy function correctly.
        private FolderBrowserDialog copyFileDialog;
        private DialogResult result;
        private DialogResult copyFileMessageBox;
        private FolderBrowserDialog saveDialog;
        private CopierFileService copyFiles = new CopierFileService();
        private OpenFileDialog specificCopyFileDialog;
        private FolderBrowserDialog saveSpecificFileDialog;
        private CopyFileBindingModel copyFileBindingModel = new CopyFileBindingModel();
        private StringBuilder sb = new StringBuilder();
        private string sourcePath = " ";
        private string destPath = " ";
        private string foundFilesCount = " ";

        //This method is called in the main controller to do the copy function.
        public void CopyFiles()
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

        //Shows the choosen destination path from the user
        public string ShowDestPath()
        {
            return destPath;
        }

        //Shows the count of the copied files
        public string ShowCopyFilesCount()
        {
            return foundFilesCount;
        }

        //Shows the names of the copied files
        public string ShowCopyFilesNames()
        {
            string copyFileNames = sb.ToString();
            sb.Clear();
            return copyFileNames;
        }

        private void OpenFolderBrowseDialog()
        {
            //Opens a dialog in which the user should choose a source folder
            copyFileDialog = new FolderBrowserDialog();
            copyFileDialog.Description = "Copy Files From: ";
            copyFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            result = copyFileDialog.ShowDialog();
        }
        private void CheckUserInput()
        {
            //Checks if user has pressed OK for saving the source directory
            if (result == DialogResult.OK)
            {
                //Saves the source directory in copyFileBindingModel.FileSourcePath
                sourcePath = copyFileBindingModel.FileSourcePath = copyFileDialog.SelectedPath;
                //Gets all the files in this directory to copyFileBindingModel.AllFiles
                copyFileBindingModel.AllFiles = Directory.GetFiles(copyFileBindingModel.FileSourcePath);
                //Checks the lenght of the added files
                CheckFileLenght(copyFileBindingModel.AllFiles);

            }
        }
        private void CheckFileLenght(string[] files)
        {
            //Uses string[] files to check if there are any files in that array.

            if (files.Length > 0)
            {
                //Asks the user if he wants to copy all the files or specific ones.
                copyFileMessageBox = MessageBox.Show($"Found {files.Length} file(s). Do you want to copy all of them?", "Files Found", 
                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 0,
                                     MessageBoxOptions.DefaultDesktopOnly);
                CheckMessageBoxInput();
            }
            else
            {
                foundFilesCount = "No files found.";
                MessageBox.Show("No files found.", "None files", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.None, 0,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void CheckMessageBoxInput()
        {
            //If the user wants to copy all the files, it copies all the files. 
            //Else it opens the source folder to choose the files he wants to copy.
            if (copyFileMessageBox == DialogResult.Yes)
            {
                CopyAllFiles();
            }
            else if (copyFileMessageBox == DialogResult.No)
            {
                OpenFileBrowseDialog();
                SetListWithSpecificFiles();
                CopySpecificFiles();
            }
            //He has pressed Cancel and it resets the variables
            else
            {
                foundFilesCount = " ";
                sb.Clear();
            }

        }
        private void CopyAllFiles()
        {
            //Opens a dialog in which the user chooses the folder he wants to save the files
            saveDialog = new FolderBrowserDialog();
            saveDialog.Description = "Save Files Directory";
            saveDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult saveresult = saveDialog.ShowDialog();
            if (saveresult == DialogResult.OK)
            {
                //Saves the destination path in copyFileBindingModel.FileDestPath
                destPath = copyFileBindingModel.FileDestPath = saveDialog.SelectedPath;
                //Uses the Copy method from the CopierFile service
                copyFiles.Copy(copyFileBindingModel.AllFiles, copyFileBindingModel);
                //Shows all the copied files
                ShowAllCopiedFiles();

            }
        }
        private void OpenFileBrowseDialog()
        {
            //Opens a dialog in wich the user should choose the files he wants to copy.
            specificCopyFileDialog = new OpenFileDialog();
            specificCopyFileDialog.Multiselect = true;
            specificCopyFileDialog.InitialDirectory = copyFileDialog.SelectedPath;
            DialogResult savespecificCopyFiles = specificCopyFileDialog.ShowDialog();

        }
        private void SetListWithSpecificFiles()
        {
            //Adds every choosen file in a copyFileBindingModel.SpecificFileList
            foreach (var file in specificCopyFileDialog.FileNames)
            {
                copyFileBindingModel.SpecificFileList.Add(file);
            }

        }
        private void CopySpecificFiles()
        {
            //Opens a dialog in which the user should choose where to copy the specific files.
            saveSpecificFileDialog = new FolderBrowserDialog();
            saveSpecificFileDialog.Description = "Save Specific Files Directory";
            saveSpecificFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult saveSpecificFileResult = saveSpecificFileDialog.ShowDialog();
            if (saveSpecificFileResult == DialogResult.OK)
            {
                //Saves the destination path in copyFileBindingModel.FileDestPath
                destPath = copyFileBindingModel.FileDestPath = saveSpecificFileDialog.SelectedPath;
                //Uses the Copy method from the CopierFile service
                copyFiles.Copy(copyFileBindingModel.SpecificFileList.ToArray(), copyFileBindingModel);
                //Shows all the copied files
                ShowAllCopiedFiles();
            }
        }
        private void ShowAllCopiedFiles()
        {
            //Gets all the files that are copied succesfully 
            foreach (var file in copyFileBindingModel.CopyFilesCopied)
            {
                string appendFile = file.Split('\\').Last();
                sb.AppendLine(appendFile);
            }
            //Resets the copyFileBindingModel.CopyFilesCopied for its next use.
            copyFileBindingModel.CopyFilesCopied.Clear();
            foundFilesCount = $"Copy {Regex.Matches(sb.ToString(), Environment.NewLine).Count} file(s)";
        }

    }
}
