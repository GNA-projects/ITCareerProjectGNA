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
	public partial class FormLogin : MainFormStyle
	{

		bool passwordIsUnmasked = false;
		public FormLogin()
		{
			InitializeComponent();
		}


		private void TextBoxUsername_Click(object sender, EventArgs e)
		{
			textBoxUsername.Text = "";
			textBoxUsername.ForeColor = Color.Black;
		}
		private void TextBoxPassword_Click(object sender, EventArgs e)
		{
			textBoxPassword.Text = "";
			textBoxPassword.ForeColor = Color.Black;
			textBoxPassword.PasswordChar = '*';
		}
		private void ButtonRevealPassword_Click(object sender, EventArgs e)
		{
			if (passwordIsUnmasked == false)
			{
				passwordIsUnmasked = true;
				textBoxPassword.PasswordChar = '\0';

			}
			else
			{
				passwordIsUnmasked = false;
				textBoxPassword.PasswordChar = '*';
			}
		}
	}
}

