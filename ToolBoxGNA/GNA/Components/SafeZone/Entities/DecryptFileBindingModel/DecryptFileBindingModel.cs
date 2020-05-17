using System.Collections.Generic;

namespace SaveZone.Entities.DecryptFileBindingModel
{
    /* this is a class that saves all information about choosen file to be decrypted from the User */
    public class DecryptFileBindingModel
    {
        private string fileName;
        private string fileSourcePath;
        private string password;
        private string iv;
        private List<string> encryptedFiles = new List<string>();
        private bool isDecrypted;

        //Saves the name of the file that is decrypted
        //It is used to check if the file that has to be decrypted is encrypted
        //It is used to decrypt a file and to show it to the user
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        //Saves the source path of the file that is decrypted
        //It is used to show it to the user
        public string FileSourcePath
        {
            get { return fileSourcePath; }
            set { fileSourcePath = value; }
        }

        //Saves the auto-generated decryption password, which should be the same as the encryption password
        //Used to check if the password that the user inputs is the same as the encryption password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //Saves the auto-generated decryption IV, which should be the same as the encryption IV
        //Used to check if the IV that the user inputs is the same as the encryption IV
        public string IV
        {
            get { return iv; }
            set { iv = value; }
        }

        //Saves the encrypted files in a List 
        //It is used to check if the file that the user wants to decrypt is encrypted
        //When decrypted, the encrypted files are removed from the List
        public List<string> EncryptedFiles
        {
            get { return encryptedFiles; }
            set { encryptedFiles = value; }
        }

        //It is used to check if a file has been decrypted correctlly
        public bool IsDecrypted
        {
            get { return isDecrypted; }
            set { isDecrypted = value; }
        }
    }
}
