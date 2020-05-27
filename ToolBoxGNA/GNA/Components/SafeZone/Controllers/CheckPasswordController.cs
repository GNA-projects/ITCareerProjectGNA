using SaveZone.Entities.CheckPasswordBindingModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveZone.Controllers
{
    /*This is a class that sets Button properties of the binding model needed for checking 
      password in CheckPassword view*/
    public static class CheckPasswordController
    {
        public static async void CheckIfTextBoxIsEmptyAsync(string textBoxText, string textBox2Text, CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            //uses string textBoxText and textBox2Text to get user input for the password and the IV for decryption.
            //uses CheckPassword Form to close the specific Form
            //uses CheckPasswordBindingModel to set its properties.
            if (textBoxText != "" && textBox2Text != "")
            {
                await Task.Run(() => SetCheckPasswordBindingModel(textBoxText, textBox2Text, checkPasswordBindingModel));
                await Task.Run(() => SetCheckFileBindingModelOKIsPressed(checkPasswordBindingModel));
                CheckForm.Close();
            }
            else
            {
                await Task.Run(() => ShowMessageBox());
            }
        }

        //Syncronous method of CheckIfTextBoxIsEmptyAsync
        public static void CheckIfTextBoxIsEmptyNonAsync(string textBoxText, string textBox2Text, CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            if (textBoxText != "" && textBox2Text != "")
            {
                SetCheckPasswordBindingModel(textBoxText, textBox2Text, checkPasswordBindingModel);
                SetCheckFileBindingModelOKIsPressed(checkPasswordBindingModel);
                CheckForm.Close();
            }
            else
            {
                 ShowMessageBox();
            }
        }

        public static async void SetCancelIsPressedAsync(CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            //Uses CheckPassword Form to close the specific form.
            //Uses CheckPasswordBindingModel to set that cancel is pressed on that form.
            await Task.Run(() => SetCancelIsPressed(CheckForm, checkPasswordBindingModel));
        }

        //Syncronous method of SetCancelIsPressedAsync
        public static void SetCancelIsPressedNonAsync(CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            SetCancelIsPressed(CheckForm, checkPasswordBindingModel);
        }

        private static void SetCheckFileBindingModelOKIsPressed(CheckPasswordBindingModel checkPasswordBindingModel)
        {
            //Uses CheckPassword Form to close the specific form.
            //Uses CheckPasswordBindingModel to set that cancel is pressed on that form.
            checkPasswordBindingModel.OKIsPressed = true;
        }

        private static void SetCancelIsPressed(CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            checkPasswordBindingModel.CancelIsPressed = true;
            CheckForm.Close();
        }
        private static void SetCheckPasswordBindingModel(string textBoxText, string textBox2Text, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            //Sets the password and the IV of the CheckPasswordBindingModel bindingModel.
            checkPasswordBindingModel.Password = textBoxText;
            checkPasswordBindingModel.IV = textBox2Text;

        }
        private static void ShowMessageBox()
        {
            MessageBox.Show("Please enter Password and IV!", "Enter password and IV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
