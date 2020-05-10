using FileSearcherDemo.BindingModels.CreateFileForm;
using FileSearcherDemo.Views;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcherDemo.Controllers
{
    /* this is a class that sets FileName and Buttons properties of the binding model needed for creating a file*/
    public static class CreateMenuController
    {
        //Sets when user has pressed Cancel asynchronously on the CreateFile Form
        //Method is called in CreateFile Form to get the input of user 
        public static async Task SetCreateFileBindingModelIsPressedAsync(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateFileBindingModel to set its properties.
            await Task.Run(() => SetCreateFileBindingModelIsPressed(createFileBindingModel));
        }

        //Sets when user has pressed Text button asynchronously on the CreateFile Form
        //Method is called in CreateFile Form to get the input of user 
        public static async Task SetCreateFileBindingModelTextPressedAsync(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateFileBindingModel to set its properties.
            await Task.Run(() => SetCreateFileBindingModelTextPressed(createFileBindingModel));
        }

        //Sets when user has pressed Word button asynchronously on the CreateFile Form
        //Method is called in CreateFile Form to get the input of user 
        public static async Task SetCreateFileBindingModelWordPressedAsync(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateFileBindingModel to set its properties.
            await Task.Run(() => SetCreateFileBindingModelWordPressed(createFileBindingModel));
        }

        //Sets when user has pressed Power Point button asynchronously on the CreateFile Form
        //Method is called in CreateFile Form to get the input of user 
        public static async Task SetCreateFileBindingModelPowerPointPressedAsync(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateFileBindingModel to set its properties.
            await Task.Run(() => SetCreateFileBindingModelPowerPointPressed(createFileBindingModel));
        }

        //Sets when user has pressed Exel button asynchronously on the CreateFile Form
        //Method is called in CreateFile Form to get the input of user 
        public static async Task SetCreateFileBindingModelExcelPressedAsync(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateFileBindingModel to set its properties.
            await Task.Run(() => SetCreateFileBindingModelExelPressed(createFileBindingModel));
        }

        //Sets when user has pressed Rar button asynchronously on the CreateFile Form
        //Method is called in CreateFile Form to get the input of user 
        public static async Task SetCreateFileBindingModelRarPressedAsync(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateFileBindingModel to set its properties.
            await Task.Run(() => SetCreateFileBindingModelRarPressed(createFileBindingModel));
        }
        public static async Task CheckIfUserPressesEnterAsync(string textBoxText, CreateFile CreateFileForm, KeyPressEventArgs e, CreateFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses CreateFile Form, KeyPressEventArgs to check if user has done everything properly on that form.
            //uses CreateFileBindingModel to set its properties.

            if (e.KeyChar == (char)Keys.Enter)
            {
                //checks if user has pressed Enter in CreateFile Form
                await Task.Run(() => CheckIfTextBoxIsEmpty(textBoxText, CreateFileForm, bindingModel));

            }

        }
        public static async Task CheckIfTextBoxIsEmptyAsync(string textBoxText, CreateFile CreateFileForm, CreateFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses CreateFile Form, KeyPressEventArgs to check if user has done everything properly on that form.
            //uses CreateFileBindingModel to set its properties.

            if (textBoxText != "")
            {
                await Task.Run(() => SetCreateFileBindingModelName(textBoxText, bindingModel));
                CreateFileForm.Close();
            }
            else
            {
                await Task.Run(() => ShowMessage());
            }
        }

        //Method is used to show when user has not entered a file name to be created
        private static void ShowMessage()
        {
            MessageBox.Show("Enter file name!", "Enter file name", MessageBoxButtons.OK, MessageBoxIcon.Warning, 0,
                                MessageBoxOptions.DefaultDesktopOnly);
        }
        private static void CheckIfTextBoxIsEmpty(string textBoxText, CreateFile CreateFileForm, CreateFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses CreateFile Form, KeyPressEventArgs to check if user has done everything properly on that form.
            //uses CreateFileBindingModel to set its properties.

            if (textBoxText != "")
            {
                SetCreateFileBindingModelName(textBoxText, bindingModel);
                CreateFileForm.Close();
            }
            else
            {
                ShowMessage();
            }
        }

        //Sets the name of the file that the user wants to be created 
        private static void SetCreateFileBindingModelName(string text, CreateFileBindingModel createFileBindingModel)
        {
            //uses string text and CreateBindingModel to get the user input for a name of a file and set it to binding model
            createFileBindingModel.FileName = text;
        }

        //Sets when user has pressed Cancel 
        //Method is called to be done asynchronously
        private static void SetCreateFileBindingModelIsPressed(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateBindingModel to get the user input for a pressed button and set it to binding model
            createFileBindingModel.IsPressed = true;
        }

        //Sets when user has pressed Text button 
        //Method is called to be done asynchronously
        private static void SetCreateFileBindingModelTextPressed(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateBindingModel to get the user input for a pressed button and set it to binding model
            createFileBindingModel.TextButtonPressed = true;
        }

        //Sets when user has pressed Word button 
        //Method is called to be done asynchronously
        private static void SetCreateFileBindingModelWordPressed(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateBindingModel to get the user input for a pressed button and set it to binding model
            createFileBindingModel.WordButtonPressed = true;
        }

        //Sets when user has pressed Power Point button 
        //Method is called to be done asynchronously
        private static void SetCreateFileBindingModelPowerPointPressed(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateBindingModel to get the user input for a pressed button and set it to binding model
            createFileBindingModel.PowerPointButtonPressed = true;
        }

        //Sets when user has pressed Excel button
        //Method is called to be done asynchronously
        private static void SetCreateFileBindingModelExelPressed(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateBindingModel to get the user input for a pressed button and set it to binding model
            createFileBindingModel.ExcelButtonPressed = true;
        }

        //Sets when user has pressed Rar  
        //Method is called to be done asynchronously
        private static void SetCreateFileBindingModelRarPressed(CreateFileBindingModel createFileBindingModel)
        {
            //uses CreateBindingModel to get the user input for a pressed button and set it to binding model
            createFileBindingModel.RarButtonPressed = true;
        }





    }
}
