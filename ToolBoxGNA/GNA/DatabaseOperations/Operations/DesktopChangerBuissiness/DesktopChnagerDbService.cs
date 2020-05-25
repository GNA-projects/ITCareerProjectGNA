using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOperations.Operations.DesktopChangerBuissiness
{
    public static class DesktopChnagerDbService
    {
        public static void AddDesktopChange(string filename,string path, bool isSuccessfull)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info deskChangerInfo = new Operation_Info()
                {
                    operation_type_id = 7,
                    operation_id = 14,
                    file_name = filename,
                    file_path = path,
                    file_type = "Image",
                    isSuccessfull = isSuccessfull
                };
                try
                {

                }
                catch (InvalidOperationException)
                {

                    MessageBox.Show("Invalid Db parameters. Please try again!");
                }
                context.Operation_Info.Add(deskChangerInfo);
                context.SaveChanges();
                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == deskChangerInfo.id).Users.Add(user);
                user.last_operation_id = 14;
                context.SaveChanges();
            }
        }
    }
}
