using FileSearcherDemo.BindingModels.RenameFileForm;
using FileSearcherDemo.Views;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcherDemo.Controllers
{
    /* this is a class that sets NewName and IsPressed properties of the binding model needed for renaming a file*/
    public static class RenameMenuController
    {
        //Sets when user has pressed Cancel asynchronously on the RenameFile Form
        //Method is called in RenameFile Form to get the input of user 
        public static async void SetRenameFileBindingModelIsPressedAsync(RenameFileBindingModel renameFileBindingModel)
        {
            await Task.Run(() => SetRenameFileBindingModelIsPressed(renameFileBindingModel));
        }
        public static void SetRenameFileBindingModelIsPressedNonAsync(RenameFileBindingModel renameFileBindingModel)
        {
             SetRenameFileBindingModelIsPressed(renameFileBindingModel);
        }
        public static async void CheckIfUserPressesEnterAsync(string textBoxText, RenameFile RenameFileForm, KeyPressEventArgs e, RenameFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a  new name of a file
            //uses RenameFile Form, KeyPressEventArgs to check if user has done everything properly on that form.
            //uses RenameFileBindingModel to set its properties.

            if (e.KeyChar == (char)Keys.Enter)
            {
                //checks if user has pressed Enter in RenameFile Form
                await Task.Run(() => CheckIfTextBoxIsEmpty(textBoxText, RenameFileForm, bindingModel));
            }

        }
        public static void CheckIfUserPressesEnterNonAsync(string textBoxText, RenameFile RenameFileForm, KeyPressEventArgs e, RenameFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a  new name of a file
            //uses RenameFile Form, KeyPressEventArgs to check if user has done everything properly on that form.
            //uses RenameFileBindingModel to set its properties.

            if (e.KeyChar == (char)Keys.Enter)
            {
                //checks if user has pressed Enter in RenameFile Form
                CheckIfTextBoxIsEmpty(textBoxText, RenameFileForm, bindingModel);
            }

        }
        public static async void CheckIfTextBoxIsEmptyAsync(string textBoxText, RenameFile RenameFileForm, RenameFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses RenameFile Form to check if user has done everything properly on that form.
            //uses RenameFileBindingModel to set its properties.

            if (textBoxText != "")
            {
                await Task.Run(() => SetRenameFileBindingModelNewName(textBoxText, bindingModel));
                RenameFileForm.Close();
            }
            else
            {
                await Task.Run(() => ShowMessageBox());
            }
        }
        public static void CheckIfTextBoxIsEmptyNonAsync(string textBoxText, RenameFile RenameFileForm, RenameFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses RenameFile Form to check if user has done everything properly on that form.
            //uses RenameFileBindingModel to set its properties.

            if (textBoxText != "")
            {
                SetRenameFileBindingModelNewName(textBoxText, bindingModel);
                RenameFileForm.Close();
            }
            else
            {
                ShowMessageBox();
            }
        }

        //Method is used to show when user has not entered a file name to be created
        private static void ShowMessageBox()
        {
            MessageBox.Show("Enter file name!", "Enter file name", MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning,0,
                                MessageBoxOptions.DefaultDesktopOnly);
        }
        private static void CheckIfTextBoxIsEmpty(string textBoxText, RenameFile RenameFileForm, RenameFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses RenameFile Form to check if user has done everything properly on that form.
            //uses RenameFileBindingModel to set its properties.

            if (textBoxText != "")
            {

                SetRenameFileBindingModelNewName(textBoxText, bindingModel);
                RenameFileForm.Close();
            }
            else
            {
                ShowMessageBox();
            }
        }

        //Sets the name of the file that the user wants to be renamed 
        //Method is called to be done asynchronously
        private static void SetRenameFileBindingModelNewName(string textBoxText, RenameFileBindingModel renameFileBindingModel)
        {
            renameFileBindingModel.NewName = textBoxText;
        }

        //Sets when user has pressed Cancel 
        //Method is called to be done asynchronously
        private static void SetRenameFileBindingModelIsPressed(RenameFileBindingModel renameFileBindingModel)
        {
            renameFileBindingModel.IsPressed = true;
        }
    }
}
