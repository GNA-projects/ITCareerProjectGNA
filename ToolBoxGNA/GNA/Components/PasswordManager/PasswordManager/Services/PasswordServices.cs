using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.IO;
using PasswordManager.PasswordManager.Entities;
using DatabaseOperations.Operations.PasswordManagerBuissiness;

namespace PasswordManager.PasswordManager.Services
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
				passwords.Add(new Password(url, username, password));
			}
			sqliteChromeData.Close();
			PasswordManagerServices.AddPasswordOperation();
			return passwords;
		}

		private static string DecryptPassword(SqliteDataReader sqliteDataReader)
		{
			string passwordBlob = Encoding.ASCII.GetString((byte[])sqliteDataReader[2]);
			try
			{
				byte[] passwordByte = ProtectedData.Unprotect((byte[])sqliteDataReader[2], null, DataProtectionScope.CurrentUser);
				string passwordString = Encoding.ASCII.GetString(passwordByte);
				return passwordString;
			}
			catch (Exception)
			{
				return passwordBlob;
			}

		}

		public static string ReturnSqlitePathToChrome()
		{
			string dataSource = "Data Source=";
			string localData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string loginData = @"\Google\Chrome\User Data\Default\Login Data";
			string defaultPath = @"\Google\Chrome\User Data\Default\Login Data GNA";

			FileStream fileLoginDataCopy = new FileStream(localData + defaultPath, FileMode.Create);
			fileLoginDataCopy.Close();

			FileStream fileData = File.Open(localData + loginData, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			byte[] fileDataBytes = new byte[fileData.Length];
			fileData.Read(fileDataBytes, 0, (int)fileData.Length);
			File.WriteAllBytes(localData + defaultPath, fileDataBytes);

			return dataSource + localData + defaultPath;
		}

	}
}
