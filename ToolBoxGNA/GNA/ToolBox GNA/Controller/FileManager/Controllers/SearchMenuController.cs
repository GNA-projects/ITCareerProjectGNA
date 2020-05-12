using FileSearcherDemo.BindingModels.SearchFileForm;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcherDemo.Controllers
{
    /* this is a class that sets FileNames and IsPressed properties of the binding model needed for searching a file*/
    public static class SearchMenuController
    {
        //Sets when user has pressed Cancel asynchronously on the SearchFile Form
        //Method is called in SearchFile Form to get the input of user 
        public static async Task SetSearchFileBindingModelIsPressedAsync(SearchFileBindingModel searchFileBindingModel)
        {
            await Task.Run(() => SetSearchFileBindingModelIsPressed(searchFileBindingModel));
        }
        public static async Task CheckIfUserPressesEnterAsync(string textBoxText, SearchFile SearchFileForm, KeyPressEventArgs e, SearchFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses SearchFile Form, KeyPressEventArgs to check if user has done everything properly on that form.
            //uses SearchFileBindingModel to set its properties.

            if (e.KeyChar == (char)Keys.Enter)
            {
                //checks if user has pressed Enter in SearchFile Form
                await Task.Run(() => CheckIfTextBoxIsEmpty(textBoxText, SearchFileForm, bindingModel));
            }

        }
        public static async Task CheckIfTextBoxIsEmptyAsync(string textBoxText, SearchFile SearchFileForm, SearchFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses SearchFile Form to check if user has done everything properly on that form.
            //uses SearchFileBindingModel to set its properties.

            if (textBoxText != "")
            {

                await Task.Run(() => SetSearchFileBindingModelName(textBoxText, bindingModel));
                SearchFileForm.Close();
            }
            else
            {
                await Task.Run(() => ShowMessageBox());
            }
        }

        //Method is used to show when user has not entered a file name to be created
        private static void ShowMessageBox()
        {
            MessageBox.Show("Enter file name!", "Enter file name", MessageBoxButtons.OK, 
                           MessageBoxIcon.Warning, 0,
                           MessageBoxOptions.DefaultDesktopOnly);
        }
        private static void CheckIfTextBoxIsEmpty(string textBoxText, SearchFile SearchFileForm, SearchFileBindingModel bindingModel)
        {
            //uses string textBoxText to get user input for a name of a file
            //uses RenameFile Form to check if user has done everything properly on that form.
            //uses RenameFileBindingModel to set its properties.

            if (textBoxText != "")
            {

                SetSearchFileBindingModelName(textBoxText, bindingModel);
                SearchFileForm.Close();
            }
            else
            {
                ShowMessageBox();
            }
        }

        //Sets the name of the file that the user wants to be created 
        //Method is called to be done asynchronously
        private static void SetSearchFileBindingModelName(string textBoxText, SearchFileBindingModel searchFileBindingModel)
        {
            searchFileBindingModel.FilesName = textBoxText;
        }

        //Sets when user has pressed Cancel 
        //Method is called to be done asynchronously
        private static void SetSearchFileBindingModelIsPressed(SearchFileBindingModel searchFileBindingModel)
        {
            searchFileBindingModel.IsPressed = true;
        }
    }
}
