using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
	}
}
