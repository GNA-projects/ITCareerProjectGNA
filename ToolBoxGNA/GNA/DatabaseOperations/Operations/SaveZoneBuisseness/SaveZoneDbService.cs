using DatabaseOperations.Model;
using Org.BouncyCastle.Math.EC.Rfc8032;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.SaveZoneBuisseness
{
    public static class SaveZoneDbService
    {
        public static void AddEncryptFileInfo(string fileName, string path, bool isSuccesfull)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info encryptInfo = new Operation_Info()
                {
                    operation_id = 8,
                    operation_type_id = 3,
                    file_name = fileName,
                    file_path = path,
                    file_type = "File For Encryption",
                    isSuccessfull = isSuccesfull
                };

                context.Operation_Info.Add(encryptInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == encryptInfo.id).Users.Add(user);
                user.last_operation_id = 8;
                context.SaveChanges();
            }
        }

        public static void AddEncryptFileEngine(string fileName, string password, string IV)
        {
            using (GNAEntities context = new GNAEntities())
            {

                EncryptorEngine encrypt = new EncryptorEngine()
                {
                    user_Id = CurrentUser.ID,
                    encrypted_name = fileName,
                    encrypted_password = password,
                    encrypted_IV = IV,
                };

                context.EncryptorEngine.Add(encrypt);
                context.SaveChanges();
            }

        }

        public static void AddDecryptFileInfo(string fileName, string path, bool isSuccesfull)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Operation_Info decryptInfo = new Operation_Info()
                {
                    operation_id = 9,
                    operation_type_id = 3,
                    file_name = fileName,
                    file_path = path,
                    file_type = "File For Decryption",
                    isSuccessfull = isSuccesfull
                };

                context.Operation_Info.Add(decryptInfo);
                context.SaveChanges();

                Users user = context.Users.FirstOrDefault(x => x.username == CurrentUser.Username);
                context.Operation_Info.Include("Users").FirstOrDefault(x => x.id == decryptInfo.id).Users.Add(user);
                user.last_operation_id = 9;
                context.SaveChanges();
            }
        }
        public static void AddDecryptFileEngine(string fileName, string destPath, string password, string IV)
        {
            using (GNAEntities context = new GNAEntities())
            {
                EncryptorEngine decrypt = new EncryptorEngine()
                {
                    user_Id = CurrentUser.ID,
                    encrypted_password = password,
                    encrypted_IV = IV,
                    decrypted_name = fileName,
                    decrypted_filePath = destPath
                };

                context.EncryptorEngine.Add(decrypt);
                context.SaveChanges();
            }

        }
        public static List<EncryptorEngine> GetAllEntitiesWithName(string filename)
        {
            using (GNAEntities context = new GNAEntities())
            {
                var encryptorEngines = context.EncryptorEngine.Where(x => x.encrypted_name == filename).ToList();
                return encryptorEngines;
            }

        }
        public static EncryptorEngine GetEntity(string filename)
        {
            using (GNAEntities context = new GNAEntities())
            {
                var entitiy = context.EncryptorEngine.FirstOrDefault(x => x.encrypted_name == filename);
                return entitiy;
            }
        }
        public static void RemoveFromEncrypted(string fileName)
        {
            using (GNAEntities context = new GNAEntities())
            {
                var entitiy = context.EncryptorEngine.FirstOrDefault(x => x.encrypted_name == fileName);
                context.EncryptorEngine.Remove(entitiy);
                context.SaveChanges();
            }
        }



    }
}
