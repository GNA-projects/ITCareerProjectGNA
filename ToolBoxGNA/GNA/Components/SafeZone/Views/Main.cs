using SaveZone.Controllers;
using System;
using System.Windows.Forms;

namespace SaveZone
{
    public partial class SafeZone : Form
    {

        public SafeZone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuController.SetEncryptFileServicerAsync();
            MainMenuController.PopulateEncryptInformationNonAsync(textBox1, richTextBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenuController.SetDecryptFileServicerAsync();
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
