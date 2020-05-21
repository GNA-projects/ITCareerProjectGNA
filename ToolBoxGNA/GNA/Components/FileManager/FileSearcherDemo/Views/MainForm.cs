using System;
using System.Windows.Forms;
using FileSearcherDemo.Controllers;

namespace FileSearcherDemo
{
    /* this is the main view that the user see first when opening the program
       This view is used from the user for doing specific operations and calling other views*/
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //When pressed, the button raises event for searching files in a specific directroy.
        //If there are any files, the methods down return them with the source and destination path to the user.
        private async void button1_Click(object sender, EventArgs e)
        {
            //Creates a service for searching files
            await MainMenuController.SetSearchFileServiceAsync();
            MainMenuController.PopulateSearchInformationAsync(textBox1, textBox2, richTextBox1, richTextBox2);
        }

        //When pressed, the button raises event for cleaning text in the main form.
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        //When pressed, the button raises event for copying files in a specific directroy.
        //If there are any files, the methods down return them with the source and destination path to the user.
        private async void button4_Click(object sender, EventArgs e)
        {
            //Creates a service for copying files
            await MainMenuController.SetCopyFileServiceAsync();
            MainMenuController.PopulateCopyInformationAsync(textBox1, textBox2, richTextBox1, richTextBox2);
        }

        //When pressed, the button raises event for moving files in a specific directroy.
        //If there are any files, the methods down return them with the source and destination path to the user.
        private async void button5_Click(object sender, EventArgs e)
        {
            //Creates a service for moveing files
            await MainMenuController.SetMoveFileServiceAsync();
            MainMenuController.PopulateMoveInformationAsync(textBox1, textBox2, richTextBox1, richTextBox2);
        }

        //When pressed, the button raises event for deleting files in a specific directroy.
        //If there are any files, the methods down return them with the source path to the user.
        private async void button6_Click(object sender, EventArgs e)
        {
            //Creates a service for deleting files
            await MainMenuController.SetDeleteFileServiceAsync();
            MainMenuController.PopulateDeleteInformationAsync(textBox1, richTextBox1, richTextBox2);
        }

        //When pressed, the button raises event for renameing files in a specific directroy.
        //If there are any files, the methods down return them with the source path to the user.
        private async void button7_Click(object sender, EventArgs e)
        {
            //Creates a service for renameing files
            await MainMenuController.SetRenameFileServiceAsync();
            MainMenuController.PopulateRenameInformationAsync(textBox1, richTextBox1, richTextBox2);
        }

        //When pressed, the button raises event for closing the program
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When pressed, the button raises event for creating files in a specific directroy.
        //If there are any files, the methods down return them with the source path to the user.
        private async void button10_Click(object sender, EventArgs e)
        {
            //Creates a service for creating files
            await MainMenuController.SetCreateFileServiceAsync();
            MainMenuController.PopulateCreateInformationAsync(textBox2, richTextBox1, richTextBox2);
        }

        //Clears all text
        private void ClearAll()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            richTextBox1.Text = String.Empty;
            richTextBox2.Text = String.Empty;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
