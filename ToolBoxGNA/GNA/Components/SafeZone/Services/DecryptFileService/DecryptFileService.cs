using DatabaseOperations.Model;
using DatabaseOperations.Operations.SaveZoneBuisseness;
using SaveZone.Entities.CheckPasswordBindingModel;
using SaveZone.Entities.DecryptFileBindingModel;
using SaveZone.Services.EncryptFileServices;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace SaveZone.Services.DecryptFileService
{
    /*This is a service that uses DecryptorFileService and CheckPasswordForm to validate, set and get all the 
     things that the user inputs and also show him the results*/
    public class DecryptFileService
    {
        //Sets all the things needed for using the decrypt function correctly.
        private OpenFileDialog decryptFileDialog;
        private DialogResult result;
        private string fileName;
        private string decryptFileSource;
        private DecryptorFileService decryptFile = new DecryptorFileService();
        private CheckPassword CheckPasswordForm = new CheckPassword();
        private string sourcePath = " ";
        private string decryptedFile = " ";

        //This method is called in the MainMenu controller to do the decrypt function.
        public void DecryptFile(EncryptFileServicer encryptFileServicer)
        {
            OpenFileBrowseDialog();
            CheckUserInput(encryptFileServicer.ReturnDecryptFileBindingModel(), CheckPasswordForm.ReturnCheckPasswordBindingModel());
        }

        //Shows the source path to the user
        public string ShowSourcePath()
        {
            return sourcePath;
        }

        //Shows the decrypted file to the user
        public string ShowDecryptedFile()
        {
            return decryptedFile;
        }

        private void OpenFileBrowseDialog()
        {
            //Opens a dialog in which the user should choose a source folder of the ecnrypted file
            decryptFileDialog = new OpenFileDialog();
            decryptFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            result = decryptFileDialog.ShowDialog();
        }
        private void CheckUserInput(DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel checkBindingModel)
        {
            //Checks if user has pressed OK for saving the source directory of the ecnrypted file
            if (result == DialogResult.OK)
            {
                //Saves the encrypted file name
                fileName = decryptFileDialog.FileName;
                //Sets the file name of the binding model
                decryptFileBindingModel.FileName = Path.GetFileName(fileName);
                //Sets the source path for decrypting a file
                decryptFileBindingModel.FileSourcePath = decryptFileSource = Path.GetFullPath(fileName);
                //Check if a file that the user wants to be decrypted is encrypted
                CheckIfFileIsEncrypted(decryptFileBindingModel, checkBindingModel);
            }
        }
        private void CheckIfFileIsEncrypted(DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel checkBindingModel)
        {
            //Checks from the database if the file is encrypted. If it is not the query will return null
            if (SaveZoneDbService.GetEntity(decryptFileBindingModel.FileSourcePath) != null)
            {
                //Checks from the database if the file the user wants to decrypt matches with the encrypted file name
                if (SaveZoneDbService.GetEntity(decryptFileBindingModel.FileSourcePath).encrypted_name == decryptFileBindingModel.FileSourcePath)
                {
                    //Shows the CheckPasswordForm for the user to input password and IV for decryption.
                    CheckPasswordForm.ShowDialog();

                    //When OK is pressed on CheckPasswordForm it tries to decrypt the file if everything is done correctlly
                    if (checkBindingModel.OKIsPressed == true)
                    {
                        decryptFile.AESDecryptFile(decryptFileBindingModel.FileName, decryptFileSource, decryptFileBindingModel, checkBindingModel);
                    }

                    //Resets the form for next use
                    CheckPasswordForm.Dispose();
                    CheckPasswordForm = new CheckPassword();

                    //Checks if the file has decrypted correctlly
                    CheckIfFileIsDecrypted(decryptFileBindingModel);

                }
            }
            else
            {
                MessageBox.Show("File is not encrypted", "File not encrypted", MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                                  MessageBoxOptions.DefaultDesktopOnly);
            }

        }

        private void CheckIfFileIsDecrypted(DecryptFileBindingModel decryptFileBindingModel)
        {
            //if a file is decrypted it is shown to the user. Else it is null.
            if (decryptFileBindingModel.IsDecrypted == true)
            {
                sourcePath = decryptFileBindingModel.FileSourcePath;
                decryptedFile = $"File {decryptFileBindingModel.FileName} decrypted succesfully";
            }
            else
            {
                sourcePath = "";
                decryptedFile = "";
            }
        }
    }
}
