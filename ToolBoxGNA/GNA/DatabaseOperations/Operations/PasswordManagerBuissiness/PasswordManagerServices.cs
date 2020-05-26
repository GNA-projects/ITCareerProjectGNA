using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.PasswordManagerBuissiness
{
	public static class PasswordManagerServices
	{
		public static void AddPasswordOperation()
		{
			using (GNAEntities context = new GNAEntities())
			{
				Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				Operation_Info operation = new Operation_Info()
				{
					operation_type_id = 5,
					operation_id = 12,
					isSuccessfull = true
				};
				user.Operation_Info.Add(operation);
				context.SaveChanges();
			}
		}
	}
}
