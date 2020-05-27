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
                    CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                    Operation_Info tempInfo = new Operation_Info()
                    {
                        operation_id = 7,
                        operation_type_id = 2,
                        additional_info = "Temp File",
                        file_path = Path.GetTempPath(),
                        file_type = "TempFile",
                        isSuccessfull = isSuccesfull,
                    };
                    CurrentUser.user.last_operation_id = 7;
                    CurrentUser.user.Operation_Info.Add(tempInfo);
                    context.SaveChanges();
                }
                else
                {

                    CurrentUser.user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                    Operation_Info tempInfo = new Operation_Info()
                    {
                        operation_id = 7,
                        operation_type_id = 2,
                        additional_info = $"{count} undeleted temp files",
                        file_path = Path.GetTempPath(),
                        file_type = "TempFile",
                        isSuccessfull = isSuccesfull,
                    };
                    CurrentUser.user.last_operation_id = 7;
                    CurrentUser.user.Operation_Info.Add(tempInfo);
                    context.SaveChanges();
                }


            }
        }
    }
}
