using DatabaseOperations;
using DatabaseOperations.Operations.LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolBox_GNA;
using ToolBox_GNA.View.Forms.DesignForms;
using ToolBox_GNA.View.Forms.MainMenuForms;

namespace ToolBox_GNA.View.Forms.LoginRegisterForms
{
    public partial class LoginForm : DesignForm
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
			// bool exists =  LoginService.CheckIf(TextBoxUsername.Text, TextBoxPassword.Text);
			if (NetTest())
			{
				if (LoginService.LoginUser(TextBoxUsername.Text, TextBoxPassword.Text))
				{
					MainMenuForm mainMenuForm = new MainMenuForm();
					mainMenuForm.Show();
					this.Hide();
				}
				else
				{
					LabelMessage.Text = "Username or password is wrong! Please enter the correct credentials!";
				}
			}
			else { MessageBox.Show("Please secure an internet connections before using GNA"); }
			
        }
		public bool NetTest()
		{
			PingReply pingStatus;
			try
			{
				Ping ping = new Ping();

				pingStatus = ping.Send(IPAddress.Parse("208.69.34.231"));
			}
			catch (Exception)
			{

				return false;
			}


			if (pingStatus.Status == IPStatus.Success)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
