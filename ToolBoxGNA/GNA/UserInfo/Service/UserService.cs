using DatabaseOperations;
using DatabaseOperations.Model;
using DatabaseOperations.Operations.UserBuissness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInfo.Service
{
	public static class UserService
	{
		public static string AllUserInfo()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine($"Hello, {UserDbServices.GetCurrentUsername()}");
			stringBuilder.AppendLine($"Your last operation was: {UserDbServices.GetLastOperation()}");
			stringBuilder.AppendLine($"Your last login was: {UserDbServices.GetLastLoginDate()}");
			stringBuilder.AppendLine($"You registered in GNA on: {UserDbServices.GetRegistrationDate()}");

			return stringBuilder.ToString();
		}
		public static void ChangeUserPassword(string newPassword)
		{
			UserDbServices.ChangePassword(newPassword);
		}
		public static void LogOut(Form mainForm, Form Login)
		{
			mainForm.Dispose();
			Login.Show();
		}
	}
}
