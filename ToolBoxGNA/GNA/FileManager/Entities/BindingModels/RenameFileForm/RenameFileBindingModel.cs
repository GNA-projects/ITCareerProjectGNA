
namespace FileSearcherDemo.BindingModels.RenameFileForm
{
    /* this is a class that saves all information about choosen file to be renamed from the User */
    public class RenameFileBindingModel
    {
        private string fileName;
        private string newName;
        private bool isPressed;
        private bool isRenamed;

        //Saves the old name of the file that is renamed
        //It is used to rename a file and to show the old name of the file to the user
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        //Saves the new name of the file that is renamed
        //It is used to rename a file and to show the new name of the file to the user
        public string NewName
        {
            get { return newName; }
            set { newName = value; }
        }

        //Saves the user input if he presses Cancel button on RenameFile form.
        //This is also used to validate if the user presses Cancel
        public bool IsPressed
        {
            get { return isPressed; }
            set { isPressed = value; }
        }

        //Checks if a file is renamed successfully
        //This is used when validating if a file is renamed. Returns true only if it succeed renameing.
        public bool IsRenamed
        {
            get { return isRenamed; }
            set { isRenamed = value; }
        }
    }
}
