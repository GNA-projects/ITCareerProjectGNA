using FileSearcherDemo.BindingModels.CreateFileForm;
using FileSearcherDemo.Services.CreateFileServices.CreateExcelFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreatePowerPointFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreateRarFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreateTextFileServiceF;
using FileSearcherDemo.Services.CreateFileServices.CreateWordFileServiceF;
using FileSearcherDemo.Views;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.CreateFileServices
{
    /*This is a source that uses Create File Services and CreateFile form to validate, set and get all the 
      things that the user inputs and also show him the results*/
    public class CreateFileService
    {
        //Sets all the things needed for using the rename function correctly.
        private FolderBrowserDialog createFileDialog;
        private DialogResult result;
        private CreateFile CreateFileForm = new CreateFile();
        private CreateTextFileService createTextFileService = new CreateTextFileService();
        private CreateWordFileService createWordFileService = new CreateWordFileService();
        private CreatePowerPointFileService createPowerPointFileService = new CreatePowerPointFileService();
        private CreateExelFileService createExcelFileService = new CreateExelFileService();
        private CreateRarFileService createRartFileService = new CreateRarFileService();
        private string destPath = " ";
        private string fileName = " ";
        private string fileType = " ";

        //This method is called in the main controller to do the rename function.
        public void CreateFile()
        {
            //Shows the user to choose a source folder for file and check his input
            OpenFolderBrowseDialog();
            //CheckUserInput uses CreateFileForm.GetCreateFileBindingModel() to get the created binding model from the form.
            CheckUserInput(CreateFileForm.GetCreateFileBindingModel());
        }

        //Shows the choosen destination path from the user
        public string ShowDestPath()
        {
            return destPath;
        }

        //Shows the file name
        public string ShowFileName()
        {
            return fileName;
        }

        //Shows the file type
        public string ShowFileType()
        {
            return fileType;
        }

        private void OpenFolderBrowseDialog()
        {
            //Opens a dialog in which the user should choose a destination folder
            createFileDialog = new FolderBrowserDialog();
            createFileDialog.Description = "Create File In: ";
            createFileDialog.RootFolder = Environment.SpecialFolder.Desktop;
            result = createFileDialog.ShowDialog();
        }
        private void CheckUserInput(CreateFileBindingModel createFileBindingModel)
        {
            //Uses CreateFileBindingModel to set its properties

            //Checks if user has pressed OK for saving the source directory
            if (result == DialogResult.OK)
            {
                //Saves the destination path in createFileBindingModel.DestPath
                destPath = createFileBindingModel.DestPath = createFileDialog.SelectedPath;
                //Shows the CreateFileForm to the user.
                CreateFileForm.ShowDialog();
                //Checks if Cancel is pressed in the CreateFileForm form.
                CheckIfCancelIsPressed(CreateFileForm.GetCreateFileBindingModel());
            }
        }
        private void CheckIfCancelIsPressed(CreateFileBindingModel createFileBindingModel)
        {
            //Uses CreateFileBindingModel to set its properties

            if (createFileBindingModel.IsPressed == false)
            {
                //Checks the user input in CreateFile form if the users hasn't pressed Cancel
                CheckUserPressedButton(createFileBindingModel);
            }
            else
            {
                CreateFileForm.Dispose();
                CreateFileForm = new CreateFile();
            }
        }
        private void CheckUserPressedButton(CreateFileBindingModel createFileBindingModel)
        {
            CheckAndCreateFile(createFileBindingModel);
        }
        private void CheckAndCreateFile(CreateFileBindingModel createFileBindingModel)
        {
            if (createFileBindingModel.TextButtonPressed == true)
            {
                string file = createFileBindingModel.DestPath + @"\" + $"{createFileBindingModel.FileName}.txt";
                if (!File.Exists(file))
                {
                    createTextFileService.Create(createFileBindingModel);
                    fileName = $"Created {createFileBindingModel.FileName}.txt successfully";
                    createFileBindingModel.FileType = "Text";
                    fileType = $"File type: {createFileBindingModel.FileType}";
                    createFileBindingModel.TextButtonPressed = false;

                    ShowCreatedFile(createFileBindingModel);
                }
                else
                {
                    fileName = $"File {createFileBindingModel.FileName}.txt already exists";
                    createFileBindingModel.TextButtonPressed = false;

                    ShowFileAlreadyExists();
                }
            }
            else if (createFileBindingModel.WordButtonPressed == true)
            {
                string file = createFileBindingModel.DestPath + @"\" + $"{createFileBindingModel.FileName}.docx";
                if (!File.Exists(file))
                {
                    createWordFileService.CreateWord(createFileBindingModel);
                    fileName = $"Created {createFileBindingModel.FileName}.docx successfully";
                    createFileBindingModel.FileType = "Document";
                    fileType = $"File type: {createFileBindingModel.FileType}";
                    createFileBindingModel.WordButtonPressed = false;

                    ShowCreatedFile(createFileBindingModel);
                }
                else
                {
                    fileName = $"File {createFileBindingModel.FileName}.docx already exists";
                    createFileBindingModel.WordButtonPressed = false;

                    ShowFileAlreadyExists();
                }
            }
            else if (createFileBindingModel.PowerPointButtonPressed == true)
            {
                string file = createFileBindingModel.DestPath + @"\" + $"{createFileBindingModel.FileName}.pptx";
                if (!File.Exists(file))
                {
                    createPowerPointFileService.CreatePowerPoint(createFileBindingModel);
                    fileName = $"Created {createFileBindingModel.FileName}.pptx successfully";
                    createFileBindingModel.FileType = "Presentation";
                    fileType = $"File type: {createFileBindingModel.FileType}";
                    createFileBindingModel.PowerPointButtonPressed = false;

                    ShowCreatedFile(createFileBindingModel);
                }
                else
                {
                    fileName = $"File {createFileBindingModel.FileName}.pptx already exists";
                    createFileBindingModel.PowerPointButtonPressed = false;

                    ShowFileAlreadyExists();
                }
            }
            else if (createFileBindingModel.ExcelButtonPressed == true)
            {
                string file = createFileBindingModel.DestPath + @"\" + $"{createFileBindingModel.FileName}.xlsx";
                if (!File.Exists(file))
                {
                    createExcelFileService.CreateExcel(createFileBindingModel);
                    fileName = $"Created {createFileBindingModel.FileName}.xlsx successfully";
                    createFileBindingModel.FileType = "Excel Worksheet";
                    fileType = $"File type: {createFileBindingModel.FileType}";
                    createFileBindingModel.ExcelButtonPressed = false;

                    ShowCreatedFile(createFileBindingModel);
                }
                else
                {
                    fileName = $"File {createFileBindingModel.FileName}.xlsx already exists";
                    createFileBindingModel.ExcelButtonPressed = false;

                    ShowFileAlreadyExists();
                }
            }
            else if (createFileBindingModel.RarButtonPressed == true)
            {
                string file = createFileBindingModel.DestPath + @"\" + $"{createFileBindingModel.FileName}.rar";
                if (!File.Exists(file))
                {
                    createRartFileService.CreateRar(createFileBindingModel);
                    fileName = $"Created {createFileBindingModel.FileName}.rar successfully";
                    createFileBindingModel.FileType = "Rar Archive";
                    fileType = $"File type: {createFileBindingModel.FileType}";
                    createFileBindingModel.RarButtonPressed = false;

                    ShowCreatedFile(createFileBindingModel);
                }
                else
                {
                    fileName = $"File {createFileBindingModel.FileName}.rar already exists";
                    createFileBindingModel.RarButtonPressed = false;

                    ShowFileAlreadyExists();
                }
            }
            else
            {
                return;
            }
        }

        //Shows created file with its extension
        private void ShowCreatedFile(CreateFileBindingModel createFileBindingModel)
        {
            MessageBox.Show($"File {createFileBindingModel.FileName + Path.GetExtension(createFileBindingModel.FileName)} created!", "File Created!", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information, 0,
                            MessageBoxOptions.DefaultDesktopOnly);
        }

        //Shows when file exists in the directory choosen by the user
        private void ShowFileAlreadyExists()
        {
            MessageBox.Show("File already exists!", "File exists", MessageBoxButtons.OK, MessageBoxIcon.None, 0,
                            MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
