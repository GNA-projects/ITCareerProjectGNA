using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDN_Toolbox
{
    public partial class LoginForm : MainDesignForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
			//Adding the Username and Password to a static Class
			////UserPresenter.SetUserLoginData(TextBoxUsername.Text, TextBoxPassword.Text);
			//Logging in to the Main Menu Form
			MainMenuForm mainMenuForm = new MainMenuForm();
			mainMenuForm.Show();
			this.Hide();
        }
    }
}
