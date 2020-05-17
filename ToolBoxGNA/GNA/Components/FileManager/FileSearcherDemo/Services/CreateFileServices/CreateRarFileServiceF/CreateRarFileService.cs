using FileSearcherDemo.BindingModels.CreateFileForm;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.CreateFileServices.CreateRarFileServiceF
{
    /* This is a service that creates Rar file*/
    public class CreateRarFileService : ICreateRarFileService
    {
        public void CreateRar(CreateFileBindingModel createRarFileBindingModel)
        {
            //Uses CreateFileBindingModel to get specific information from it. 

            //Sets the directory that the rar will be created with the name in a string
            string rarfolderDir = $@"{createRarFileBindingModel.DestPath}" + @"\" + $"{createRarFileBindingModel.FileName}";
            //Creates a directory with the file
            Directory.CreateDirectory(rarfolderDir);
            //Creates the Rar file
            CreateRarFolder(rarfolderDir, rarfolderDir + ".zip");
            //Deletes the rar folder and only the rar file is left
            Directory.Delete(rarfolderDir);
        }
        private static void CreateRarFolder(string sourcePath, string destinationPath)
        {
            //Tries to create a Rar file
            try
            {
                ZipFile.CreateFromDirectory(sourcePath, destinationPath);
            }
            catch (IOException)
            {
                MessageBox.Show($"File already exists", "Creating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }

        }
    }
}
