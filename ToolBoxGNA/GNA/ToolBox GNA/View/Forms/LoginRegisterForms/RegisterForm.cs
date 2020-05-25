using DatabaseOperations.Operations.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA.View.Forms.DesignForms;

namespace ToolBox_GNA.View.Forms.LoginRegisterForms
{
    public partial class RegisterForm : DesignForm
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                RegisterService.RegisterUser(TextBoxUsername.Text, TextBoxPassword.Text);
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            catch (DbUpdateException)
            {
                LabelMessage.Text = "Username taken! Choose another username.";
            }
            catch (DbEntityValidationException)
            {
                LabelMessage.Text = "Username or password is too long. Please choose a smaller username or password.";
            }
            
        }
    }
}
