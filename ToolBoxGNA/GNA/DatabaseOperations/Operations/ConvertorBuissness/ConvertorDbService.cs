using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOperations.Operations.ConvertorBuissness
{
    public static class ConvertorDbService
    {
        public static void AddDocConvert(string fileName, string filePath, bool isSuccsessful)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info docConvInfo = new Operation_Info()
                {
                    operation_id = 10,
                    operation_type_id = 4,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = "Document",
                    isSuccessfull = isSuccsessful,
                };
                try
                {

                context.Operation_Info.Add(docConvInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == docConvInfo.id).Users.Add(user);
                user.last_operation_id = 10;
                context.SaveChanges();
                }
                catch (InvalidOperationException)
                {

                    MessageBox.Show("Invalid Db parameters. Please try again!");
                }
            }


        }
        public static void AddImageConvert(string fileName, string filePath, bool isSuccsessful)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info docConvInfo = new Operation_Info()
                {
                    operation_id = 11,
                    operation_type_id = 4,
                    file_name = fileName,
                    file_path = filePath,
                    file_type = "Image",
                    isSuccessfull = isSuccsessful,
                };
                try
                {

                }
                catch (InvalidOperationException)
                {

                    MessageBox.Show("Invalid Db parameters. Please try again!");
                }
                context.Operation_Info.Add(docConvInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == docConvInfo.id).Users.Add(user);
                user.last_operation_id = 11;
                context.SaveChanges();
            }


        }
    }
}




