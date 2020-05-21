using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.LoginRegister
{
	public static class LoginService
	{
		public static bool CheckIf(string username, string password)
		{
			using (POs3de1PIIEntities context = new POs3de1PIIEntities())
			{
				User user = context.Users.FirstOrDefault(x => x.username == username && x.password == password);

				if (user != null)
				{
					return true;
				}
				else {return false; }
			}
		}
	}
}
