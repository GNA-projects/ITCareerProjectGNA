using SaveZone.Entities.DecryptFileBindingModel;
using SaveZone.Entities.EncryptFileBindingModel;
using SaveZone.Services.EncryptFileService;
using System;
using System.IO;
using System.Windows.Forms;

namespace SaveZone.Services.EncryptFileServices
{
    public class EncryptFileServicer
    {
        private OpenFileDialog encryptFileDialog;
        private DialogResult result;
        private string fileName;
        private string encryptFileSource;
        EncryptorFileService encryptorFile = new EncryptorFileService();
        EncryptFileBindingModel encryptFileBindingModel = new EncryptFileBindingModel();
        DecryptFileBindingModel decryptFileBindingModel = new DecryptFileBindingModel();
        private string sourcePath;
        private string encryptedFile;

        public void EncryptFile()
        {
            OpenFileBrowseDialog();
            CheckUserInput(encryptFileBindingModel);
        }

        public string ShowSourcePath()
        {
            return sourcePath;
        }
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
            encryptFileDialog = new OpenFileDialog();
            encryptFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            result = encryptFileDialog.ShowDialog();
        }
        private void CheckUserInput(EncryptFileBindingModel encryptFileBindingModel)
        {
            if (result == DialogResult.OK)
            {
                fileName = encryptFileDialog.FileName;
                encryptFileBindingModel.FileName = Path.GetFileName(fileName);
                encryptFileSource = Path.GetFullPath(fileName);
                encryptorFile.AESEncryptFile(encryptFileSource, encryptFileBindingModel, decryptFileBindingModel);
                CheckIfEncrypted(encryptFileBindingModel);
            }
        }
        private void CheckIfEncrypted(EncryptFileBindingModel encryptFileBindingModel)
        {
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
