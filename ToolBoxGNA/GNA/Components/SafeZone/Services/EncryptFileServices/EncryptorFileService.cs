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
    /* this is a class used for encrypting a file */
    public class EncryptorFileService : IEncryptorFileService
    {
        //generates random key from letters
        private char[] letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890`-='./".ToCharArray();
        private string password = "";
        private string IV = "";
        private Random random = new Random();
        private UTF8Encoding utf8 = new UTF8Encoding();

        public void AESEncryptFile(string filePath, EncryptFileBindingModel encryptBindingModel, DecryptFileBindingModel decryptBindingModel)
        {
            //Checks from the database if the file choosen is already encrypted. If it is stored in the database
            //as an encrypted file it says that it is already encrypted.
            if (SaveZoneDbService.GetAllEntitiesWithName(filePath).Count==0)
            {
                //Adds to a list the file name of the file choosen.
                decryptBindingModel.EncryptedFiles.Add(encryptBindingModel.FileName);
                //Generates Key
                GenerateKey(encryptBindingModel, decryptBindingModel);
                //Generates IV
                GenerateIV(encryptBindingModel, decryptBindingModel);
                //Sets the source path to the binding model
                encryptBindingModel.FileSourcePath = filePath;

                //Encrypts the file choosen
                EncryptFile(filePath);
                //Checks if the user wants to save the password and the IV in a file.
                CheckUserInput(encryptBindingModel);

                //Resets the IV and password for next use
                IV = "";
                password = "";
                encryptBindingModel.IsEncrypted = true;
                //Adds encrypted file to the database
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


        //Checks if user want to save the Password and the IV anywhere.
        private void CheckUserInput(EncryptFileBindingModel encryptBindingModel)
        {
            var msgBox = MessageBox.Show($"File {encryptBindingModel.FileName} encrypted succesfully. \r\nPassword: {password} \r\nIV: {IV} \r\n\r\nDo you want to save the password and the IV in a new text file ?",
                                          "File Encrypted", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0,
                                           MessageBoxOptions.DefaultDesktopOnly);

            //It is used if the user wants to save the password and the IV in a text file
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
            //It is used when the user wants to copy the IV and the Password in the clipboard
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
            //Makes a byte[] of the given file so that it can be used for mixing information 
            //It is used by the algorithm to mix its information with the key and IV information
            byte[] plainFile = File.ReadAllBytes(filePath);
            //Sets an AES algorithm for decrypting file. AES is used also in decrypting file
            using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
            {
                //Sets the block information to 128 bits
                AES.BlockSize = 128;
                //Sets the key to 128 bits
                AES.KeySize = 128;

                //Gets the random IV and Password and turns it into 16 bytes to be used into the AES algorithm.
                //It is 16 bytes because AES uses 128 bit block which needs 16 byte key and 16 byte IV.
                AES.IV = utf8.GetBytes(IV);
                AES.Key = utf8.GetBytes(password);
                AES.Mode = CipherMode.CBC;
                AES.Padding = PaddingMode.PKCS7;

                //Uses a memory stream to write to the memory. It relates to where the stream is stored 
                //It is used to write over a binary data with AES algorithm. 
                using (MemoryStream memStream = new MemoryStream())
                {
                    //Encrypts the file with CryptoStream
                    CryptoStream cryptoStream = new CryptoStream(memStream, AES.CreateEncryptor(), CryptoStreamMode.Write);

                    cryptoStream.Write(plainFile, 0, plainFile.Length);
                    //Cleares the block in case there is binary left
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(filePath, memStream.ToArray());
                }
            }
        }

        //Method for generating random Key
        private void GenerateKey(EncryptFileBindingModel encryptBindingModel, DecryptFileBindingModel decryptBindingModel)
        {
            for (int i = 0; i < 16; i++)
            {
                password += letters[random.Next(0, 68)];
            }
            encryptBindingModel.Pasword = password;
            decryptBindingModel.Password = password;
        }

        //Method for generating random IV
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
