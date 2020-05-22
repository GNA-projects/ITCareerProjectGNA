using SaveZone.Controllers;
using SaveZone.Entities.CheckPasswordBindingModel;
using System;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            CheckPasswordController.CheckIfTextBoxIsEmptyAsync(textBox1.Text, textBox2.Text, this, checkPasswordBindingModel);
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckPasswordController.SetCancelIsPressedAsync(this, checkPasswordBindingModel);
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void CheckPassword_Load(object sender, EventArgs e)
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
