using SaveZone.Entities.DecryptFileBindingModel;
using SaveZone.Entities.EncryptFileBindingModel;
using SaveZone.Services.EncryptFileService;
using System;
using System.IO;
using System.Windows.Forms;

namespace SaveZone.Services.EncryptFileServices
{
    /*This is a service that uses EncryptorFileService and both binding models to validate, set and get all the 
     things that the user inputs and also show him the results*/
    public class EncryptFileServicer
    {
        //Sets all the things needed for using the encrypt function correctly.
        private OpenFileDialog encryptFileDialog;
        private DialogResult result;
        private string fileName;
        private string encryptFileSource;
        EncryptorFileService encryptorFile = new EncryptorFileService();
        EncryptFileBindingModel encryptFileBindingModel = new EncryptFileBindingModel();
        DecryptFileBindingModel decryptFileBindingModel = new DecryptFileBindingModel();
        private string sourcePath;
        private string encryptedFile;

        //This method is called in the MainMenu controller to do the encrypt function.
        public void EncryptFile()
        {
            OpenFileBrowseDialog();
            CheckUserInput(encryptFileBindingModel);
        }

        //Shows the source path to the user
        public string ShowSourcePath()
        {
            return sourcePath;
        }

        //Shows the encrypted file to the user
        public string ShowEncryptedFile()
        {
            return encryptedFile;
        }


        public DecryptFileBindingModel ReturnDecryptFileBindingModel()
        {
            return this.decryptFileBindingModel;
        }


        private void OpenFileBrowseDialog()
        {
            //Opens a dialog in which the user should choose a source folder
            encryptFileDialog = new OpenFileDialog();
            encryptFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            result = encryptFileDialog.ShowDialog();
        }
        private void CheckUserInput(EncryptFileBindingModel encryptFileBindingModel)
        {
            //Checks if user has pressed OK for saving the source directory
            if (result == DialogResult.OK)
            {
                //Saves the file name
                fileName = encryptFileDialog.FileName;
                //Sets the file name of the binding model
                encryptFileBindingModel.FileName = Path.GetFileName(fileName);
                //Sets the source path
                encryptFileSource = Path.GetFullPath(fileName);
                //Tries to encrypt the file
                encryptorFile.AESEncryptFile(encryptFileSource, encryptFileBindingModel, decryptFileBindingModel);
                //Checks if the method has encrypted the file
                CheckIfEncrypted(encryptFileBindingModel);
            }
        }
        private void CheckIfEncrypted(EncryptFileBindingModel encryptFileBindingModel)
        {
            //if a file is encrypted it is shown to the user. Else it is null.
            if (encryptFileBindingModel.IsEncrypted == true)
            {
                encryptedFile = $"File {encryptFileBindingModel.FileName} was encrypted successfully";
                sourcePath = encryptFileSource;
            }
            else
            {
                encryptedFile = "";
                sourcePath = "";
            }

        }



    }
}
