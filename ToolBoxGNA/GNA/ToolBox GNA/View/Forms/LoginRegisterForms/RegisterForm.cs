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
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
