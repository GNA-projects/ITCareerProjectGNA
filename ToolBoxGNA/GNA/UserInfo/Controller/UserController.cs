using DatabaseOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInfo.Service;

namespace UserInfo.Controller
{
	public static class UserController
	{
		public static string GetUserInfo()
		{
			return UserService.AllUserInfo();
		}

		public static string GetUsername()
		{
			return CurrentUser.user.username;
		}
		public static void ChangeUserPassword(string newPassword)
		{
			UserService.ChangeUserPassword(newPassword);
		}

		public static void LogOut(Form mainForm, Form Login)
		{
			UserService.LogOut(mainForm, Login);
		}
	}
}
