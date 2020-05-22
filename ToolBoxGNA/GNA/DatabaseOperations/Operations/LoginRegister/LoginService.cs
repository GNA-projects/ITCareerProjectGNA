using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.LoginRegister
{
	public static class LoginService
	{
		public static bool LoginUser(string username, string password)
		{
			using (GNAEntities context = new GNAEntities())
			{
				Users user = context.Users.FirstOrDefault(x => x.username == username && x.password == password);
				if (user != null) return true;
				else return false;
			}
		}
	}
}
