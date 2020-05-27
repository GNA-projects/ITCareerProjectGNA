using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DatabaseOperations.Operations.SaveZoneBuisseness;
using SaveZone.Entities.CheckPasswordBindingModel;
using SaveZone.Entities.DecryptFileBindingModel;

namespace SaveZone.Services.DecryptFileService
{
    /* this is a class used for decrypting a file */
    public class DecryptorFileService : IDecryptorFileService
    {
        bool isDone = false;
        public void AESDecryptFile(string fileName, string filePath, DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel passwordBindingModel)
        {
            //Checks from the database if the password and the IV that the user has given matches the password and the IV of the ecnrypted file
            if (passwordBindingModel.Password == SaveZoneDbService.GetEntity(filePath).encrypted_password && passwordBindingModel.IV == SaveZoneDbService.GetEntity(filePath).encrypted_IV)
            {
                //Makes a byte[] of the given file so that it can be used for mixing information 
                //It is used by the algorithm to mix its information with the key and IV information
                byte[] plainFile = File.ReadAllBytes(filePath);
                //Sets an AES algorithm for decrypting file. AES is used also in ecnrypting file
                using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
                {
                    //Sets the block information to 128 bits
                    AES.BlockSize = 128;
                    //Sets the key to 128 bits
                    AES.KeySize = 128;

                    //Uses the IV and the password that is used for encrypting the file for decrypting the file
                    AES.IV = Encoding.UTF8.GetBytes(SaveZoneDbService.GetEntity(filePath).encrypted_IV);
                    AES.Key = Encoding.UTF8.GetBytes(SaveZoneDbService.GetEntity(filePath).encrypted_password);
                    AES.Mode = CipherMode.CBC;

                    //Uses a memory stream to write to the memory. It relates to where the stream is stored 
                    //It is used to write over a binary data with AES algorithm. 
                    using (MemoryStream memStream = new MemoryStream())
                    {
                        //Decrypts file with CryptoStream
                        CryptoStream cryptoStream = new CryptoStream(memStream, AES.CreateDecryptor(), CryptoStreamMode.Write);

                        cryptoStream.Write(plainFile, 0, plainFile.Length);
                        //Cleares the block in case there is binary left
                        cryptoStream.FlushFinalBlock();
                        File.WriteAllBytes(filePath, memStream.ToArray());
                    }

                }
                isDone = true;
                //Saves the decrypted file to the database
                SaveZoneDbService.AddDecryptFileEngine(filePath, filePath, SaveZoneDbService.GetEntity(filePath).encrypted_IV, SaveZoneDbService.GetEntity(filePath).encrypted_password);
                //Removes the encrypted file from the database
                SaveZoneDbService.RemoveFromEncrypted(filePath);
                SaveZoneDbService.AddDecryptFileInfo(fileName, filePath, true);
                decryptFileBindingModel.IsDecrypted = true;
                MessageBox.Show("File Decrypted.", "File", MessageBoxButtons.OK, MessageBoxIcon.None, 0,
                               MessageBoxOptions.DefaultDesktopOnly);

            }
            else
            {
                decryptFileBindingModel.IsDecrypted = false;
                MessageBox.Show("Wrong password or IV", "Wrong Password or IV", MessageBoxButtons.OK, MessageBoxIcon.Warning, 0,
                               MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
