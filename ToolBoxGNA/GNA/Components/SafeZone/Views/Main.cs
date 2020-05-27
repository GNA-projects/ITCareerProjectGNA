using SaveZone.Controllers;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaveZone
{
    /* this is the main view that the user see first when opening the program
      This view is used from the user for encrypting and decrypting files and calling other views*/
    public partial class SafeZone : Form
    {
        public SafeZone()
        {
            InitializeComponent();
        }

        //When pressed, the button raises event for encrypting file in a specific directroy.
        //If there is any file, the methods down return it with their name and destination path to the user.
        private async void button1_Click(object sender, EventArgs e)
        {
            //Creates a service for encrypting a file.
            await MainMenuController.SetEncryptFileServicerAsync();
            MainMenuController.PopulateDecryptInformationAsync(textBox1, richTextBox1);
        }

        //When pressed, the button raises event for decrypting file in a specific directroy.
        //If there is any file, the methods down return it with their name and destination path to the user.
        private async void button2_Click(object sender, EventArgs e)
        {
            //Creates a service for decrypting a file.
            await MainMenuController.SetDecryptFileServicerAsync();
            MainMenuController.PopulateDecryptInformationAsync(textBox2, richTextBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            richTextBox1.Text = String.Empty;
        }
    }
}
