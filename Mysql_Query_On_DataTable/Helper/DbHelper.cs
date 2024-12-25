using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Mysql_Query_On_DataTable.Helper
{
	public class DbHelper
	{

		public static string connectionString;
		private const string KEY = "YourSecretKey123"; // Change this to a secure key
		private const string CONFIG_FILE = "dbconfig.enc";
		public DbHelper()
		{

		}
		public DbHelper(string server, string database, string username, string password, string port)
		{
			connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};Port={port};";
		}

		public bool SalvarConfEncripada()
		{
			try
			{
				if (string.IsNullOrEmpty(connectionString))
					throw new InvalidOperationException("Connection string not set");

				byte[] encryptedData = EncryptString(connectionString);
				File.WriteAllBytes(CONFIG_FILE, encryptedData);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool TestaConexaoOnBoot()
		{
			try
			{
				if (!File.Exists(CONFIG_FILE))
					return false;

				byte[] encryptedData = File.ReadAllBytes(CONFIG_FILE);
				connectionString = DecryptString(encryptedData);
				return TestConnection();
			}
			catch
			{
				return false;
			}
		}

		private byte[] EncryptString(string plainText)
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = Encoding.UTF8.GetBytes(KEY).Take(32).ToArray();
				aes.IV = new byte[16];

				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
					using (StreamWriter sw = new StreamWriter(cs))
					{
						sw.Write(plainText);
					}
					return ms.ToArray();
				}
			}
		}

		private string DecryptString(byte[] cipherText)
		{
			using (Aes aes = Aes.Create())
			{
				aes.Key = Encoding.UTF8.GetBytes(KEY).Take(32).ToArray();
				aes.IV = new byte[16];

				using (MemoryStream ms = new MemoryStream(cipherText))
				using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
				using (StreamReader sr = new StreamReader(cs))
				{
					return sr.ReadToEnd();
				}
			}
		}

		public bool TestConnection()
		{
			try
			{
				using (var connection = new MySqlConnection(connectionString))
				{
					connection.Open();
					return true;
				}
			}
			catch
			{
				return false;
			}
		}

		public DataTable ExecuteQuery(string query)
		{
			try
			{
				using (var connection = new MySqlConnection(connectionString))
				{
					connection.Open();
					using (var command = new MySqlCommand(query, connection))
					{
						var dataTable = new DataTable();
						new MySqlDataAdapter(command).Fill(dataTable);
						return dataTable;
					}
				}
			}
			catch (Exception)
			{

				throw;
			}
		}

		public DataSet ConvertToDataSet(DataTable dataTable, string tableName = "Table")
		{
			var dataSet = new DataSet();
			dataTable.TableName = tableName;
			dataSet.Tables.Add(dataTable);
			return dataSet;
		}
	}
}
