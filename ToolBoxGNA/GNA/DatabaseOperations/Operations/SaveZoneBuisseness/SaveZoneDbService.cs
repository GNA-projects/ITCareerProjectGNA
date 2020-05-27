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
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info encryptInfo = new Operation_Info()
                {
                    operation_id = 8,
                    operation_type_id = 3,
                    additional_info = fileName,
                    file_path = path,
                    file_type = "File For Encryption",
                    isSuccessfull = isSuccesfull
                };
                user.last_operation_id = 8;
                user.Operation_Info.Add(encryptInfo);
                context.SaveChanges();
            }
        }

        public static void AddEncryptFileEngine(string fileName, string password, string IV)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                EncryptorEngine encrypt = new EncryptorEngine()
                {
                    user_Id = CurrentUser.user.id,
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
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                Operation_Info decryptInfo = new Operation_Info()
                {
                    operation_id = 9,
                    operation_type_id = 3,
                    additional_info = fileName,
                    file_path = path,
                    file_type = "File For Decryption",
                    isSuccessfull = isSuccesfull
                };
                user.last_operation_id = 9;
                user.Operation_Info.Add(decryptInfo);
                context.SaveChanges();  
            }
        }
        public static void AddDecryptFileEngine(string fileName, string destPath, string password, string IV)
        {
            using (GNAEntities context = new GNAEntities())
            {
                Users user = context.Users.FirstOrDefault(x => x.id == CurrentUser.user.id);
                EncryptorEngine decrypt = new EncryptorEngine()
                {
                    user_Id = CurrentUser.user.id,
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
