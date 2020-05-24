using DatabaseOperations.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations
{
    public static class CurrentUser
    {
        public static int ID { get; set; }
        public static string Username { get; set; }
        public static int  lastOperation_id { get; set; }
    }
}
