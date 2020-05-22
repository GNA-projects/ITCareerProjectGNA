using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.LoginRegister
{
	public static class RegisterService
	{
		public static void RegisterUser(string username, string password)
		{
			using (GNAEntities context = new GNAEntities())
			{
				Users user = new Users()
				{
					username = username,
					password = password,
					IsAdmin = true
				};
				context.Users.Add(user);
				context.SaveChanges();
			}
		}
	}
}
