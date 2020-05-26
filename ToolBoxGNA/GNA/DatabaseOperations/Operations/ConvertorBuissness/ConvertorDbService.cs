using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.ConvertorBuissness
{
    public static class ConvertorDbService
    {
        public static void AddDocConvert(string fileName, string filePath, bool isSuccsessful)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info docConvInfo = new Operation_Info()
                {
                    operation_id = 10,
                    operation_type_id = 4,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = "Document",
                    isSuccessfull = isSuccsessful,
                };
                
                user.Operation_Info.Add(docConvInfo);
                context.SaveChanges();
            }


        }
        public static void AddImageConvert(string fileName, string filePath, bool isSuccsessful)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info docConvInfo = new Operation_Info()
                {
                    operation_id = 11,
                    operation_type_id = 4,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = "Image",
                    isSuccessfull = isSuccsessful,
                };

                user.Operation_Info.Add(docConvInfo);
                context.SaveChanges();

                
            }


        }
    }
}




