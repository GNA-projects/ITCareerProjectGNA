using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox_GNA.Controller.PasswordManager.Entities;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ToolBox_GNA.Controller.PasswordManager.Services
{
	public static class PasswordServices
	{
		public static List<Password> GetChromePasswords()
		{
			List<Password> passwords = new List<Password>();

			SqliteConnection sqliteChromeData = new SqliteConnection(ReturnSqlitePathToChrome());
			sqliteChromeData.Open();
			string commandGetInfo = "SELECT origin_url,username_value,password_value FROM logins";
			SqliteCommand sqliteCommand = new SqliteCommand(commandGetInfo, sqliteChromeData);
			SqliteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
			while (sqliteDataReader.Read())
			{
				string url = sqliteDataReader.GetString(0);
				string username = sqliteDataReader.GetString(1);
				string password = DecryptPassword(sqliteDataReader);
				passwords.Add(new Password(url,username,password));
			}
			sqliteChromeData.Close();

			return passwords;
		}

		private static string DecryptPassword(SqliteDataReader sqliteDataReader)
		{
			string passwordBlob = ASCIIEncoding.ASCII.GetString((byte[])sqliteDataReader[2]);
			try
			{
				byte[] passwordByte = ProtectedData.Unprotect((byte[])sqliteDataReader[2], null, DataProtectionScope.CurrentUser);
				string passwordString = ASCIIEncoding.ASCII.GetString(passwordByte);
				return passwordString;
			}
			catch (Exception)
			{
				return passwordBlob;
			}
				
		}

		private static string ReturnSqlitePathToChrome()
		{
			string dataSource = "Data Source=";
			string localData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string loginData = @"\Google\Chrome\User Data\Login Data";
			return dataSource + localData + loginData;
		}
	}
}
