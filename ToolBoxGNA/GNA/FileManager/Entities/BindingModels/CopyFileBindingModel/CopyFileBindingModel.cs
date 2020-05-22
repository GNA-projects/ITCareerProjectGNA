using System.Collections.Generic;


namespace FileSearcherDemo.Entities.BindingModels.CopyFileBindingModel
{
    /* this is a class that saves all information about choosen files to be copied from the User */

    public class CopyFileBindingModel
    {

        private string fileSourcePath;
        private string fileDestPath;
        private string[] allFiles;
        private List<string> specificFileList = new List<string>();
        private List<string> copyFilesCopied = new List<string>();

        //Saves the source directory of the folder that is choosen by the user. 
        //This is where the files that should be copied are 
        //It is also used to show the source directory to the user
        public string FileSourcePath
        {
            get { return fileSourcePath; }
            set { fileSourcePath = value; }
        }

        //Saves the destination directory of the folder that is choosen by the user.
        //This is where the files are copied.
        //It is also used to show the destination directory to the user
        public string FileDestPath
        {
            get { return fileDestPath; }
            set { fileDestPath = value; }
        }

        //Saves all files from the source directory choosen by the user in an array.
        //This is used when user wants to copy all the files.
        public string[] AllFiles
        {
            get { return allFiles; }
            set { allFiles = value; }
        }

        //Saves specific files from the source directory choosen by the user in a List.
        //This is used when user wants to copy specific files from the source directory.
        public List<string> SpecificFileList
        {
            get { return specificFileList; }
            private set { specificFileList = value; }
        }

        //Saves files that succeed copiyng in a List.
        //This is used when validating if a file is copied. A file is added here only if it succeed copying.
        //It also used to show the files that succeed copying.
        public List<string> CopyFilesCopied
        {
            get { return copyFilesCopied; }
            private set { copyFilesCopied = value; }
        }

    }
}
