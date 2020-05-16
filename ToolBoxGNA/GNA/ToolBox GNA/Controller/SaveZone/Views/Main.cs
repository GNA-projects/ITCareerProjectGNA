using SaveZone.Controllers;
using System;
using System.Windows.Forms;

namespace SaveZone
{
    public partial class SaveZone : Form
    {

        public SaveZone()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await MainMenuController.SetEncryptFileServicerAsync();
            await MainMenuController.PopulateEncryptInformation(textBox1, richTextBox1);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await MainMenuController.SetDecryptFileServicerAsync();
            await MainMenuController.PopulateDecryptInformation(textBox2, richTextBox1);
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
