using DatabaseOperations.Model;
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
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info searchInfo = new Operation_Info()
                {
                    operation_id = 1,
                    operation_type_id = 1,
                    additional_info = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                   
                };
                user.last_operation_id = 1;
                user.Operation_Info.Add(searchInfo);
                context.SaveChanges();
            }
        }
        public static void AddCopyOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info copyInfo = new Operation_Info()
                {
                    operation_id = 2,
                    operation_type_id = 1,
                    additional_info = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };
                user.last_operation_id = 2;
                user.Operation_Info.Add(copyInfo);
                context.SaveChanges();

               
            }
        }
        public static void AddMoveOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info moveInfo = new Operation_Info()
                {
                    operation_id = 3,
                    operation_type_id = 1,
                    additional_info = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };
                user.last_operation_id = 3;
                user.Operation_Info.Add(moveInfo);
                context.SaveChanges();

            }
        }
        public static void AddDeleteOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info deleteInfo = new Operation_Info()
                {
                    operation_id = 4,
                    operation_type_id = 1,
                    additional_info = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };
                user.last_operation_id = 4;
                user.Operation_Info.Add(deleteInfo);
                context.SaveChanges();

               
            }
        }
        public static void AddCreateOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info moveInfo = new Operation_Info()
                {
                    operation_id = 5,
                    operation_type_id = 1,
                    additional_info = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };
                user.last_operation_id = 5;
                user.Operation_Info.Add(moveInfo);
                context.SaveChanges();

                
            }
        }
        public static void AddRenameOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info renameInfo = new Operation_Info()
                {
                    operation_id = 6,
                    operation_type_id = 1,
                    additional_info = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };
                user.last_operation_id = 6;
                user.Operation_Info.Add(renameInfo);
               
            }
        }
    }
}
