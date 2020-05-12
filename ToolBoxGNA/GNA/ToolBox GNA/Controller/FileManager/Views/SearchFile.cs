using FileSearcherDemo.BindingModels.SearchFileForm;
using FileSearcherDemo.Controllers;
using System;
using System.Windows.Forms;

namespace FileSearcherDemo
{
    /* this is a view that user uses for searching files */
    public partial class SearchFile : Form
    {
        //Creates an instance of SearchFileBindingModel to be passed down the flow to the SearchFileService
        private SearchFileBindingModel bindingModel = new SearchFileBindingModel();

        //This method is used to pass the CreateFileBindingModel to the SearchFileService
        public SearchFileBindingModel GetSearchFileBindingModel()
        {
            return this.bindingModel;
        }
        public SearchFile()
        {
            InitializeComponent();
        }


        //When pressed, the button raises event for checking if the user uses the program correctly
        private async void button1_Click(object sender, EventArgs e)
        {
            await SearchMenuController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, this, bindingModel);
            textBox1.Text = String.Empty;

        }

        //When pressed, the button raises event for closing SearchFile Form 
        //When pressed, the IsPressed property of CreateFileBindingModel is set to true
        private async void button2_Click(object sender, EventArgs e)
        {
            await SearchMenuController.SetSearchFileBindingModelIsPressedAsync(bindingModel);
            //Resets textbox for next use
            textBox1.Text = String.Empty;
            this.Close();
        }

        //When used, the KeyEvent handler checks if user presses enter.
        //When used, the KeyEvent handler checks if user uses the program correctly
        private async void textBox1_KeyPress(object sender, KeyPressEventArgs keyEvent)
        {
            await SearchMenuController.CheckIfUserPressesEnterAsync(textBox1.Text, this, keyEvent, bindingModel);
        }

        private void SearchFile_Load(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
