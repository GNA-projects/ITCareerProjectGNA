using SaveZone.Controllers;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SaveZone
{
    public partial class SafeZone : Form
    {
        public SafeZone()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await MainMenuController.SetEncryptFileServicerAsync();
            MainMenuController.PopulateDecryptInformationAsync(textBox1, richTextBox1);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
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
