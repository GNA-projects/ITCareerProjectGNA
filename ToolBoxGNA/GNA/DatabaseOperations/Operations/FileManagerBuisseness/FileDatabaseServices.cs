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
                Operation_Info searchInfo = new Operation_Info()
                {
                    operation_id = 1,
                    operation_type_id = 1,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };

                context.Operation_Info.Add(searchInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == searchInfo.id).Users.Add(user);
                user.last_operation_id = 1;
                context.SaveChanges();
            }
        }
        public static void AddCopyOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info copyInfo = new Operation_Info()
                {
                    operation_id = 2,
                    operation_type_id = 1,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };

                context.Operation_Info.Add(copyInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == copyInfo.id).Users.Add(user);
                user.last_operation_id = 2;
                context.SaveChanges();
            }
        }
        public static void AddMoveOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info moveInfo = new Operation_Info()
                {
                    operation_id = 3,
                    operation_type_id = 1,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };

                context.Operation_Info.Add(moveInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == moveInfo.id).Users.Add(user);
                user.last_operation_id = 3;
                context.SaveChanges();
            }
        }
        public static void AddDeleteOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info deleteInfo = new Operation_Info()
                {
                    operation_id = 4,
                    operation_type_id = 1,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };

                context.Operation_Info.Add(deleteInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == deleteInfo.id).Users.Add(user);
                user.last_operation_id = 4;
                context.SaveChanges();
            }
        }
        public static void AddCreateOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info moveInfo = new Operation_Info()
                {
                    operation_id = 5,
                    operation_type_id = 1,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };

                context.Operation_Info.Add(moveInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == moveInfo.id).Users.Add(user);
                user.last_operation_id = 5;
                context.SaveChanges();
            }
        }
        public static void AddRenameOperation(string fileName, string filePath, string fileType, bool isCompleted)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info renameInfo = new Operation_Info()
                {
                    operation_id = 6,
                    operation_type_id = 1,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = fileType,
                    isSuccessfull = isCompleted,
                };

                context.Operation_Info.Add(renameInfo);
                context.Operation_Info.Add(renameInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == renameInfo.id).Users.Add(user);
                user.last_operation_id = 6;
                context.SaveChanges();
            }
        }
    }
}
