using DatabaseOperations.Operations.FileManagerBuisseness;
using FileSearcherDemo.Entities.BindingModels.DeleteFileBindingModel;
using System.IO;
using System.Windows.Forms;

namespace FileSearcherDemo.Services.DeleteFileServices.DeleteFileServiceF
{
    /*this class is a service that is used to copy the files found in a specific directory given by the user*/
    public class DeleterFileService : IDelete
    {
        bool isDeleted = false;
        public void Delete(string[] files, DeleteFileBindingModel deleteFileBindingModel)
        {
            //Uses string[] files to get all the files from a specific directory.
            //Uses DeleteFileBindingModel to get specific information from the binding model and set some properties.

            //isDeleted checks if the work has been done corretly and succesfully
            //Throws exeption if a file that should be deleted is opened while the service is trying to delete the files.
            try
            {
                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    File.Delete(file);
                    //deleteFileBindingModel.DeletedFiles property is used to add the files that are deleted in it successfully
                    deleteFileBindingModel.DeletedFiles.Add(file);
                    isDeleted = true;
                    FileDatabaseServices.AddDeleteOperation(fileName, deleteFileBindingModel.FileSourcePath, "File", true);
                }
            }
            catch (IOException)
            {
                isDeleted = false;
                FileDatabaseServices.AddDeleteOperation("Unsuccessfull operation", deleteFileBindingModel.FileSourcePath, "File", false);
                MessageBox.Show("File opened! \nPlease, close the file to proceed!", "Running process",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }

            //If everything is completed successfully, the user gets this text.
            if (isDeleted == true)
            {
                MessageBox.Show("Files deleted", "Files Deleted", MessageBoxButtons.OK, MessageBoxIcon.None, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
            }

        }
    }
}

