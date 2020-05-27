using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.DesktopChangerBuissiness
{
    public static class DesktopChnagerDbService
    {
        public static void AddDesktopChange(string filename,string path, bool isSuccessfull)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info deskChangerInfo = new Operation_Info()
                {
                    operation_type_id = 7,
                    operation_id = 14,
                    additional_info = filename,
                    file_path = path,
                    file_type = "Image",
                    isSuccessfull = isSuccessfull
                };
                user.last_operation_id = 14;
                user.Operation_Info.Add(deskChangerInfo);
                context.SaveChanges();
                
            }
        }
    }
}
