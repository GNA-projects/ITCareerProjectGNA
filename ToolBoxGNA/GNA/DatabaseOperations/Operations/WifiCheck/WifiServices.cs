using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.WifiCheck
{
	public static class WifiServices
	{
		public static void AddWifiOperationEX()
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				Operation_Info operation = new Operation_Info()
				{
					operation_type_id = 6,
					operation_id = 13,
					isSuccessfull = false,
					additional_info = $"No Wifi"
				};
				CurrentUser.user.last_operation_id = 13;
				CurrentUser.user.Operation_Info.Add(operation);
				context.SaveChanges();
			}
		}
		public static void AddWifiOperation(string wifiName)
		{
			using (GNAEntities context = new GNAEntities())
			{
				CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
				Operation_Info operation = new Operation_Info()
				{
					operation_type_id = 6,
					operation_id = 13,
					isSuccessfull = true,
					additional_info = $"Wifi name is {wifiName}"
				};
				CurrentUser.user.last_operation_id = 13;
				CurrentUser.user.Operation_Info.Add(operation);
				context.SaveChanges();
			}
		}
	}
}
