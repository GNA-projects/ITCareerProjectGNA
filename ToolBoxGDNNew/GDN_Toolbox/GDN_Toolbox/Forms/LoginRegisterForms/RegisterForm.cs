using GDN_Toolbox.Data.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
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
            Data.Presenter.DatabaseCRUD.SaveUserAsync(TextBoxUsername.Text, TextBoxPassword.Text);
            //Test For The Button
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

 
        }
    }
}
