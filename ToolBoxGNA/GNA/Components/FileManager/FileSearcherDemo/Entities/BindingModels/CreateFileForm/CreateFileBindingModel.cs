
namespace FileSearcherDemo.BindingModels.CreateFileForm
{
    /* this is a class that saves all information about created file from the User */
    public class CreateFileBindingModel
    {
        private string fileName;
        private string destPath;
        private string fileType;
        private bool isPressed;
        private bool textButtonPressed;
        private bool wordButtonPressed;
        private bool powerpointButtonPressed;
        private bool excelButtonPressed;
        private bool rarButtonPressed;

        //Saves the name of the file the user wants to create.
        //It is used every time a user wants to create any type of a file.
        //It is also used when showing the created file to the user.
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        //Saves the destination path that the user wants to save the file.
        //It is used every time when a file is created successfully.
        //It is also used to show the directory path to the user 
        public string DestPath
        {
            get { return destPath; }
            set { destPath = value; }
        }

        //Saves the type of the created file.
        //It is used every time when a file is created successfully.
        //It is also used to show the created file type to the user.
        public string FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }

        //Saves the user input if he presses Cancel button on SearchFile form.
        //This is also used to validate if the user presses Cancel
        public bool IsPressed
        {
            get { return isPressed; }
            set { isPressed = value; }
        }

        //Saves the user input if he presses Text button on CreateFile form.
        //This is also used to validate if the user presses Text button.
        public bool TextButtonPressed
        {
            get { return textButtonPressed; }
            set { textButtonPressed = value; }
        }

        //Saves the user input if he presses Word button on CreateFile form.
        //This is also used to validate if the user presses Word button.
        public bool WordButtonPressed
        {
            get { return wordButtonPressed; }
            set { wordButtonPressed = value; }
        }

        //Saves the user input if he presses Power Point button on CreateFile form.
        //This is also used to validate if the user presses Power Point button.
        public bool PowerPointButtonPressed
        {
            get { return powerpointButtonPressed; }
            set { powerpointButtonPressed = value; }
        }

        //Saves the user input if he presses Excel button on CreateFile form.
        //This is also used to validate if the user presses Exel button.
        public bool ExcelButtonPressed
        {
            get { return excelButtonPressed; }
            set { excelButtonPressed = value; }
        }

        //Saves the user input if he presses Rar button on CreateFile form.
        //This is also used to validate if the user presses Rar button.
        public bool RarButtonPressed
        {
            get { return rarButtonPressed; }
            set { rarButtonPressed = value; }
        }






    }
}
