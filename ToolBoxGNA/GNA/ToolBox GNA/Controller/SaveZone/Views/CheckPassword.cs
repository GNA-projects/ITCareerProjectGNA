using SaveZone.Controllers;
using SaveZone.Entities.CheckPasswordBindingModel;
using System;
using System.Windows.Forms;

namespace SaveZone
{
    public partial class CheckPassword : Form
    {
        CheckPasswordBindingModel checkPasswordBindingModel = new CheckPasswordBindingModel();

        public CheckPasswordBindingModel ReturnCheckPasswordBindingModel()
        {
            return this.checkPasswordBindingModel;
        }
        public CheckPassword()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CheckPasswordController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, textBox2.Text, this, checkPasswordBindingModel);
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await CheckPasswordController.SetCancelIsPressedAsync(this, checkPasswordBindingModel);
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void CheckPassword_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
