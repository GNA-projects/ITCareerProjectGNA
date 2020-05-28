using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.UserBuissness
{
	public static class UserDbServices
	{
		public static string GetCurrentUsername()
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				return CurrentUser.user.username;
			}
		}
		public static string GetLastLoginDate()
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				return CurrentUser.user.last_login.ToString();
			}
		}
		public static string GetRegistrationDate()
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				return CurrentUser.user.register_date.ToString();
			}
		}
		public static string GetLastOperation()
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				return context.Operation_Ids.FirstOrDefault(x => x.id == CurrentUser.user.last_operation_id).operation_name;
			}
		}
		public static void ChangePassword(string newPassword)
		{
			StringBuilder hashedPassword = new StringBuilder();
			using (GNAEntities context = new GNAEntities())
			{
				using (MD5 md5 = MD5.Create())
				{

					byte[] hashPassword = md5.ComputeHash(Encoding.UTF8.GetBytes(newPassword));
					foreach (var hash in hashPassword)
					{
						hashedPassword.Append(hash.ToString("X2"));
					}

				}
				string pass = hashedPassword.ToString();
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				CurrentUser.user.password = pass;
				context.SaveChanges();
			}
		}
	}
}
