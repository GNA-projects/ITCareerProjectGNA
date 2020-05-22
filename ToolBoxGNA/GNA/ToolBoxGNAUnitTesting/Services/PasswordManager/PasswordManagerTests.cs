using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordManager.PasswordManager.Services;

namespace ToolBoxGNAUnitTesting.Services.PasswordManager
{
	[TestClass]
	public class PasswordManagerTests
	{
		[TestMethod]
		public void ReturnSqlitePathToChrome_IsNotNull()
		{
			string path = PasswordServices.ReturnSqlitePathToChrome();
			Assert.IsNotNull(path);
		}

		[TestMethod]
		public void ReturnSqlitePathToChrome_IsChromePath()
		{
			bool isChromePath = false;
			string path = PasswordServices.ReturnSqlitePathToChrome();
			if (path.Contains("Google"))
			{
				isChromePath = true;
			}
			Assert.IsTrue(isChromePath);
		}

		[TestMethod]
		public void ReturnSqlitePathToChrome_IsLocalPath()
		{
			bool isLocalPath = false;
			string path = PasswordServices.ReturnSqlitePathToChrome();
			if (path.Contains("Local"))
			{
				isLocalPath = true;
			}
			Assert.IsTrue(isLocalPath);
		}
	}
}
