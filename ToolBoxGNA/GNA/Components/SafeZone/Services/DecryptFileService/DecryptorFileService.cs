using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using SaveZone.Entities.CheckPasswordBindingModel;
using SaveZone.Entities.DecryptFileBindingModel;

namespace SaveZone.Services.DecryptFileService
{
    public class DecryptorFileService : IDecryptorFileService
    {
        public void AESDecryptFile(string filePath, DecryptFileBindingModel decryptFileBindingModel, CheckPasswordBindingModel passwordBindingModel)
        {
            if (passwordBindingModel.Password == decryptFileBindingModel.Password && passwordBindingModel.IV == decryptFileBindingModel.IV)
            {
                byte[] plainFile = File.ReadAllBytes(filePath);
                using (AesCryptoServiceProvider AES = new AesCryptoServiceProvider())
                {
                    AES.BlockSize = 128;
                    AES.KeySize = 128;

                    AES.IV = Encoding.UTF8.GetBytes(decryptFileBindingModel.IV);
                    AES.Key = Encoding.UTF8.GetBytes(decryptFileBindingModel.Password);
                    AES.Mode = CipherMode.CBC;

                    using (MemoryStream memStream = new MemoryStream())
                    {
                        CryptoStream cryptoStream = new CryptoStream(memStream, AES.CreateDecryptor(), CryptoStreamMode.Write);

                        cryptoStream.Write(plainFile, 0, plainFile.Length);
                        cryptoStream.FlushFinalBlock();
                        File.WriteAllBytes(filePath, memStream.ToArray());
                    }

                }
                decryptFileBindingModel.EncryptedFiles.Remove(decryptFileBindingModel.FileName);
                decryptFileBindingModel.IsDecrypted = true;
                MessageBox.Show("File Decrypted.", "File", MessageBoxButtons.OK, MessageBoxIcon.None,0,
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
