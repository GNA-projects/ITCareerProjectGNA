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
                    Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                    Operation_Info tempInfo = new Operation_Info()
                    {
                        operation_id = 7,
                        operation_type_id = 2,
                        file_name = "Temp File",
                        file_path = Path.GetTempPath(),
                        file_type = "TempFile",
                        isSuccessfull = isSuccesfull,
                    };

                    user.Operation_Info.Add(tempInfo);
                    context.SaveChanges();
                }
                else
                {

                    Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                    Operation_Info tempInfo = new Operation_Info()
                    {
                        operation_id = 7,
                        operation_type_id = 2,
                        file_name = $"{count} undeleted temp files",
                        file_path = Path.GetTempPath(),
                        file_type = "TempFile",
                        isSuccessfull = isSuccesfull,
                    };

                    user.Operation_Info.Add(tempInfo);
                    context.SaveChanges();
                }


            }
        }
    }
}
