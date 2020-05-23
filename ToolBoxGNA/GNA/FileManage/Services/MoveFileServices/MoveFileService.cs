using FileSearcherDemo.Entities.BindingModels.MoveFileBindingModel;
using FileSearcherDemo.Services.MoveFileServices.MoveFileServiceF;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.MoveFileServices
{
    /*This is a source that uses  MoverFileService and MoveFileBindingModel to validate, set and get all the 
     things that the user inputs and also show him the results*/
    public class MoveFileService
    {
        //Sets all the things needed for using the copy function correctly.
        private FolderBrowserDialog moveFileDialog;
        private DialogResult result;
        private DialogResult moveFileMessageBox;
        private FolderBrowserDialog saveDialog;
        private MoverFileService moveFiles = new MoverFileService();
        private OpenFileDialog specificMoveFileDialog;
        private FolderBrowserDialog saveSpecificFileDialog;
        private MoveFileBindingModel moveFileBindingModel = new MoveFileBindingModel();
        private StringBuilder sb = new StringBuilder();
        private string sourcePath = " ";
        private string destPath = " ";
        private string foundFilesCount = " ";

        //This method is called in the main controller to do the move function.
        public void MoveFiles()
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
        public string ShowMoveFilesCount()
        {
            return foundFilesCount;
        }

        //Shows the names of the copied files
        public string ShowMoveFilesNames()
        {
            string moveFileNames = sb.ToString();
            sb.Clear();
            return moveFileNames;
        }

        private void OpenFolderBrowseDialog()
        {
            //Opens a dialog in which the user should choose a source folder
            moveFileDialog = new FolderBrowserDialog();
            moveFileDialog.Description = "Move Files From: ";
            moveFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            result = moveFileDialog.ShowDialog();
        }
        private void CheckUserInput()
        {
            //Checks if user has pressed OK for saving the source directory
            if (result == DialogResult.OK)
            {
                //Saves the source directory in moveFileBindingModel.FileSourcePath
                sourcePath = moveFileBindingModel.FileSourcePath = moveFileDialog.SelectedPath;
                //Gets all the files in this directory to moveFileBindingModel.AllFiles
                moveFileBindingModel.AllFiles = Directory.GetFiles(moveFileBindingModel.FileSourcePath);
                //Checks the lenght of the added files
                CheckFileLenght(moveFileBindingModel.AllFiles);
            }

        }
        private void CheckFileLenght(string[] files)
        {
            //Uses string[] files to check if there are any files in that array.

            if (files.Length > 0)
            {
                //Asks the user if he wants to move all the files or specific ones.
                moveFileMessageBox = MessageBox.Show($"Found {files.Length} file(s). Do you want to move all of them?", "Files Found",
                                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 0,
                                    MessageBoxOptions.DefaultDesktopOnly);

                CheckMessageBoxInput();
            }
            else
            {
                foundFilesCount = "No files found.";
                MessageBox.Show($"No files found.", "None files", MessageBoxButtons.OK, MessageBoxIcon.None, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void CheckMessageBoxInput()
        {
            //If the user wants to move all the files, it moves all the files. 
            //Else it opens the source folder to choose the files he wants to move.
            if (moveFileMessageBox == DialogResult.Yes)
            {
                MoveAllFiles();
            }
            else if (moveFileMessageBox == DialogResult.No)
            {
                OpenFileBrowseDialog();
                SetListWithSpecificFiles();
                MoveSpecificFiles();
            }
            //He has pressed Cancel and it resets the variables
            else
            {
                foundFilesCount = " ";
                sb.Clear();
            }

        }
        private void MoveAllFiles()
        {
            //Opens a dialog in which the user chooses the folder he wants to save the files
            saveDialog = new FolderBrowserDialog();
            saveDialog.Description = "Save Files Directory";
            saveDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult saveresult = saveDialog.ShowDialog();
            if (saveresult == DialogResult.OK)
            {
                //Saves the destination path in moveFileBindingModel.FileDest
                destPath = moveFileBindingModel.FileDest = saveDialog.SelectedPath;
                //Uses the Move method from the MoverFile service
                moveFiles.Move(moveFileBindingModel.AllFiles, moveFileBindingModel);
                //Shows all the copied files
                ShowAllMovedFiles();
            }

        }
        private void OpenFileBrowseDialog()
        {
            //Opens a dialog in wich the user should choose the files he wants to move.
            specificMoveFileDialog = new OpenFileDialog();
            specificMoveFileDialog.Multiselect = true;
            specificMoveFileDialog.InitialDirectory = moveFileDialog.SelectedPath;
            DialogResult savespecificMoveFiles = specificMoveFileDialog.ShowDialog();

        }
        private void SetListWithSpecificFiles()
        {
            //Adds every choosen file in a moveFileBindingModel.SpecificFileList
            foreach (var file in specificMoveFileDialog.FileNames)
            {
                moveFileBindingModel.SpecificFileList.Add(file);
            }

        }
        private void MoveSpecificFiles()
        {
            //Opens a dialog in which the user should choose where to move the specific files.
            saveSpecificFileDialog = new FolderBrowserDialog();
            saveSpecificFileDialog.Description = "Save Specific Files Directory";
            saveSpecificFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult saveSpecificFileResult = saveSpecificFileDialog.ShowDialog();
            if (saveSpecificFileResult == DialogResult.OK)
            {
                //Saves the destination path in moveFileBindingModel.FileDest
                moveFileBindingModel.FileDest = saveSpecificFileDialog.SelectedPath;
                //Uses the Move method from the MoverFile service
                moveFiles.Move(moveFileBindingModel.SpecificFileList.ToArray(), moveFileBindingModel);
                //Shows all the moved files
                ShowAllMovedFiles();
            }
        }

        private void ShowAllMovedFiles()
        {
            //Gets all the files that are moved succesfully 
            foreach (string file in moveFileBindingModel.FilesMoved)
            {
                string appendFile = file.Split('\\').Last();
                sb.AppendLine(appendFile);
            }
            //Resets the moveFileBindingModel.FilesMoved for its next use.
            moveFileBindingModel.FilesMoved.Clear();
            foundFilesCount = $"Move {Regex.Matches(sb.ToString(), Environment.NewLine).Count} file(s)";
        }
    }
}
