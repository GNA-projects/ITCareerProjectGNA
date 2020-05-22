using DatabaseOperations.Model;
using DatabaseOperations.Operations.StaticInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.FileManagerBuisseness
{
    public static class FileDatabaseServices
    {
        public static void AddSearchOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info searchinfo = new Operation_Info()
                {
                    operation_id = 1,
                    operation_type_id = 1,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };
                context.Operation_Info.Add(searchinfo);
                context.SaveChanges();
            }
        }
    }
}
