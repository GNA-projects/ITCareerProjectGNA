using DatabaseOperations.Model;
using DatabaseOperations.Model.PasswordManagerModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.PasswordManagerBuissiness
{
	public static class PasswordManagerServices
	{
		public static async void AddPasswordOperationAsync()
		{
			await Task.Run(() => AddPasswordOperation());
		}
		public static async void AddPasswordManagerAsync(List<Password> passwords)
		{
			await Task.Run(() => AddPasswordManager(passwords));
		}
		public static void AddPasswordOperation()
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				Operation_Info operation = new Operation_Info()
				{
					operation_type_id = 5,
					operation_id = 12,
					isSuccessfull = true,
					additional_info = "Passwords from Chrome are saved"
				};
				CurrentUser.user.last_operation_id = 12;
				CurrentUser.user.Operation_Info.Add(operation);
				context.SaveChanges();
			}

		}

		public static void AddPasswordManager(List<Password> passwords)
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				foreach (var passInfo in passwords)
				{
					byte[] passwordByte = ASCIIEncoding.ASCII.GetBytes(passInfo.LoginPassword);
					byte[] protectedPassByte = ProtectedData.Protect(passwordByte, null, DataProtectionScope.CurrentUser);
					string protectedPassword = ASCIIEncoding.ASCII.GetString(protectedPassByte);
					UserPasswordManager passwordManager = new UserPasswordManager()
					{
						user_password = protectedPassByte,
						account_website = passInfo.LoginUrl,
						user_email = passInfo.LoginUsername
					};
					CurrentUser.user.UserPasswordManager.Add(passwordManager);
				}
				context.SaveChanges();
			}
		}
	}
}
