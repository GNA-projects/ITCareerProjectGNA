using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GDN_Toolbox.Data.UserDataLogin;

namespace GDN_Toolbox.Data.Presenter
{
	public static class UserPresenter
	{
		public static void SetUserLoginData(string username, string password)
		{
			UserDataLogin.UserDataLogin.Username = username;
			UserDataLogin.UserDataLogin.Password = password;
		}
	}
}
