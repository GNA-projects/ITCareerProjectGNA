using System.Collections.Generic;
using System.IO;


namespace FileSearcherDemo.BindingModels.SearchFileForm
{
    /* this is a class that saves all information about searching files from the User */
    public class SearchFileBindingModel
    {
        private string filesName;
        private bool isPressed;
        private Dictionary<int, string> filedic;
        private DirectoryInfo dirInfo;
        private FileInfo[] fileInfo;
        private string searchDir;
        private string destDir;
        private string saveFileName;
        private string[] filterfoundFiles;
        private List<string> filesCopied = new List<string>();

        //Saves the file name that the user wants to search.
        //This is also used to set SaveFileName property.
        public string FilesName
        {
            get { return filesName; }
            set { filesName = value; }
        }

        //Saves the user input if he presses Cancel button on SearchFile form.
        //This is also used to validate if the user presses Cancel
        public bool IsPressed
        {
            get { return isPressed; }
            set { isPressed = value; }
        }

        //Uses FileInfo property to set a dictionary with a position and a name for the files.
        //This is later used for filtering the names of the files.
        public Dictionary<int, string> FileDic
        {
            get { return filedic; }
            set { filedic = value; }
        }

        //Uses SaveDir property to save the directory of the files
        public DirectoryInfo DirInfo
        {
            get { return dirInfo; }
            set { dirInfo = value; }
        }

        //Uses DirInfo property to save all the files in the specific directory of DirectoryInfo in an array
        public FileInfo[] FileInfo
        {
            get { return fileInfo; }
            set { fileInfo = value; }
        }

        /*Uses FileDic property to filter the names of the files 
        to match the user input for the files he want to search in the folder */
        //This property saves all the files that match the user input, even if they have the letter the user gives.
        //This property is case-sensitive.
        public string[] FilterFoundFiles
        {
            get { return filterfoundFiles; }
            set { filterfoundFiles = value; }
        }

        //Saves the source directory of the folder that is choosen by the user. 
        //This is where the files that the user want to search are.
        //It is also used in CopyFileServiceAbstract service and SearcherFileService service
        //It is also used to show the source directory to the user
        public string SearchDir
        {
            get { return searchDir; }
            set { searchDir = value; }
        }

        //Uses FilesNames property to save the names of the files.
        //It is also used in FileDic property to filter the names of the files
        public string SaveFileName
        {
            get { return saveFileName; }
            set { saveFileName = value; }
        }

        //Saves the destination directory of the folder that is choosen by the user. 
        //This is where the user wants to save the files, if he wants to save them.
        //It is also used to show the destination directory to the user, if he saves the found files
        public string DestDir
        {
            get { return destDir; }
            set { destDir = value; }
        }

        //The user can choose either to save the found files in a directory or only show them.
        //Saves files that succeed copiyng in a List if user chooses to save them. 
        //This is used when validating if a file is copied. A file is added here only if it succeed copying.
        //It also used to show the files that succeed copying.
        public List<string> FilesCopied
        {
            get { return filesCopied; }
            private set { filesCopied = value; }
        }
    }
}
