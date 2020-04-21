using GDN_Toolbox.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDN_Toolbox.Data.Presenter
{
	static class Controller
	{
		public static void SaveUser(string username, string password)
		{
			using (ToolboxDatabase db = new ToolboxDatabase())
			{
				User user = new User
				{
					UserName = username,
					UserPassword = password
				};
				db.users.Add(user);
				db.SaveChanges();
			}
		}
		public static bool CheckUser(string username, string password)
		{
			using (ToolboxDatabase db = new ToolboxDatabase())
			{
				db.users.Where(x => (x.UserName == username && x.UserPassword == password));
			}
		}

		public async static void SaveUserAsync(string username, string password)
		{
			await Task.Run(() => SaveUser(username,password));
		}

	}
}
