namespace SaveZone.Entities.CheckPasswordBindingModel
{
    /* this is a class that saves all information about the interaction with CheckPassword form*/
    public class CheckPasswordBindingModel
    {
        private bool okIsPressed;
        private bool cancelIsPressed;
        private string password;
        private string iv;

        //Saves the user input if he presses OK button on CheckPassword form.
        //This is also used to validate if the user presses OK
        public bool OKIsPressed
        {
            get { return okIsPressed; }
            set { okIsPressed = value; }
        }

        //Saves the user input if he presses Cancel button on CheckPassword form.
        //This is also used to validate if the user presses Cancel
        public bool CancelIsPressed
        {
            get { return cancelIsPressed; }
            set { cancelIsPressed = value; }
        }

        //Saves the user input if he enters password.
        //This is also used to validate if the user entered the correct password
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        //Saves the user input if he enters IV.
        //This is also used to validate if the user entered the correct IV
        public string IV
        {
            get { return iv; }
            set { iv = value; }
        }
    }
}
