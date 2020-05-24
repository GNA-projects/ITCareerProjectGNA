using DatabaseOperations.Model;
using Renci.SshNet.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.LoginRegister
{
	public static class LoginService
	{
		public static bool LoginUser(string username, string password)
		{
			StringBuilder hashedPassword = new StringBuilder();
			using (GNAEntities context = new GNAEntities())
			{
				using (MD5 md5 = MD5.Create())

				{
					byte[] hashPassword = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
					foreach (var hash in hashPassword)
					{
						hashedPassword.Append(hash.ToString("X2"));
					}
				}
				string pass = hashedPassword.ToString();

				Users user = context.Users.FirstOrDefault(x => x.username == username && x.password == pass);
				if (user != null)
				{
					CurrentUser.Username = user.username;
					CurrentUser.ID = user.id;
					user.last_login = DateTime.Now;
					context.SaveChanges();
					return true;
				}
				else
				{

					return false;
				}
			}
		}
	}
}
