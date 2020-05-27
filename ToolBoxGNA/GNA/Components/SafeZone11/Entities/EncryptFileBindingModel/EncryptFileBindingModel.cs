using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveZone.Entities.EncryptFileBindingModel
{
    /* this is a class that saves all information about choosen file to be encrypted from the User */
    public class EncryptFileBindingModel
    {
        private string fileName;
        private string password;
        private string fileSourcePath;
        private string iv;
        private bool isEncrypted;

        //Saves the name of the file that is encrypted
        //It is used to encrypt a file and to show it to the user
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        //Saves the source path of the file that is encrypted
        //It is used to show it to the user
        public string FileSourcePath
        {
            get { return fileSourcePath; }
            set { fileSourcePath = value; }
        }

        //Saves the auto-generated encryption password
        public string Pasword
        {
            get { return password; }
            set { password = value; }
        }

        //Saves the auto-generated encryption IV
        public string IV
        {
            get { return iv; }
            set { iv = value; }
        }

        //It is used to check if a file has been encrypted correctlly
        public bool IsEncrypted
        {
            get { return isEncrypted; }
            set { isEncrypted = value; }
        }
    }
}
