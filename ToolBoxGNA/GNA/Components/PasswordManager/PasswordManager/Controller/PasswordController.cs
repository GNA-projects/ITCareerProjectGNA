using DatabaseOperations.Model.PasswordManagerModel;
using PasswordManager.PasswordManager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.PasswordManager.Controller
{
	public static class PasswordController
	{
		public static List<Password> GetChromePasswords()
		{
			return PasswordServices.GetChromePasswords();
		}
	}
}
