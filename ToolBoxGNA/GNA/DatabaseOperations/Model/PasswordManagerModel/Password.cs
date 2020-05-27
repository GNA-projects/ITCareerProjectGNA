using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations.Model.PasswordManagerModel
{
	public class Password
	{
		public string LoginUrl { get; set; }
		public string LoginUsername { get; set; }
		public string LoginPassword { get; set; }
		public Password(string url, string username, string password)
		{
			LoginUrl = url;
			LoginUsername = username;
			LoginPassword = password;
		}
	}
}
