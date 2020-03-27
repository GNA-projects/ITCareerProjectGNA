using GDN_Toolbox.Data.UserDataLogin;
using GDN_Toolbox.Data.UserDataRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDN_Toolbox
{
    public partial class RegisterForm : MainDesignForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            //Test For The Button
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            //Adding the Username and Password to a static Class
            UserDataRegister.Username = TextBoxUsername.Text;
            UserDataRegister.Password = TextBoxPassword.Text;
        }
    }
}
