using DatabaseOperations.Model;
using DatabaseOperations.Operations.SaveZoneBuisseness;
using SaveZone.Entities.DecryptFileBindingModel;
using SaveZone.Entities.EncryptFileBindingModel;
using SaveZone.Services.EncryptFileServices;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SaveZone.Services.EncryptFileService
{
    public class EncryptorFileService : IEncryptorFileService
    {
        private char[] letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890`-='./".ToCharArray();
        private string password = "";
        private string IV = "";
        private Random random = new Random();
        private UTF8Encoding utf8 = new UTF8Encoding();

        public void AESEncryptFile(string filePath, EncryptFileBindingModel encryptBindingModel, DecryptFileBindingModel decryptBindingModel)
        {
            
            if (SaveZoneDbService.GetAllEntitiesWithName(filePath).Count==0)
            {
                decryptBindingModel.EncryptedFiles.Add(encryptBindingModel.FileName);
                GenerateKey(encryptBindingModel, decryptBindingModel);
                GenerateIV(encryptBindingModel, decryptBindingModel);
                encryptBindingModel.FileSourcePath = filePath;

                EncryptFile(filePath);
                CheckUserInput(encryptBindingModel);

                IV = "";
                password = "";
                encryptBindingModel.IsEncrypted = true;
                SaveZoneDbService.AddEncryptFileInfo(encryptBindingModel.FileName, encryptBindingModel.FileSourcePath, true);
                
            }
            else
            {
                encryptBindingModel.IsEncrypted = false;
                SaveZoneDbService.AddEncryptFileInfo(encryptBindingModel.FileName, encryptBindingModel.FileSourcePath, false);
                MessageBox.Show("File already encrypted!", "File Already Encrypted", MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                               MessageBoxOptions.DefaultDesktopOnly);
            }

        }


        private void CheckUserInput(EncryptFileBindingModel encryptBindingModel)
        {
            var msgBox = MessageBox.Show($"File {encryptBindingModel.FileName} encrypted succesfully. \r\nPassword: {password} \r\nIV: {IV} \r\n\r\nDo you want to save the password and the IV in a new text file ?",
                                          "File Encrypted", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0,
                                           MessageBoxOptions.DefaultDesktopOnly);

            if (msgBox == DialogResult.Yes)
            {
                string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\GNA\EncryptedFiles";
                DirectoryInfo di = Directory.CreateDirectory(myDocPath);
                using (StreamWriter sw = new StreamWriter(Path.Combine(myDocPath, $"{encryptBindingModel.FileName + "-password"}.txt")))
                {
                    sw.WriteLine($"Password: {password}");
                    sw.WriteLine($"IV: {IV}");
                }
                SaveZoneDbService.AddEncryptFileEngine(encryptBindingModel.FileSourcePath, password, IV);
                MessageBox.Show($"Password and IV saved with the name {encryptBindingModel.FileName + " - password"}.txt on your startup folder of the program",
                                "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 0,
                                 MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                SaveZoneDbService.AddEncryptFileEngine(encryptBindingModel.FileSourcePath, password, IV);
                var saveMsgBox = MessageBox.Show("Do you want to copy password and the IV in the clipboard?",
                                 "Copy to clipboard", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0,
                                  MessageBoxOptions.DefaultDesktopOnly);
                
                if (saveMsgBox == DialogResult.Yes)
                {


                    { Clipboard.SetText($"Password: {password} \r\nIV: {IV}"); }
                    MessageBox.Show("Password and IV saved to clipboard!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 0,
                                     MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show("Password and IV not saved", "Not saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 0,
                                    MessageBoxOptions.DefaultDesktopOnly);
                }

            }
        }
        private void EncryptFile(string filePath)
        {
            byte[] plainFile = File.ReadAllBytes(filePath);
            using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
            {
                AES.BlockSize = 128;
                AES.KeySize = 128;

                AES.IV = utf8.GetBytes(IV);
                AES.Key = utf8.GetBytes(password);
                AES.Mode = CipherMode.CBC;
                AES.Padding = PaddingMode.PKCS7;

                using (MemoryStream memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, AES.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(plainFile, 0, plainFile.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filePath, memStream.ToArray());
                }
            }
        }
        private void GenerateKey(EncryptFileBindingModel encryptBindingModel, DecryptFileBindingModel decryptBindingModel)
        {
            for (int i = 0; i < 16; i++)
            {
                password += letters[random.Next(0, 68)];
            }
            encryptBindingModel.Pasword = password;
            decryptBindingModel.Password = password;
        }
        private void GenerateIV(EncryptFileBindingModel encryptBindingModel, DecryptFileBindingModel decryptBindingModel)
        {
            for (int i = 0; i < 16; i++)
            {
                IV += letters[random.Next(0, 68)];
            }
            encryptBindingModel.IV = IV;
            decryptBindingModel.IV = IV;
        }

    }
}
