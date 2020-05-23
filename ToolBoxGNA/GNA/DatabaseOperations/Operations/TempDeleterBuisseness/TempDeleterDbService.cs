using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseOperations.Operations.TempDeleterBuisseness
{
    public static class TempDeleterDbService
    {
        public static void AddTempFiles(bool isSuccesfull, int count)
        {
            using (GNAEntities context = new GNAEntities())
            {
                if (isSuccesfull)
                {
                    Operation_Info tempInfo = new Operation_Info()
                    {
                        operation_id = 7,
                        operation_type_id = 2,
                        file_name = "Temp File",
                        file_path = Path.GetTempPath(),
                        file_type = "TempFile",
                        isSuccessfull = isSuccesfull,
                    };

                    context.Operation_Info.Add(tempInfo);
                    context.SaveChangesAsync();
                    Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                    context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == tempInfo.id);
                    user.last_operation_id = 7;
                    context.SaveChanges();
                }
                else
                {

                    Operation_Info tempInfo = new Operation_Info()
                    {
                        operation_id = 7,
                        operation_type_id = 2,
                        file_name = $"{count} undeleted temp files",
                        file_path = Path.GetTempPath(),
                        file_type = "TempFile",
                        isSuccessfull = isSuccesfull,
                    };

                    context.Operation_Info.Add(tempInfo);
                    context.SaveChangesAsync();
                    Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                    context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == tempInfo.id);
                    user.last_operation_id = 7;
                    context.SaveChanges();
                }


            }
        }
    }
}
