using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Operations.LoginRegister
{
    public static class RegisterService
    {
        public static void RegisterUser(string Username, string password)
        {
            StringBuilder hashedPassword = new StringBuilder();
            using (GNAEntities context = new GNAEntities())
            {
                using (MD5 md5 = MD5.Create())
                {

                    byte[] hashPassword = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                    foreach (var hash in hashPassword)
                    {
                        hashedPassword.Append(hash.ToString("X2"));
                    }

                }
                string pass = hashedPassword.ToString();
                Users user = new Users()
                {
                    username = Username,
                    password = pass,
                    register_date = DateTime.Now,
                    IsAdmin = false
                };
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
