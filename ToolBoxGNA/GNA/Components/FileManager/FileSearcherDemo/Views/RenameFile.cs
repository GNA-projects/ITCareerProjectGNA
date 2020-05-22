using FileSearcherDemo.BindingModels.RenameFileForm;
using FileSearcherDemo.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileSearcherDemo.Views
{
    /* this is a view that user uses for renaming files */
    public partial class RenameFile : Form
    {
        //Creates an instance of RenameFileBindingModel to be passed down the flow to the RenameFileService
        private RenameFileBindingModel bindingModel = new RenameFileBindingModel();

        //This method is used to pass the RenameFileBindingModel to the RenameFileService
        public RenameFileBindingModel GetRenameFileBindingModel()
        {
            return this.bindingModel;
        }
        public RenameFile()
        {
            InitializeComponent();
        }

        //When pressed, the button raises event for checking if the user uses the program correctly
        private void button1_Click(object sender, EventArgs e)
        {
            RenameMenuController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, this, bindingModel);
            textBox1.Text = String.Empty;
        }

        //When pressed, the button raises event for closing SearchFile Form 
        //When pressed, the IsPressed property of CreateFileBindingModel is set to true
        private void button2_Click(object sender, EventArgs e)
        {
            RenameMenuController.SetRenameFileBindingModelIsPressedAsync(bindingModel);
            textBox1.Text = String.Empty;
            this.Close();
        }

        //When used, the KeyEvent handler checks if user presses enter.
        //When used, the KeyEvent handler checks if user uses the program correctly
        private void RenameFile_KeyPress(object sender, KeyPressEventArgs keyEvent)
        {
            RenameMenuController.CheckIfUserPressesEnterAsync(textBox1.Text, this, keyEvent, bindingModel);
        }

        private void RenameFile_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }

        private bool mouseDown;
        private Point lastLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
