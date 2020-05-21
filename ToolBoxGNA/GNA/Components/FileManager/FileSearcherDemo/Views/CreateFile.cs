using FileSearcherDemo.BindingModels.CreateFileForm;
using FileSearcherDemo.Controllers;
using System;
using System.Windows.Forms;

namespace FileSearcherDemo.Views
{
    /* this is a view that user uses for creating files */
    public partial class CreateFile : Form
    {
        //Creates an instance of CreateFileBindingModel to be passed down the flow to the CreateFileService
        private CreateFileBindingModel bindingModel = new CreateFileBindingModel();

        //This method is used to pass the CreateFileBindingModel to the CreateFileService
        public CreateFileBindingModel GetCreateFileBindingModel()
        {
            return this.bindingModel;
        }
        public CreateFile()
        {
            InitializeComponent();
        }

        //When pressed, the TextPressed property of CreateFileBindingModel is set to true
        //When pressed, the button raises event for checking if the user uses the program correctly
        private void button1_Click(object sender, EventArgs e)
        {
            CreateMenuController.SetCreateFileBindingModelTextPressedAsync(bindingModel);
            CreateMenuController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, this, bindingModel);
            //Resets textbox for next use
            textBox1.Text = String.Empty;
        }

        //When pressed, the WordPressed property of CreateFileBindingModel is set to true
        //When pressed, the button raises event for checking if the user uses the program correctly
        private void button2_Click(object sender, EventArgs e)
        {
            CreateMenuController.SetCreateFileBindingModelWordPressedAsync(bindingModel);
            CreateMenuController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, this, bindingModel);
            //Resets textbox for next use
            textBox1.Text = String.Empty;

        }

        //When pressed, the PowerPointPressed property of CreateFileBindingModel is set to true
        //When pressed, the button raises event for checking if the user uses the program correctly
        private void button3_Click(object sender, EventArgs e)
        {
            bindingModel.PowerPointButtonPressed = false;
            CreateMenuController.SetCreateFileBindingModelPowerPointPressedAsync(bindingModel);
            CreateMenuController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, this, bindingModel);
            //Resets textbox for next use
            textBox1.Text = String.Empty;

        }

        //When pressed, the ExcelPressed property of CreateFileBindingModel is set to true
        //When pressed, the button raises event for checking if the user uses the program correctly
        private void button4_Click(object sender, EventArgs e)
        {

            CreateMenuController.SetCreateFileBindingModelExcelPressedAsync(bindingModel);
            CreateMenuController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, this, bindingModel);
            //Resets textbox for next use
            textBox1.Text = String.Empty;

        }

        //When pressed, RarPressed property of CreateFileBindingModel is set to true
        //When pressed, the button raises event for checking if the user uses the program correctly
        private void button5_Click(object sender, EventArgs e)
        {
            CreateMenuController.SetCreateFileBindingModelRarPressedAsync(bindingModel);
            CreateMenuController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, this, bindingModel);
            //Resets textbox for next use
            textBox1.Text = String.Empty;

        }

        //When pressed, the button raises event for closing CreateFile Form 
        //When pressed, the IsPressed property of CreateFileBindingModel is set to true
        private void button6_Click(object sender, EventArgs e)
        {
            CreateMenuController.SetCreateFileBindingModelIsPressedAsync(bindingModel);
            //Resets textbox for next use
            textBox1.Text = String.Empty;
            this.Close();
        }

        //When used, the KeyEvent handler checks if user presses enter.
        //When used, the KeyEvent handler checks if user uses the program correctly
        private void CreateFile_KeyPress(object sender, KeyPressEventArgs keyEvent)
        {
            CreateMenuController.CheckIfUserPressesEnterAsync(textBox1.Text, this, keyEvent, bindingModel);
        }

        private void CreateFile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
