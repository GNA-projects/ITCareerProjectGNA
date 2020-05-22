using DatabaseOperations.Operations.FileManagerBuisseness;
using FileSearcherDemo.BindingModels.SearchFileForm;
using FileSearcherDemo.Services.CopyFileServices.CopyFileServiceF;
using FileSearcherDemo.Services.SearchFileService;
using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.SearchFileServices
{
    /*This is a source that uses SearcherFileService, CopierFileService and  SearchFile form to validate, set and get all the 
      things that the user inputs and also show him the results*/
    public class SearchFileService
    {
        //Sets all the things needed for using the search function correctly.
        private FolderBrowserDialog searchFileDialog;
        private DialogResult result;
        private SearchFile SearchFileForm = new SearchFile();
        private SearcherFileService searcher = new SearcherFileService();
        private DialogResult searchFileMessageBox;
        private FolderBrowserDialog saveDialog;
        private CopierFileService copyFiles = new CopierFileService();
        private StringBuilder sb = new StringBuilder();
        private string sourcePath = " ";
        private string destPath = " ";
        private string foundFilesCount = " ";

        //This method is called in the main controller to do the search function.
        public void SearchFiles()
        {
            //Shows the user to choose a source folder for files and check his input
            OpenFolderBrowseDialog();
            //CheckUserInput uses SearchFileForm.GetSearchFileBindingModel() to get the created binding model from the form.
            CheckUserInput(SearchFileForm.GetSearchFileBindingModel());
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
        public string ShowFoundFilesCount()
        {
            return foundFilesCount;
        }

        //Shows the names of the copied files
        public string ShowFoundFilesNames()
        {
            string foundFiles = sb.ToString();
            sb.Clear();
            return foundFiles;

        }

        private void OpenFolderBrowseDialog()
        {
            //Opens a dialog in which the user should choose a source folder
            searchFileDialog = new FolderBrowserDialog();
            searchFileDialog.Description = "Search Files From: ";
            searchFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            result = searchFileDialog.ShowDialog();
        }
        private void CheckUserInput(SearchFileBindingModel searchFileBindingModel)
        {
            //Checks if user has pressed OK for saving the source directory
            if (result == DialogResult.OK)
            {
                //Saves the source directory in searchFileBindingModel.SearchDir
                sourcePath = searchFileBindingModel.SearchDir = searchFileDialog.SelectedPath;
                //Shows the SearchFileForm to the user.
                try
                {
                    SearchFileForm.ShowDialog();
                }
                catch (InvalidOperationException)
                {

                    MessageBox.Show("Please, enter a name for a file before trying to search file again", "Enter name", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
                    return;
                }

                //Checks if Cancel is pressed in the SearchFileForm form.
                CheckIfCancelIsPressed(SearchFileForm.GetSearchFileBindingModel());

            }


        }
        private void CheckIfCancelIsPressed(SearchFileBindingModel searchFileBindingModel)
        {
            //Uses SearchFileBindingModel to set its properties

            if (searchFileBindingModel.IsPressed == false)
            {
                //Saves the name that the user has input if he has not pressed Cancel button
                searchFileBindingModel.SaveFileName = searchFileBindingModel.FilesName;
                //Sets the Information and the Dictionary on SearcherFileService needed for the service to work corectlly.
                searcher.SetInfo(searchFileBindingModel);
                searcher.SetFileDic(searchFileBindingModel);
                //Checks the lenght of the added files
                CheckFileLenght(searchFileBindingModel.FilterFoundFiles);
            }
            else
            {
                SearchFileForm.Dispose();
                SearchFileForm = new SearchFile();
            }
        }
        private void CheckFileLenght(string[] files)
        {
            //Uses string[] files to check if there are any files in that array.

            if (files.Length > 0)
            {
                //Asks the user if he wants to save the found files.
                searchFileMessageBox = MessageBox.Show($"Found {files.Length} file(s). Do you want to save them?", "Files Found", 
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
                //If he does not want to save them it shows him only the found files, without saving them anywhere.
                foundFilesCount = $"Found {files.Length} file(s):";
                foreach (var file in files)
                {

                    FileDatabaseServices.AddSearchOperation(file,sourcePath,"File",true);
                    sb.AppendLine(file);

                }
                CheckMessageBoxInput();
            }
            else
            {
                FileDatabaseServices.AddSearchOperation("No File", sourcePath, "None", false);

                foundFilesCount = "No files found.";
                MessageBox.Show($"No files found.", "None files", MessageBoxButtons.OK,
                                MessageBoxIcon.None, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        private void CheckMessageBoxInput()
        {
            //If the user wants to save the files, it saves all the files. 
            //Else if he presses Cancel it resets these variables
            if (searchFileMessageBox == DialogResult.Yes)
            {
                //Reset the variable for the next use
                sb.Clear();
                //Saves all the files
                CopyAllFiles(SearchFileForm.GetSearchFileBindingModel());
                SearchFileForm.Dispose();
                SearchFileForm = new SearchFile();
            }
            else if (searchFileMessageBox == DialogResult.Cancel)
            {
                SearchFileForm.Dispose();
                SearchFileForm = new SearchFile();
                sb.Clear();
                foundFilesCount = " ";
            }
            else
            {
                SearchFileForm.Dispose();
                SearchFileForm = new SearchFile();
            }
        }
        private void CopyAllFiles(SearchFileBindingModel searchFileBindingModel)
        {
            //Opens a dialog in which the user chooses the folder he wants to save the files
            saveDialog = new FolderBrowserDialog();
            saveDialog.Description = "Save Files Directory";
            saveDialog.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult saveresult = saveDialog.ShowDialog();
            if (saveresult == DialogResult.OK)
            {
                //Saves the destination path in searchFileBindingModel.DestDir
                destPath = searchFileBindingModel.DestDir = saveDialog.SelectedPath;
                //Uses the ovveride Copy method from the CopierFile service
                copyFiles.Copy(searchFileBindingModel.FilterFoundFiles, searchFileBindingModel);
                //Shows all the saved files
                ShowSearchedAndCopiedFiles(searchFileBindingModel);
            }

        }

        private void ShowSearchedAndCopiedFiles(SearchFileBindingModel searchFileBindingModel)
        {
            //Gets all the files that are saved succesfully 
            foreach (var file in searchFileBindingModel.FilesCopied)
            {
                string appendFile = file.Split('\\').Last();
                sb.AppendLine(appendFile);
            }
            //Resets the searchFileBindingModel.FilesCopied for its next use.
            searchFileBindingModel.FilesCopied.Clear();
            foundFilesCount = $"Copy {Regex.Matches(sb.ToString(), Environment.NewLine).Count} file(s)";
        }
    }

}
