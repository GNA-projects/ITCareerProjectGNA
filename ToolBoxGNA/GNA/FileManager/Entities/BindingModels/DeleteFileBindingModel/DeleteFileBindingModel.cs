using System.Collections.Generic;

namespace FileSearcherDemo.Entities.BindingModels.DeleteFileBindingModel
{
    /* this is a class that saves all information about choosen files to be deleted from the User */
    public class DeleteFileBindingModel
    {
        private string fileSourcePath;
        private string[] allFiles;
        private List<string> specificFileList = new List<string>();
        private List<string> deletedFiles = new List<string>();

        //Saves the source directory of the folder that is choosen by the user. 
        //This is where the files that should be deleted are 
        //It is also used to show the source directory to the user
        public string FileSourcePath
        {
            get { return fileSourcePath; }
            set { fileSourcePath = value; }
        }

        //Uses FileSourcePath property and saves all files in the source directory
        //It is also used to check if there are any files and delete them.
        public string[] AllFiles
        {
            get { return allFiles; }
            set { allFiles = value; }
        }

        //Saves specific files from the source directory choosen by the user in a List.
        //This is used when user wants to delete specific files from the source directory.
        public List<string> SpecificFileList
        {
            get { return specificFileList; }
            private set { specificFileList = value; }
        }

        //Saves files that succeed deleting in a List.
        //This is used when validating if a file is deleted. A file is added here only if it succeed deleting.
        //It also used to show the files that succeed deleteing.
        public List<string> DeletedFiles
        {
            get { return deletedFiles; }
            private set { deletedFiles = value; }
        }

    }
}
