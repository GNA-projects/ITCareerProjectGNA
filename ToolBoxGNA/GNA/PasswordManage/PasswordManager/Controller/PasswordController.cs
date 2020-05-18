using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox_GNA.Controller.PasswordManager.Entities;
using ToolBox_GNA.Controller.PasswordManager.Services;

namespace ToolBox_GNA.Controller.PasswordManager.Controller
{
	public static class PasswordController
	{
		public static List<Password> GetChromePasswords()
		{
			return PasswordServices.GetChromePasswords();
		}
	}
}
