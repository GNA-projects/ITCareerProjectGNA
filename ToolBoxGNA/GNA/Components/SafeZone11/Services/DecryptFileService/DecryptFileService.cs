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
    public class DecryptFileService
    {
        private OpenFileDialog decryptFileDialog;
        private DialogResult result;
        private string fileName;
        private string decryptFileSource;
        private DecryptorFileService decryptFile = new DecryptorFileService();
        private CheckPassword CheckPasswordForm = new CheckPassword();
        private string sourcePath = " ";
        private string decryptedFile = " ";

        public void DecryptFile(EncryptFileServicer encryptFileServicer)
        {
            OpenFileBrowseDialog();
            CheckUserInput(encryptFileServicer, encryptFileServicer.ReturnDecryptFileBindingModel(), CheckPasswordForm.ReturnCheckPasswordBindingModel());
        }

        public string ShowSourcePath()
        {
            return sourcePath;
        }
        public string ShowDecryptedFile()
        {
            return decryptedFile;
        }

        private void OpenFileBrowseDialog()
        {
            decryptFileDialog = new OpenFileDialog();
            decryptFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            result = decryptFileDialog.ShowDialog();
        }
        private void CheckUserInput(EncryptFileServicer encryptFileServicer, DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel checkBindingModel)
        {
            if (result == DialogResult.OK)
            {
                fileName = decryptFileDialog.FileName;
                decryptFileBindingModel.FileName = Path.GetFileName(fileName);
                decryptFileBindingModel.FileSourcePath = decryptFileSource = Path.GetFullPath(fileName);
                CheckIfFileIsEncrypted(encryptFileServicer, decryptFileBindingModel, checkBindingModel);
            }
        }
        private void CheckIfFileIsEncrypted(EncryptFileServicer encryptFileServicer, DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel checkBindingModel)
        {
            if (SaveZoneDbService.GetEntity(decryptFileBindingModel.FileSourcePath) != null)
            {
                if (SaveZoneDbService.GetEntity(decryptFileBindingModel.FileSourcePath).encrypted_name == decryptFileBindingModel.FileSourcePath)
                {
                    CheckPasswordForm.ShowDialog();

                    if (checkBindingModel.OKIsPressed == true)
                    {
                        decryptFile.AESDecryptFile(decryptFileBindingModel.FileName, decryptFileSource, decryptFileBindingModel, checkBindingModel);

                    }

                    CheckPasswordForm.Dispose();
                    CheckPasswordForm = new CheckPassword();

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
